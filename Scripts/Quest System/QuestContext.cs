using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestContext
{

    QuestManager questManager;
    QuestEvent questEvent;
    QuestEventExec eventExec;

    public QuestContext(QuestEvent questEvent, QuestEventExec eventExec){

        this.questEvent = questEvent;
        this.eventExec = eventExec;

    }

    public void QuestEventHasCompleted()
    {

    }

    public void RegisterObserver()
    {

    }

    public void RemoveObserver()
    {

    }

}
