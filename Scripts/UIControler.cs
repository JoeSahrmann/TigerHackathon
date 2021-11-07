using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIControler : MonoBehaviour
{
    public GameObject CDTextHolder;
    public Text CDtext;
    public Text timeText;

    public GameObject endCheckpoint;
    private float runtimer = 0.0f;
    private float cdtimer = 0.0f;
    private float twoTimer = 1.0f;
    private float threeTimer = 2.0f;
    private float startTimer = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cdtimer += Time.deltaTime;
        if (!CDTextHolder.activeInHierarchy)
        {
            RunTimer();
        }
        CountDown();


    }
    public void RunTimer()
    {
        if (!endCheckpoint.activeInHierarchy)
        {
            runtimer += Time.deltaTime;
            timeText.text = runtimer.ToString();
        }
        else
        {
            timeText.text = runtimer.ToString();
        }
        
    }
    public void CountDown()
    {
        if (cdtimer >= twoTimer){
            CDtext.text = "2";
        }
        if(cdtimer >= threeTimer)
        {
            CDtext.text = "1";
        }
        if (cdtimer >= startTimer)
        {
            CDtext.text = "0";
            CDTextHolder.SetActive(false);
            
        }
    }

   
    //call this bellow in update
    /*
    private void Checkpoint()
    {
        switch (start_end)
        {
            case 0:
                
                break;
            case 1:
                timeText.text = timer.ToString();
                break;
            default:
                timer = 0.0f;
                break;
        }
    }*/
}
