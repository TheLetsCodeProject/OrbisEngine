using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class StatMessage : IMessage
{
    // Clean: This system, implemented issue could be resolved by changing the IMessage interface
    public string Message {
        get {
            throw new System.NotImplementedException();
        }
        set {
            throw new System.NotImplementedException();
        }
    }

    public string TargetStat;
    public StatModifier Modifier;
    public StatMessage(string targetStat, StatModifier modifier)
    {
        TargetStat = targetStat;
        Modifier = modifier;
    }

    public StatMessage(string targetStat)
    {
        TargetStat = targetStat;
    }

    public const string UpdateStat = "UPDATE_STAT";
    public const string GetStat = "GET_STAT";
}
