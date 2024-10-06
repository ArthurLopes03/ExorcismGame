using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueFactory : MonoBehaviour
{
    public GameObject cluePrefab;
    public Transform listObject;
    List<Clue> cluesList;
    public void CreateClues(Demon demon, Client client, int randomClues, int redHerrings)
    {
        cluesList = new List<Clue>();

        AddRedHerrings(client.attributes, redHerrings);

        cluesList.Add(SetClue(demon.kingdom.clues));
        cluesList.Add(SetClue(demon.type.clues));
        cluesList.Add(SetClue(demon.temperment.clues));

        AddRandomClue(demon, randomClues);

        cluesList.Shuffle();

        foreach (Clue clue in cluesList)
        {
            TextMeshProUGUI text = Instantiate(cluePrefab, listObject).GetComponentInChildren<TextMeshProUGUI>();

            text.text = clue.description;
        }
    }

    void AddRedHerrings(List<ClientAttribute> clientAttributes, int redHerrings)
    {
        for(int i = 0; i < redHerrings; i++)
        {
            int giveUp = 0;

        restart:
            int counter = 0;
            giveUp++;
            if (giveUp == 5)
                break;

            int j = Random.Range(0, clientAttributes.Count);

            if (clientAttributes[j].possibleRedHerrings == null || clientAttributes[j].possibleRedHerrings.Count == 0)
                goto restart;

            List<Clue> clues = clientAttributes[j].possibleRedHerrings;

        tryagain:

            int r = Random.Range(0, clues.Count);


            if (cluesList.Contains(clues[r]))
            {
                if (counter == 10)
                {
                    goto restart;
                }
                else
                {
                    counter++;
                    goto tryagain;
                }
            }
            else
            {
                cluesList.Add(clues[r]);
            }
        }
    }

    Clue SetClue(List<Clue> clues)
    {
        Clue clue = null;

        tryagain:
        int r = Random.Range(0, clues.Count);

        if (cluesList.Contains(clues[r]))
        {
            goto tryagain;
        }
        else
        {
            clue = clues[r];
        }

        return clue;
    }

    void AddRandomClue(Demon demon, int amountToAdd)
    {
        List<Clue> cluePool = new List<Clue>();
        cluePool.AddRange(demon.kingdom.clues);
        cluePool.AddRange(demon.type.clues);
        cluePool.AddRange(demon.temperment.clues);

        for(int i = 0; i < amountToAdd; i++)
        {
            tryagain:
            int r = Random.Range(0, cluePool.Count);

            if (cluesList.Contains(cluePool[r]))
            {
                goto tryagain;
            }
            else
            {
                cluesList.Add(cluePool[r]);
            }
        }
    }
}