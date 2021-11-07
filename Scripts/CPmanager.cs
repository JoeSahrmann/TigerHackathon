using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPmanager : MonoBehaviour
{
    //public Text CheckpointText;
    /* private string tempCheck;
     private int checkpoints = 0;
     private int checkPointtext;*/
    public GameObject StartSphere;
    public GameObject MidSphere;
    public GameObject EndSphere;
    private int checkpoints = 0;
    private int whichpoint;
    public GameObject CheckPoint1; 
       public GameObject CP2;
       public GameObject CP3;



    void OnTriggerEnter(Collider CheckPoint1)
    {
        switch (CheckPoint1.gameObject.name)
        {
            case "Red_Spaceship":
                checkpoints += 1;
                whichpoint += 1;
                CheckPointMover();
                break;
            default:
                
                break;
        }

    }
   /*   void OnTriggerExit(Collider CheckPoint)
       {
        switch (CheckPoint1.gameObject.name)
        {
            case "Red_Spaceship":
                //checkpoints += 1;
                whichpoint += 1;
                CheckPointMover();
                break;
            default:
                CheckpointText.text = "" + checkpoints;
                break;
        }

    }*/
    // Update is called once per frame
    private void CheckPointMover()
    {
        switch (whichpoint)
        {
            case 1:
                
                var CP2POS = CP2.transform.position;
                var CP2ROT = CP2.transform.rotation;
               // var CP2SCL = CP2.transform.localScale;

                CheckPoint1.transform.position = CP2POS;
                CheckPoint1.transform.rotation = CP2ROT;
               // CheckPoint1.transform.localScale = CP2SCL;
                break;
            case 2:
                var CP3POS = CP3.transform.position;
                var CP3ROT = CP3.transform.rotation;
               // var CP3SCL = CP3.transform.localScale;

                CheckPoint1.transform.position = CP3POS;
                CheckPoint1.transform.rotation = CP3ROT;
               // CheckPoint1.transform.localScale = CP3SCL;
                break;
            default:
                break; 
        }
    }
    void Update()
    {
        if(checkpoints == 1)
        {
            StartSphere.SetActive(true);
        }
        if (checkpoints == 2)
        {
            MidSphere.SetActive(true);
        }
        if (checkpoints == 3)
        {
            EndSphere.SetActive(true);
        }
        //tempCheck = CheckpointText.text;
        //checkPointtext = int.Parse(tempCheck);
        //CheckpointText.text = ""+ checkPointtext + checkpoints;
    }
}
