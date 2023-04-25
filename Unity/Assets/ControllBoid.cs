using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControllBoid : SteeringBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraref;
    Vector3 target;
    private void Start()
    {
        
    }
    public override Vector3 Calculate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            target = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z+1) ;
        }
        /*else if (Input.GetKeyDown(KeyCode.S))
        {
            target = gameObject.transform.;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            refpoint.localPosition = new Vector3(refpoint.localPosition.x - 1, refpoint.localPosition.y, refpoint.localPosition.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            refpoint.localPosition = new Vector3(refpoint.localPosition.x + 1, refpoint.localPosition.y, refpoint.localPosition.z);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            refpoint.localPosition = new Vector3(refpoint.localPosition.x, refpoint.localPosition.y + 1, refpoint.localPosition.z);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            refpoint.localPosition = new Vector3(refpoint.localPosition.x, refpoint.localPosition.y - 1, refpoint.localPosition.z);
        }
        else refpoint.localPosition = ogrefpoint;*/
        return boid.SeekForce(target);
    }

    public void setpriority(float value)
    {
        weight = value;
    }
}
