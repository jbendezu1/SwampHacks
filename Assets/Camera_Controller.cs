using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Controller : MonoBehaviour
{
    public bool camSwitch = false;
    public Camera farCam;
    public Camera closeCam;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (farCam.gameObject.activeSelf == true)
            {
                farCam.gameObject.SetActive(false);
                closeCam.gameObject.SetActive(true);
            }
            else if (closeCam.gameObject.activeSelf == true)
            {
                closeCam.gameObject.SetActive(false);
                farCam.gameObject.SetActive(true);
            }
            
        }
    }
}
