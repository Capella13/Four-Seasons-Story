using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDK : MonoBehaviour
{
    GameObject logo;

    void Start()
    {
        this.logo = GameObject.Find("Logo");
    }

    
    void Update()
    {
        logo.transform.Rotate(0, 0, 0.3f);
        logo.transform.localScale += new Vector3(0.01f, 0.01f, 0);
        if (logo.transform.localScale.x > 5)
        {
            logo.transform.Rotate(0, 0, 0f);
            logo.transform.localScale = new Vector3(5, 5, 1);
            
        }
    }
}
