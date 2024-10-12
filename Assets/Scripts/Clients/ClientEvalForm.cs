using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClientEvalForm : MonoBehaviour
{
    public TextMeshProUGUI nameTag;
    public TextMeshProUGUI jobTag;
    public TextMeshProUGUI listOfAttributes;

    public void CreateEvaluationSheet(Client client)
    {
        nameTag.text = "Name: " + client.clientName;
        jobTag.text = "Job: " + client.job.attributeTag;

        foreach (ClientAttribute attribute in client.attributes)
        {
            listOfAttributes.text += attribute.attributeTag + "\n";
        }
    }
}
