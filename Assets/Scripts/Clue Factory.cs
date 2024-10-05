using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueFactory : MonoBehaviour
{
    public GameObject cluePrefab;
    public Transform listObject;

    public void CreateClues(Demon demon)
    {
        List<Clue> clues = new List<Clue>();

        SetClue(demon.kingdom.clues);

        SetClue(demon.type.clues);

        SetClue(demon.temperment.clues);
    }

    void SetClue(List<Clue> clues)
    {
        Clue clue = null;

        int r = Random.Range(0, clues.Count);

        clue = clues[r];

        TextMeshProUGUI text = Instantiate(cluePrefab, listObject).GetComponentInChildren<TextMeshProUGUI>();

        text.text = clue.description;
    }
}
