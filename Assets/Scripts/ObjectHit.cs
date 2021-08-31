using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // color red and change tag only when player hits
        if(other.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "IsHit";
        }
    }
}
