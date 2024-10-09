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
    ClientEvalForm evalForm;

    [SerializeField]
    SymptomsReport symptomsReport;

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

        medicalReport.CreateMedicalReport(client, demon);

        evalForm.CreateEvaluationSheet(client);

        symptomsReport.CreateList(demon);

        guessInput.demon = demon;
    }
}