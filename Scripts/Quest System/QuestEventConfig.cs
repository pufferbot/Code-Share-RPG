using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestEventConfig
{
    public string objectiveName;
    public QuestEvent.EventType eventType;
    public int[] links;
    public int xpReward;
    public CustomNodeBehavior onCompleteScript;
    
}
