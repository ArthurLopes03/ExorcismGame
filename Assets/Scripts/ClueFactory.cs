using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueFactory : MonoBehaviour
{
    public void ProcessClues(Demon demon, Client client)
    {
        List<Clue> clues = new List<Clue>();

        foreach (Clue clue in demon.temperment.clues)
        {
            if(!clues.Contains(clue))
            {
                clues.Add(clue);
            }
        }

        foreach (Clue clue in demon.type.clues)
        {
            if(!clues.Contains(clue))
            {
                clues.Add(clue);
            }
        }

        foreach (Clue clue in demon.kingdom.clues)
        {
            if(!clues.Contains(clue))
            {
                clues.Add(clue);
            }
        }

        foreach (ClientAttribute attribute in client.attributes)
        {
            foreach (Clue clue in attribute.redHerrings)
            {
                if (!clues.Contains(clue))
                {
                    clues.Add(clue);
                }
            }
        }
        AddClues(clues);
    }

    private void AddClues(List<Clue> clues)
    {
        foreach (Clue clue in clues)
        {
            clue.AddClue();
        }
    }
}
