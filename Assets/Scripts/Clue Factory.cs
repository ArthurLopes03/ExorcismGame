using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueFactory : MonoBehaviour
{
    public GameObject cluePrefab;
    public Transform listObject;
    List<Clue> cluesList;

    public int randomClues;
    public void CreateClues(Demon demon)
    {
        cluesList = new List<Clue>();

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