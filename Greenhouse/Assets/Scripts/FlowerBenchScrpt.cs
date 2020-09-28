using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBenchScrpt : MonoBehaviour
{
    public bool BenchOpen;
    public GameObject MainCamera;
    public GameObject BenchCamera;
    public Canvas UiCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BenchOpen)
        {
            if (Input.GetButtonDown("Interact"))
            {
                CloseBench();
            }

        }
    }

    public void OpenBench()
    {
        BenchOpen = true;
        BenchCamera.SetActive(true);
        UiCanvas.GetComponent<Canvas>().worldCamera = BenchCamera.GetComponent<Camera>();
        MainCamera.SetActive(false);
    }

    public void CloseBench()
    {
        BenchOpen = false;
        MainCamera.SetActive(true);
        UiCanvas.GetComponent<Canvas>().worldCamera = MainCamera.GetComponent<Camera>();
        BenchCamera.SetActive(false);
        StaticScrpt.RaycastActive = true;
        StaticScrpt.Lockmovement = false;
    }
}
