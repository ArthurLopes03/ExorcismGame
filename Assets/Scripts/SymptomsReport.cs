using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SymptomsReport : MonoBehaviour
{
    public TextMeshProUGUI symptomsList;

    public void CreateList(Demon demon)
    {
        foreach (Clue clue in demon.type.clues)
        {
            symptomsList.text += clue.description + "\n";
        }
    }
}
