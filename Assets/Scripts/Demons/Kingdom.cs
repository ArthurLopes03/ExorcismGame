using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Demon/Kingdom", order = 3)]
public class Kingdom : DemonAttribute
{
    public List<Type> typePool;
    public List<Temperment> tempermentPool;

    public List<Type> incompatibleType;
    public List<Temperment> incompatibleTemperment;
}