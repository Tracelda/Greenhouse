using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public bool Follow;
    public GameObject Target;
    public float DistanceFromPlayer;
    public float Hight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Follow)
        {
            this.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y + Hight, Target.transform.position.z + DistanceFromPlayer);
        }
    }
}
