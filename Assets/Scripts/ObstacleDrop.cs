using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDrop : MonoBehaviour
{
    private MeshRenderer objRenderer;
    private Rigidbody objRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // make the drop obstacle invisible 
        objRenderer = GetComponent<MeshRenderer>();
        objRenderer.enabled = false;
        // suspend the drop obstacle in air
        objRigidbody = GetComponent<Rigidbody>();
        objRigidbody.useGravity = false;
    }

    // This trigger is for the secondary collider. Use ObjectHit script for scoring 
    private void OnTriggerEnter(Collider other)
    {
        // if player entered secondary trigger collider drop the obstacle
        if (other.gameObject.CompareTag("Player"))
        {
            objRenderer.enabled = true;
            objRigidbody.useGravity = true;
        }
    }
}
