using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swim_away : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        print("working");
        transform.position -= Vector3.right * Time.deltaTime;
    }
}
