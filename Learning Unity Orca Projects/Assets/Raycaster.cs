using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            GameObject objectHit = hit.collider.gameObject;
            Interactable a = objectHit.GetComponent<Interactable>();
            if (a != null)
            {
                a.OnInteract;
            }
        }
    }
}
