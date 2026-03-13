using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SeedDatabase", menuName = "Scriptable Objects/SeedDatabase")]
public class SeedDatabase : ScriptableObject
{
    public List<SeedConfig> Seeds;

    public SeedConfig GetById(string seedId)
    {
        return Seeds.Find(s => s.SeedId == seedId);
    }
}
