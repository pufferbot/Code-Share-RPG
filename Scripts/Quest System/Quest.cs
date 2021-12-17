using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public string questName;
    public bool isActive;
    public bool isCompleted;
    public QuestEventExec eventExec;
    public QuestEventConfig[] events;
    public int xpReward;

    public void QuestEventCompleted(QuestEvent questEvent)
    {
        
    }

}