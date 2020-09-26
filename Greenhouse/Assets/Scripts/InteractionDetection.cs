using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDetection : MonoBehaviour
{
    public bool RaycastActive;
    public Vector3 Origin;
    public float MaxDistance;
    public Vector3 Direction;
    public RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RaycastActive)
        {
           
            if(Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), MaxDistance))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.yellow);
                Debug.Log("Hit");
            }
        }
        else
        {

        }
    }
}
