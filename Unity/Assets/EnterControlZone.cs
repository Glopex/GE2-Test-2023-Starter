using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterControlZone : MonoBehaviour
{
    public Transform smoothLook;
    public GameObject boidref;
    bool isfollowing;
    // Start is called before the first frame update

    private void Update()
    {
        if(isfollowing == true)
        {
            gameObject.transform.LookAt(smoothLook);
            gameObject.transform.position = boidref.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print("sium");
        if(other.tag == "DodecaController")
        {
            
            gameObject.GetComponent<FPSController>().canlook = false;
            gameObject.transform.LookAt(smoothLook.position);
            boidref.SendMessage("setcontroll", true);
            isfollowing = true;
        }
    }
}
