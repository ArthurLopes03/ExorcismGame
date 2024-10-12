using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Client/Attribute", order = 0)]
public class ClientAttribute : ScriptableObject
{
    public string attributeTag;

    public List<Temperment> tempermentPool;
    public List<Kingdom> kingdomPool;
    public List<Type> typePool;

    public List<Clue> redHerrings;
}
