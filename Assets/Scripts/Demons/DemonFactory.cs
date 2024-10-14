using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class DemonFactory : MonoBehaviour
{
    public GameObject demonPrefab;
    public Demon CreateDemon(Client client)
    { 
        Demon demon = Instantiate(demonPrefab).GetComponent<Demon>();


        List<Kingdom> kingdoms = new List<Kingdom>();

        CreateKingdomPool(kingdoms, client);

        List<Temperment> temperments = new List<Temperment>();

        CreateTempermentPool(temperments, client);

        List<Type> types = new List<Type>();

        CreateTypePool(types, client);


        //Set the kingdom
        int r = Random.Range(0, kingdoms.Count);
        demon.kingdom = kingdoms[r];
        
        //Add the kingdom affinities
        types.AddRange(demon.kingdom.typePool);
        temperments.AddRange(demon.kingdom.tempermentPool);

        //Remove the incompatabilities
        foreach(Type attribute in demon.kingdom.incompatibleType)
        {
            types.RemoveAll(t => t == attribute);
        }

        foreach (Temperment attribute in demon.kingdom.incompatibleTemperment)
        {
            temperments.RemoveAll(x => x == attribute);
        }

        //Set the Type
        r = Random.Range (0, types.Count);
        demon.type = types[r];

        //Add affinities
        temperments.AddRange(demon.type.tempermentPool);

        //Remove the incompatabilities
        foreach(Temperment attribute in demon.type.incompatibleTemperment)
        {
            temperments.RemoveAll(x => x == attribute);
        }

        //Set the temperment
        r = Random.Range(0, temperments.Count);
        demon.temperment = temperments[r];

        return demon;
    }

    void CreateKingdomPool(List<Kingdom> kingdoms, Client client)
    {
        kingdoms.AddRange(client.job.kingdomPool);

        foreach (ClientAttribute attribute in client.attributes)
        {
            kingdoms.AddRange(attribute.kingdomPool);
        }
    }

    void CreateTempermentPool(List<Temperment> temperment, Client client)
    {
        temperment.AddRange(client.job.tempermentPool);

        foreach (ClientAttribute attribute in client.attributes)
        {
            temperment.AddRange(attribute.tempermentPool);
        }
    }

    void CreateTypePool(List<Type> types, Client client)
    {
        types.AddRange(client.job.typePool);

        foreach (ClientAttribute attribute in client.attributes)
        {
            types.AddRange(attribute.typePool);
        }
    }
}
