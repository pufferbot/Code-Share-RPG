using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    public Quest[] quests;

    //methods for other scripts wanting to know which quests are active
    public Quest[] GetActiveQuests()
    {
        Quest[] activeQuests = new Quest[0];
        for(int i = 0; i < quests.Length; i++)
        {
            if(quests[i].questState == Quest.QuestState.Active) 
            { 
                activeQuests[i] = quests[i]; 
            }
        }
        return activeQuests;
    }
    public Quest[] GetCompletedQuests()
    {
        Quest[] completedQuests = new Quest[0];
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].questState == Quest.QuestState.Completed)
            {
                completedQuests[i] = quests[i];
            }
        }
        return completedQuests;
    }
    public Quest[] GetFailedQuests()
    {
        Quest[] failedQuests = new Quest[0];
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].questState == Quest.QuestState.Failed)
            {
                failedQuests[i] = quests[i];
            }
        }
        return failedQuests;
    }

    public void BeginQuest(string questName)
    {
        for(int i = 0; i < quests.Length; i++)
        {
            if(quests[i].questName == questName)
            {
                quests[i].Begin();
            }
            else
            {
                Debug.LogError("No quest with the name " + questName + " was found! Check for typos or improperly deleted quests.");
            }
        }
    }
    public void CompleteQuest(string questName)
    {
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].questName == questName)
            {
                quests[i].Complete();
            }
            else
            {
                Debug.LogError("No quest with the name " + questName + " was found! Check for typos or improperly deleted quests.");
            }
        }
    }
    public void FailQuest(string questName)
    {
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].questName == questName)
            {
                quests[i].Complete();
            }
            else
            {
                Debug.LogError("No quest with the name " + questName + " was found! Check for typos or improperly deleted quests.");
            }
        }
    }

}
