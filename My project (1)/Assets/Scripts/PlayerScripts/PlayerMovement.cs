using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalMovement;
    private float verticalMovement;
    [SerializeField] Rigidbody rb;
    [SerializeField] float playerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(verticalMovement * playerSpeed, 0f,(- horizontalMovement) * playerSpeed);
    }
}
