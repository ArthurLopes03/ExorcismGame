using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Clue/Described", order = 4)]
public class DescribedClue : Clue
{
    [SerializeField]
    string description;

    public override void AddClue()
    {
        GameObject descriptor = GameObject.Find("Symptom Descriptors");

        descriptor.GetComponent<TextMeshProUGUI>().text += "- " + description + "\n";
    }
}
