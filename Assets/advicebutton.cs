using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class advicebutton : MonoBehaviour
{
    public GameObject Panel;
    void Start()
    {
        Panel = null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            if (Panel = null)
            {
                Panel.SetActive(true);
            }
            else
            {
                Panel = null;
            }
    }
}




    

