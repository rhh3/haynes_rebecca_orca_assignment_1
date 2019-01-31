using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
   // public GameObject xrRig = null;
    //move to a object looking at it
    public bool gazeBasedMove = false;
    public float stareLength = 2.0f;
    public List<GameObject> moveTo = new List<GameObject>();
    private float currentTimer = 0.0f;
    //private float distanceX = 0.0f;
    //private float distanceZ = 0.0f;
    //private float distanceMoveError = 0.5f;
    //private int currentIndex = 0;
    private bool startMovement = false;

    //public float moveSpeed = 0.6f;

    private float lastDistance = 0.0f;
    private float lastHeadPosition = 0.0f;
    private float distanceError = 0.001f;

    //private VREyeRaycaster = <VREyeRaycaster>();


    // Start is called before the first frame update
    void Start()
    {
        //if (stareLength >= 2.0f) {

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
