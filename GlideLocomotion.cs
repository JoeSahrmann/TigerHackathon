using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlideLocomotion : MonoBehaviour
{
    public float velocity = 0.4f;
    private CharacterController character;
    public bool isWalking = true;
    public float comfortAngle = 10f;
    private bool hasRotated = true;

    public Transform player;
    public Transform rotate;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        OVRInput.Controller controller = OVRInput.GetConnectedControllers();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 moveDirection = Camera.main.transform.forward;
        //moveDirection *= velocity * Time.deltaTime;
        //moveDirection.y = 0f; //keep your feet on the ground
        //transform.position += moveDirection;
        //character.Move(moveDirection);
        //character.SimpleMove(Camera.main.transform.forward * velocity);
        //if (Clicked())
        //{
        //    isWalking = !isWalking;
        //}
        //if (isWalking)
        //{
        //    character.SimpleMove(Camera.main.transform.forward * velocity);
        //}
        if (Input.GetButtonDown("Jump"))
            isWalking = true;
        else if (Input.GetButtonUp("Jump"))
            isWalking = false;
        //if (OVRInput.GetDown(OVRInput.Button.Two))
        // isWalking = true;
        //else if (OVRInput.GetUp(OVRInput.Button.Two))
        // isWalking = false;
        if (isWalking)
            character.SimpleMove(transform.forward * velocity);
        float axis = Input.GetAxis("Horizontal");
        //float axis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
      /*  if (axis > 0.5f)
        {
            if (!hasRotated)
                transform.Rotate(0, comfortAngle, 0);
            hasRotated = true;
        }
        else if (axis < -0.5f)
        {
            if (!hasRotated)
                transform.Rotate(0, -comfortAngle, 0);
            hasRotated = true;
        }
        else
        {
            hasRotated = false;
        }*/
        var joystickAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch);

        if (joystickAxis.x >= .8f)
        {
            player.transform.RotateAround(rotate.position, rotate.up, speed * 0.1f);
        }
        if (joystickAxis.x <= -.8f)
        {
            player.transform.RotateAround(rotate.position, rotate.up, speed * -0.1f);
        }



    }
    public bool Clicked()
    {
        return Input.anyKeyDown;
        //return Input.GetButtonDown("Fire1");
    }
}

