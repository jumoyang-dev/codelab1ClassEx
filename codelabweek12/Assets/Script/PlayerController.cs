using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;

    Rigidbody myRb;

    private void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 getInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 dir = getInput.normalized;

        //Debug.Log(myRb.velocity);
        myRb.velocity = dir * moveSpeed;

        Vector3 lookPos = new Vector3(
                transform.position.x + myRb.velocity.x,
                transform.position.y,
                transform.position.z + myRb.velocity.z
            );
        transform.LookAt(lookPos);
    }
}
