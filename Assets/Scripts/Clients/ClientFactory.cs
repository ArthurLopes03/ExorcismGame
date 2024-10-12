using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor;
using UnityEngine;


public class ClientFactory : MonoBehaviour
{
    public List<Job> jobsPool;
    public List<ClientAttribute> attributePool;
    public List<string> firstNames;
    public List<string> lastNames;

    public GameObject clientPrefab;

    public Client CreateClient(int clientAttributeCount)
    {
        // Create the client
        Client client = Instantiate(clientPrefab).GetComponent<Client>();

        //Assign a random job
        int r = Random.Range(0, jobsPool.Count);

        client.job = jobsPool[r];

        //Assign a random name
        AssignName(client);

        //Assign random attributes
        AssignAttributes(client, clientAttributeCount);

        return client;
    }

    void AssignName(Client client)
    {
        int r = Random.Range(0, firstNames.Count);

        string name = firstNames[r];

        r = Random.Range(0, lastNames.Count);

        name = name + " " + lastNames[r];

        client.clientName = name;
    }

    void AssignAttributes(Client client, int clientAttributeCount)
    {
        Job job = client.job;
        for (int i = 0; i < clientAttributeCount; i++)
        {
            Retry:
            int r = Random.Range(0, job.attributesPool.Count);
            if(client.attributes.Contains(job.attributesPool[r]))
            {
                goto Retry;
            }
            else
            {
                client.attributes.Add(job.attributesPool[r]);
            }
        }
    }
}