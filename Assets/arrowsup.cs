using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;
public class arrowsup : MonoBehaviour
{
    public GameObject Astronaut;
    
    // Start is called before the first frame update
    void Start()
    {
        /*up.GetComponent<Button>().onClick.AddListener(() =>
        {
            
        });*/
        print("hi");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("hello");
        }
    }
   
}
