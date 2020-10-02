using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantType {Flower, Tree, Bush};
public enum Maturity {Seed, Sapling, Mature};

[System.Serializable]
public struct Plant
{
    public PlantType plantType;
    public Maturity maturity;
    public int TimeTillMature;
}

public class PlantBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
