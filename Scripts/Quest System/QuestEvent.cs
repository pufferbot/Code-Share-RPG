using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvent
{

    public enum EventType{
        Fork, Branch, Merge, Join,
    };
    
    public string objectiveName;
    public EventType eventType;
    public int[] links;
    public bool isCompleted;
    public int xpReward;
    public CustomNodeBehavior onComplete;

    public QuestEvent(EventType _eventType, string _objectiveName, int[] _links, int _xpReward, CustomNodeBehavior _onComplete)
    {
        this.eventType = _eventType;
        this.objectiveName = _objectiveName;
        this.links = _links;
        this.xpReward = _xpReward;
        this.onComplete = _onComplete;
    }

    public void Complete()
    {
        onComplete.RunScript();

        switch ((int)eventType)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:
                
                break;
            case 3:

                break;
            default:
                break;
        }
    }

}
