﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class CharacterBase
{
    public string Name = "Empty";
    public string NickName = "EmptyNN";
    public int Lvl = 1;


    public CharStats MaxStats = new CharStats();
    public CharStats CurStats = new CharStats();
    public List<Skills> Skills = new List<Skills>();
    public string FacePath;
    public string SpriteGUI;
    
    public List<string> testString = new List<string>
    {
        "Attack",
        "Shield",

    };
    //[SerializeField] public Dictionary<int, BaseBattleActions> BaseBattleActions;

    //public Weapon WeaponOne;

    //public EquipmentBase Head;
    //public EquipmentBase Body;
    //public EquipmentBase AccOne;
    //public EquipmentBase AccTwo;




    public virtual void Test(string test)
    {
        Debug.Log(this.Name);
    }

}

public static class CharacterExtensions
{
    public static CharacterBase Character<T>(this CharacterBase data, T other)
    {

        using (MemoryStream ms = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, other);
            ms.Position = 0;
            return (CharacterBase)formatter.Deserialize(ms);
        }
    }

}