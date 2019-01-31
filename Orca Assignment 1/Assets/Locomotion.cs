using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    public GameObject xrRig = null;
    public bool gazeBasedMove = false;
    public float stareLength = 4.0f;
    public List<GameObject> moveTo = new List<GameObject>();
    private float currentTimer = 0.0f;
    private int currentIndex = 0;
    private bool startMovement = false;

    private float lastDistance = 0.0f;
    private float lastHeadPosition = 0.0f;
    private float distanceMoveError = 0.001f;

    //private VREyeRaycaster = <VREyeRaycaster>();
    //private VRStandardAssets.Utils.VREyeRaycaster sg;
    private GazeInteraction sg;
    private FadeIn fi;
    //private IncreaseVignette iv;



    //public GameObject objectCurrentlyLookingAt = null;



    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        sg = GetComponent<GazeInteraction>();
        //iv = GetComponent<IncreaseVignette>();
        fi = GetComponent<FadeIn>();
        SetLocation(currentIndex);


    }

    // Update is called once per frame
    void Update()
    {
      
        if (gazeBasedMove)
        {
            CheckLookAtLength();
        }
        if (startMovement)
        {
            //TriggerMove();
            StartCoroutine(ChangeLevel());
        }
    }

    private IEnumerator ChangeLevel()
    {
        float fadeTime = GetComponent<FadeIn>().BeginFade(1);
        //Debug.Log(fadeTime);
        yield return new WaitForSeconds(4);
        TriggerMove();
        fadeTime = GetComponent<FadeIn>().BeginFade(-1);
    }

    private void SetLocation(int index)
    {
        if (moveTo[index] != null)
        {
            moveTo[index].SetActive(true);
        }
    }

    private void CheckLookAtLength()
    {

        if (GameObject.ReferenceEquals(sg.selected, moveTo[currentIndex]) && moveTo != null)
        {
            currentTimer += Time.deltaTime;
            if (currentTimer > stareLength)
            {
                startMovement = true;
            }
        }
        else
        {
            currentTimer = 0.0f;
        }
    }


    private void TriggerMove()
    {

        if (Vector3.Distance(xrRig.transform.position, new Vector3(moveTo[currentIndex].transform.position.x, moveTo[currentIndex].transform.position.y, moveTo[currentIndex].transform.position.z)) > distanceMoveError)
        {
            xrRig.transform.position = new Vector3(moveTo[currentIndex].transform.position.x, moveTo[currentIndex].transform.position.y, moveTo[currentIndex].transform.position.z);

            xrRig.transform.right = moveTo[currentIndex].transform.forward;
        }
        else
        {
            startMovement = false;
            moveTo[currentIndex].SetActive(false);
            SetLocation(currentIndex);
        }
    }

}