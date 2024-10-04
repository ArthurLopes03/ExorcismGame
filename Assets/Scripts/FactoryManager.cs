using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    [SerializeField]
    ClientFactory clientFactory;

    [SerializeField]
    DemonFactory demonFactory;

    private void Start()
    {
        StartNewGame();
    }

    void StartNewGame()
    {
        Client client = clientFactory.CreateClient();

        demonFactory.CreateDemon(client);
    }
}