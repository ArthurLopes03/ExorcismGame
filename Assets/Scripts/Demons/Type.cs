using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Demon/Type", order = 4)]
public class Type : DemonAttribute
{
    public List<Temperment> tempermentPool;

    public List<Temperment> incompatibleTemperment;
}
