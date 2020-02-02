using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Toggle : MonoBehaviour
{
    public GameObject mygameObject;

    public void Function()
    {
        if (gameObject.activeSelf == false)
        {
            gameObject.SetActive(true);
        }
        else
            gameObject.SetActive(false);
    }
}
