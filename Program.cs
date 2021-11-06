using System;

namespace MoveSpaceShip
{
    class Program
    {
        public GameObject Ship;
        private float waitTime = 1.0f;
        private float timer = 0.0f;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary> 
        /// X will be constalntly moving upon a timer that is started once the button is clicked
        /// then the left and right movement will be moving based on the joy stick and will move the z axis 
        /// so how will we make sure they can move in any other way
        /// 
        /// </summary>
        private void MoveShip()
        {
            Transform shipPOS = Ship.transform.positon;
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    timer = timer - waitTime;

                }
                else
                {
                    Ship.transform.Translate(shipPOS.x - 1.0f, shipPOS.y, shipPOS.z);
                }

            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                timer += Time.deltaTime;
                if (timer > waitTime)
                {
                    timer = timer - waitTime;

                }
                else
                {
                    Ship.transform.Translate(shipPOS.x + 1.0f, shipPOS.y, shipPOS.z);
                }
            }

        }

        private void TimeTrial()
        { private Text timeText;
        private int start_end;


        void OnTriggerEnter(Collider other)
        {
            // Destroy everything that leaves the trigger
            start_end = 0;
        }
        void OnTriggerExit(Collider other)
        {
            // Destroy everything that leaves the trigger
            start_end = 1;
        }
        //call this bellow in update
        private void Timer()
        {
            switch (start_end)
            {
                case 0:
                    timer += Time.deltaTime;
                    timeText.text = timer.ToString();
                    break;
                case 1:
                    timeText = timer.ToString();
                    break;
                default:
                    timer = 0.0f;
                    break;
            }
        }

        //end time trial 
        private void SpeedChange()
        {
            var RightTrigger = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger, OVRInput.Controller.RTouch);
            var LeftTrigger = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch);
             float speed;
            float maxSpeed = 20.0f;
            float minSpeed = 0.0f;

            if(RightTrigger => 0.1f)
            {
                
                if(speed = maxSpeed)
                {
                    speed = maxSpeed;
                }
                else
                {
                    speed += 1.0f;
                }
            }
            else
            {
                speed = speed;
            }
            if (LeftTrigger => 0.1f)
            {

                if (speed = minSpeed)
                {
                    speed = minSpeed;
                }
                else
                {
                    speed -= 1.0f;
                }
            }
            else
            {
                speed = speed;
            }
        }

    }
           
    
    
}

