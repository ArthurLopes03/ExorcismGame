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
    MedicalReport medicalReport;

    [SerializeField]
    ClueFactory clueFactory;

    [SerializeField]
    ClientEvalForm evalForm;

    [SerializeField]
    GuessInput guessInput;

    public int clientAttributeCount;

    private void Start()
    {
        StartNewGame();
    }

    void StartNewGame()
    {
        Client client = clientFactory.CreateClient(clientAttributeCount);

        Demon demon = demonFactory.CreateDemon(client);
        
        clueFactory.ProcessClues(demon, client);

        evalForm.CreateEvaluationSheet(client);

        guessInput.demon = demon;
    }
}