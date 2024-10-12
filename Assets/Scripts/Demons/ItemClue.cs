using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Clue/Item", order = 4)]
public class ItemClue : Clue
{
    [SerializeField]
    GameObject clueItemPrefab;

    public override void AddClue()
    {
        GameObject itemSpawn = GameObject.Find("Clue Item Spawn");

        Instantiate(clueItemPrefab, itemSpawn.transform);
    }
}
