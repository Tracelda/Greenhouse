using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticScrpt
{
    private static bool lockmovement, raycastactive;

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
}
