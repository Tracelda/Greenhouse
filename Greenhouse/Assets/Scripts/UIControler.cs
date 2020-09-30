using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControler : MonoBehaviour
{
    public GameObject SeedMenu;
    // Start is called before the first frame update
    void Start()
    {
        StaticScrpt.SeedMenuActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticScrpt.SeedMenuActive)
        {
            SeedMenu.SetActive(true);
        }
        else
        {
            SeedMenu.SetActive(false);
        }
    }
}
