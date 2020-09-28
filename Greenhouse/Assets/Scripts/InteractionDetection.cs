using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDetection : MonoBehaviour
{
    public Vector3 Origin;
    public float MaxDistance;
    public Vector3 Direction;
    public RaycastHit hit;
    public GameObject[] Benches;

    //Scripts
    public FlowerBenchScrpt FlowerBenchScrpt;

    public enum BenchName
    {
       Flowers, CrossBreeding, Bushes, Trees
    }
    public BenchName IDNum;
    // Start is called before the first frame update
    void Start()
    {
        StaticScrpt.RaycastActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticScrpt.RaycastActive)
        {
            //DetectInput();
            if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.forward), out hit, MaxDistance))
            {
                //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.yellow);
                //Debug.Log("Hit");
                for (int i = 0; i< 4 ; i++)
                {
                    //Debug.Log(Benches[i] + "aaaa" + i + " Benches length: " + Benches.Length);
                    
                    if (Benches[i] == hit.transform.gameObject)
                    {
                        IDNum = (BenchName)i;
                        //Debug.Log("IDNUM = " + IDNum);
                    }
                }
            }
            switch (IDNum)
            {
                case BenchName.Flowers:
                    if (Input.GetButtonDown("Interact"))
                    {
                        Debug.Log("Flowers");
                        StaticScrpt.Lockmovement = true;
                        StaticScrpt.RaycastActive = false;
                        FlowerBenchScrpt.OpenBench();
                    }
                    break;

                case BenchName.CrossBreeding:
                    if (Input.GetButtonDown("Interact"))
                    {
                        Debug.Log("CrossBreeding");
                        StaticScrpt.Lockmovement = true;
                        StaticScrpt.RaycastActive = false;
                        FlowerBenchScrpt.OpenBench();
                    }
                    break;

                case BenchName.Bushes:
                    if (Input.GetButtonDown("Interact"))
                    {
                        Debug.Log("Bushes");
                        StaticScrpt.Lockmovement = true;
                        StaticScrpt.RaycastActive = false;
                        FlowerBenchScrpt.OpenBench();
                    }
                    break;

                case BenchName.Trees:
                    if (Input.GetButtonDown("Interact"))
                    {
                        Debug.Log("Trees");
                        StaticScrpt.Lockmovement = true;
                        StaticScrpt.RaycastActive = false;
                        FlowerBenchScrpt.OpenBench();
                    }
                    break;
            }
        }
        else
        {

        }
    }
}
