using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetboid;
    public float distance;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, targetboid.transform.position) < distance)
        {
            gameObject.transform.position = new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        }
    }
}
