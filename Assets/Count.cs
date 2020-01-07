using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
	
	public GameObject gm;
	public GameObject target;
	public Text t1;
	public int point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 offset = gm.transform.position - this.transform.position;
            float sqrLen = offset.sqrMagnitude;
			print(sqrLen);
			print(point);
            // square the distance we compare with
            if (sqrLen < 0.01f)
            {
                int c = int.Parse(t1.text);
				if(point ==10)
				c+=point;
				else
					c-=point;
				t1.text = c.ToString();
				target.SetActive( false);
            }
    }
}
