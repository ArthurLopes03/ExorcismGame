using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskObjectSwitch : MonoBehaviour
{
    public void SwitchObjects()
    {
        foreach(Transform child in transform)
        {
            if(child.gameObject.activeSelf == true)
            {
                child.gameObject.SetActive(false);
            }
            else
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
