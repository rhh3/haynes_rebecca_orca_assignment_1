using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Interactable>().Interaction += OnRaycastEnter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRaycastEnter()
    {

    }
}
