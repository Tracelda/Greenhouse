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
    public GameObject[] Benches;

    public enum BenchName
    {
       Flowers, CrossBreeding, Bushes, Trees
    }
    public BenchName IDNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RaycastActive)
        {
            //DetectInput();
            if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, MaxDistance))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.yellow);
                Debug.Log("Hit");
                for (int i = 0; i< 4 ; i++)
                {
                    Debug.Log(Benches[i] + "aaaa" + i + " Benches length: " + Benches.Length);
                    
                    if (Benches[i] == hit.transform.gameObject)
                    {
                        IDNum = (BenchName)i;
                        Debug.Log("IDNUM = " + IDNum);
                    }
                }
            }
            switch (IDNum)
            {
                case BenchName.Flowers:
                    if (Input.GetButton("Interact"))
                    {
                        Debug.Log("Flowers");
                    }
                    break;

                case BenchName.CrossBreeding:
                    if (DetectInput())
                    {
                        Debug.Log("CrossBreeding");
                    }
                    break;

                case BenchName.Bushes:
                    if (DetectInput())
                    {
                        Debug.Log("Bushes");
                    }
                    break;

                case BenchName.Trees:
                    if (DetectInput())
                    {
                        Debug.Log("Trees");
                    }
                    break;
            }
        }
        else
        {

        }
    }

    public bool DetectInput()
    {
        bool ButtonPressed;
        if (Input.GetButtonDown("Interact"))
        {
            Debug.Log("Interact button hit");
            ButtonPressed = true;
        }
        else
        {
            ButtonPressed = false;
        }

        return ButtonPressed;
    }
}
