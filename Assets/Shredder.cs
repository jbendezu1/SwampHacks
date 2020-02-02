using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shredder : MonoBehaviour
{
    public static bool collided = false;
    public static float finalPosition;
    public Text timer;

    private void OnTriggerEnter(Collider other)
    {
        float num = InputManager.finalTime;
        finalPosition = other.gameObject.transform.position.z;
        Destroy(other.gameObject);
        timer.gameObject.gameObject.gameObject.SetActive(true);
        timer.text = "Time: " + (Mathf.Round(num * 100) / 100).ToString() + " seconds";
        collided = true;
    }
}
