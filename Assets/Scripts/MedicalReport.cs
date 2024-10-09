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

    public ClientAttribute smoker;
    public ClientAttribute alcoholic;
    public void CreateMedicalReport(Client client, Demon demon)
    {
        if (demon.temperment.attributeTag == "Phlegmatic")
        {
            brain.SetActive(true);
            lungs.SetActive(true);
        }

        if(demon.temperment.attributeTag == "Sanguine")
        {
            heart.SetActive(true);
            liver.SetActive(true);
        }

        if(demon.temperment.attributeTag == "Choleric")
        {
            stomach.SetActive(true);
        }

        if(demon.temperment.attributeTag == "Melancholic")
        {
            urine.SetActive(true);
        }

        if(demon.type.attributeTag == "Fury")
        {
            scratches.SetActive(true);
        }

        if(client.attributes.Contains(smoker))
        {
            lungs.SetActive(true);
        }

        if(client.attributes.Contains(smoker))
        {
            liver.SetActive(true);
        }
    }
}
