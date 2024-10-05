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

    private void Start()
    {
        StartNewGame();
    }

    void StartNewGame()
    {
        Client client = clientFactory.CreateClient();

        Demon demon = demonFactory.CreateDemon(client);

        clientDescriptorFactory.CreateDescriptors(client);

        clueFactory.CreateClues(demon);
    }
}