using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Ritual Step", order = 5)]
public class RitualStep : ScriptableObject
{
    public List<DemonAttribute> counteringAttribtues;
}
