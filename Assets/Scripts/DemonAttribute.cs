using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DemonAttribute : ScriptableObject
{
    public string attributeTag;

    public List<DemonAttribute> incompatibleAttributes;
}
