using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEventExec : MonoBehaviour
{
    public QuestEvent questEvent;
    public void Initialize(QuestEventConfig eventConfig)
    {
        questEvent = new QuestEvent(eventConfig.eventType, eventConfig.objectiveName, eventConfig.links, eventConfig.xpReward, eventConfig.onCompleteScript);
    }

    public void Execute()
    {
        questEvent.Complete();
    }

    public bool HasCompleted()
    {
        return questEvent.isCompleted;
    }

    public void GetNextQuestEvents()
    {

    }

    public void Notify()
    {

    }

}
