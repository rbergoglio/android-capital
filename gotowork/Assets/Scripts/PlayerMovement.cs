using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public CharacterController2D controller;

    public float runSpeed = 40f;

    private float horizontalMove = 0f;

    private bool jump = false;

    private bool crouch = false;

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        controller.Move(horizontalMove * Time.fixedDeltaTime,jump,crouch);

    }
}
