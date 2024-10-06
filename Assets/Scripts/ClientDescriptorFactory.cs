using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ClientDescriptorFactory : MonoBehaviour
{
    public GameObject descriptorPrefab;

    public Transform listObject;

    public TextMeshProUGUI nameTag;
    public TextMeshProUGUI jobTag;

    public void CreateDescriptors(Client client)
    {
        foreach (ClientAttribute attribtue in client.attributes)
        {
            TextMeshProUGUI text = Instantiate(descriptorPrefab, listObject).GetComponentInChildren<TextMeshProUGUI>();

            text.text = attribtue.description;
        }

        nameTag.text = "Name: " + client.clientName;
        jobTag.text = "Occupation: " + client.job.attributeTag;
    }
}
