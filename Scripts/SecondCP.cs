using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SecondCP : MonoBehaviour
{
    public Text CheckpointText;
    private string tempCheck;
    private int checkpoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider CheckPoint2)
    {
        switch (CheckPoint2.gameObject.name)
        {
            case "Red_Spaceship":
                checkpoints += 1;
                break;
            default:
                CheckpointText.text = "" + checkpoints;
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {
        tempCheck = CheckpointText.text;
        checkpoints = int.Parse(tempCheck);
        CheckpointText.text = "" + checkpoints;
    }
}
