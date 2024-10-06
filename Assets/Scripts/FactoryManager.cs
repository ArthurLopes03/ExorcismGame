using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    [SerializeField]
    ClientFactory clientFactory;

    [SerializeField]
    DemonFactory demonFactory;

    [SerializeField]
    ClientDescriptorFactory clientDescriptorFactory;

    [SerializeField]
    ClueFactory clueFactory;

    [SerializeField]
    Ritual ritual;

    public int clientAttributeCount;
    public int randomClues;
    public int redHerrings;

    private void Start()
    {
        StartNewGame();
    }

    void StartNewGame()
    {
        Client client = clientFactory.CreateClient(clientAttributeCount);

        Demon demon = demonFactory.CreateDemon(client);

        clientDescriptorFactory.CreateDescriptors(client);

        clueFactory.CreateClues(demon, client, randomClues, redHerrings);

        ritual.demon = demon;
    }
}