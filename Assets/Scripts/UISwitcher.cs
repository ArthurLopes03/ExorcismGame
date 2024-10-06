using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISwitcher : MonoBehaviour
{
    public GameObject investigationUI;

    public GameObject preperationUI;

    public void SwitchToPreperation()
    {
        investigationUI.SetActive(false);
        preperationUI.SetActive(true);
    }
}
