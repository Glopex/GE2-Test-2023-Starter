using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodecaSpin : MonoBehaviour
{

    public float speed; //rotation speed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        gameObject.transform.Rotate(new Vector3(0.1f, 0.1f, 0.1f));
       
    }
}
