using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalReport : MonoBehaviour
{
    public GameObject brain;
    public GameObject lungs;
    public GameObject heart;
    public GameObject liver;
    public GameObject stomach;
    public GameObject urine;
    public GameObject scratches;

    public void UpdateMedicalReport(string keyword)
    {
        switch (keyword)
        {
            case "Brain":
                brain.SetActive(true);
                break;
            case "Lungs":
                lungs.SetActive(true);
                break;
            case "Heart":
                heart.SetActive(true);
                break;
            case "Liver":
                liver.SetActive(true);
                break;
            case "Stomach":
                stomach.SetActive(true);
                break;
            case "Urine":
                urine.SetActive(true);
                break;
            case "Scratches":
                scratches.SetActive(true);
                break;
            default:
                Debug.Log("Medical Keyword Error");
                break;
        }
    }
}
