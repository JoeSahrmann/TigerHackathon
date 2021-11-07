using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlideLocomotion : MonoBehaviour
{
    public float velocity = 10f;
    private CharacterController character;
    public bool isWalking = true;
    public GameObject CDtext;
    private bool hasRotated = true;
    public Text velocityText;
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
        /*
        if (Input.GetButtonDown("Jump"))
            isWalking = true;
        else if (Input.GetButtonUp("Jump"))
            isWalking = false;*/
        //if (OVRInput.GetDown(OVRInput.Button.Two))
        // isWalking = true;
        //else if (OVRInput.GetUp(OVRInput.Button.Two))
        // isWalking = false;
        if (!CDtext.activeInHierarchy)
        { 
            if (isWalking)
                    {
                        character.SimpleMove(transform.forward * velocity);
                         float joystickaxis = Input.GetAxis("Horizontal");
                    }

        }
       
           
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
        SpeedChange();


    }
    private void SpeedChange()
    {
        velocityText.text = velocity.ToString();
           var RightTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
        var LeftTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
     
        float maxSpeed = 40.0f;
        float minSpeed = 0.0f;

        if (RightTrigger >= 0.1f)
        {

            if (velocity == maxSpeed)
            {
                velocity = maxSpeed;
            }
            else
            {
                velocity += 1.0f;
            }
        }

        if (LeftTrigger >= 0.1f)
        {

            if (velocity == minSpeed)
            {
                velocity = minSpeed;
            }
            else
            {
                velocity -= 1.0f;
            }
        }

    }

}

