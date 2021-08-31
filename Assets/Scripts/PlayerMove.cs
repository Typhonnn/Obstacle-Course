using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float x, z;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }


}
