using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "ClientAttribute", order = 0)]
public class ClientAttribute : ScriptableObject
{
    public string attributeTag;

    public List<DemonAttribute> demonAttributePool;

    public string description;
}
