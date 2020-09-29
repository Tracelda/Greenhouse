using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedMenuScrpt : MonoBehaviour
{
    public Animator Animator;
    public bool MenuOpen;
    public Text Text;

    public void OpenClose()
    {
        if(!MenuOpen)
        {
            SetTrue();
            Text.text = "<";
            MenuOpen = true;
        }
        else
        {
            SetFalse();
            Text.text = ">";
            MenuOpen = false;
        }
    }

    public void SetTrue()
    {
        Animator.SetBool("MenuOpen", true);
    }

    public void SetFalse()
    {
        Animator.SetBool("MenuOpen", false);
    }
}
