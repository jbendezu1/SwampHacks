using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public GameObject projectile, hill;

    public Slider mass, velocity, height;

    public Text countdown;
    public Text distance;

    public bool timerhasstarted = false;

    public static float finalTime = 0;
    public static float initvelocity = 0;

    // Update is called once per frame
    void Update()
    {
        Vector3 v = hill.transform.position;
        v.y = height.value;
        hill.transform.position = v;

        if (timerhasstarted == true)
           finalTime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            distance.text = "";            
            countdown.text = "";
            finalTime = 0;
            timerhasstarted = true;
            GameObject temp = Instantiate(projectile, projectile.transform.position, projectile.transform.rotation);

            Rigidbody rb = temp.transform.GetComponent<Rigidbody>();
            rb.transform.localScale = new Vector3(1, 1, 1);
            rb.mass = mass.value;

            temp.SetActive(true);
            temp.GetComponent<Rigidbody>().AddForce(temp.transform.up * velocity.value * 100);
            initvelocity = velocity.value;
        }
    }
}
