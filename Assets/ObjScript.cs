using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObjScript : MonoBehaviour
{
    public GameObject obj;
    public float timeLeft = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.active)
        {
            timeLeft -= Time.deltaTime;
           obj.GetComponentInChildren<TextMeshPro>().SetText((timeLeft).ToString("0"));
            if (timeLeft < 0.0f)
            {
                obj.active = false;
                timeLeft = 10.0f;
            }
        }
    }
}
