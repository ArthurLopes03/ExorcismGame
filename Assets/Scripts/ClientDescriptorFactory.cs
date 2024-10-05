using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ClientDescriptorFactory : MonoBehaviour
{
    public GameObject descriptorPrefab;

    public Transform listObject;

    public void CreateDescriptors(Client client)
    {
        foreach (ClientAttribute attribtue in client.attributes)
        {
            TextMeshProUGUI text = Instantiate(descriptorPrefab, listObject).GetComponentInChildren<TextMeshProUGUI>();

            text.text = attribtue.description;
        }
    }
}
