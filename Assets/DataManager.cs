using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class DataManager : MonoBehaviour
{
    public GameObject PivotPoint;
    public float timeLeft;
    public bool endLaunch;
    public Text finalText;
    public Text angleText;

    // Update is called once per frame
    void Update()
    {
        PrintResults();
    }

    public void PrintResults()
    {
        if (Shredder.collided == true)
        {
            float num = PivotPoint.transform.rotation.x;
            float barrelAngle = 90 - num;
            float time = InputManager.finalTime;
            float velocity = InputManager.initvelocity;
            float final;

            angleText.text = "angle: " + barrelAngle.ToString() ;
            //final = velocity * time + (9.8f * time * time) / 2;
            final = Shredder.finalPosition;
            finalText.text = "Distance: " + final.ToString() + " m";
            Shredder.collided = false;
        }
    }
}
