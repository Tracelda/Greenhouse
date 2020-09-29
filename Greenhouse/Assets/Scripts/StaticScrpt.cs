using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticScrpt
{
    private static bool lockmovement, raycastactive, seedmenuactive;

    public static bool Lockmovement
    {
        get
        {
            return lockmovement;
        }
        set
        {
            lockmovement = value;
        }
    }

    public static bool RaycastActive
    {
        get
        {
            return raycastactive;
        }
        set
        {
            raycastactive = value;
        }
    }

    public static bool SeedMenuActive
    {
        get
        {
            return seedmenuactive;
        }
        set
        {
            seedmenuactive = value;
        }
    }
}
