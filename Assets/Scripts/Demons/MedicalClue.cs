using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Clue/Medical", order = 4)]
public class MedicalClue : Clue
{
    [SerializeField]
    private string medicalKeyword;

    public override void AddClue()
    {
        GameObject medicalReport = GameObject.Find("Client Medical Report Open");

        medicalReport.GetComponent<MedicalReport>().UpdateMedicalReport(medicalKeyword);
    }
}
