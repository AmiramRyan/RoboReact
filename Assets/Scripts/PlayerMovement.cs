using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody myRb;
    [SerializeField] private float speed;
    private Vector3 movementVector;
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        if (!myRb)
        {
            Debug.LogError("Error: No rigidBody set");
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        movementVector = Vector3.zero;
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.z = Input.GetAxisRaw("Vertical");
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        myRb.MovePosition(transform.position + movementVector * speed * Time.deltaTime);
    }
}
