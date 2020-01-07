using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomPop : MonoBehaviour
{
    public GameObject []objs;
    public int size;
    public float timeLeft = 10.0f;
    public float timer = 0.0f;
    public int ind;
    // Start is called before the first frame update
    void Start()
    {
        size = objs.Length;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if (timer > 10.0f)
        {
            ind = Random.Range(0, size);
            print(ind);
            if(!objs[ind].active)
            objs[ind].active = true;
           
            timer = 0.0f;
            
        }
       
        
    }
   
    
}
