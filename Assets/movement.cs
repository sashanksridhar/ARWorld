using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movement : MonoBehaviour
{
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void front()
    {
        Vector3 position = obj.transform.position;
        position.z-= (float)0.04;
        obj.transform.position = position;
    }
    public void back()
        {
            Vector3 position = obj.transform.position;
    position.z+=(float)0.04;
            obj.transform.position = position;
    }
     public void left()
        {
            Vector3 position = obj.transform.position;
    position.x-=(float)0.04;
            obj.transform.position = position;
    }
    public void right()
        {
            Vector3 position = obj.transform.position;
    position.x+=(float)0.04;
            obj.transform.position = position;
        }

    public float speed = 0.04f;
    public float rotationSpeed = 0.04f;
    // Update is called once per frame
    public void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        

        obj.transform.Translate(0, 0, translation);
        obj.transform.Translate(rotation, 0, 0);
    }
}
