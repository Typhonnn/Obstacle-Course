using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    private float y = 1;
    [SerializeField] float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        y = Time.deltaTime * rotationSpeed;
        transform.Rotate(0f, y, 0f);
    }
}
