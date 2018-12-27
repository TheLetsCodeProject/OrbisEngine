using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OrbisEngine.ItemSystem;

public class ItemStats : ItemComponent {

    #region SETUP
    public ItemStats(IItem baseItem) : base(baseItem) { }

    public override void InitialiseComponent()
    {
        messageHandlers.Add(StatMessage.UpdateStat, UpdateStat);

        stats = new Dictionary<string, Stat>();
    }
    #endregion

    private Dictionary<string, Stat> stats;

    private void UpdateStat(IMessage message)
    {
        StatMessage updateInfo = message as StatMessage;
        if (updateInfo == null)
            throw new System.Exception("A handler was provided an incorrect IMessage");

        if (stats.ContainsKey(updateInfo.TargetStat)) {
            stats[updateInfo.TargetStat].AddModifier(updateInfo.Modifier);
        } else
        {
            Stat stat = new Stat(0f);
            stat.AddModifier(updateInfo.Modifier);
            stats.Add(updateInfo.TargetStat, stat);
        }
    }

    public float this[string statName]
    {
        get
        {
            if (stats.ContainsKey(statName))
            {
                return stats[statName].Value;
            }

            Debug.LogWarning("The stats component does not contain a value for: " + statName);
            return 0f;
        }
    }

}
