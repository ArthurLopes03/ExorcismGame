using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "Job", order = 1)]
public class Job : ClientAttribute
{
    public List<ClientAttribute> attributesPool;
}
