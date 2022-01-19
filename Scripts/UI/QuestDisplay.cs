using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestDisplay : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] GameObject questSlotPrefab;
    public QuestManager questManager;
    public QuestSlot[] questSlots;
    public int selectedQuest = 0;

    [SerializeField] TextMeshProUGUI questNameText;
    [SerializeField] TextMeshProUGUI questDescriptionText;

    [SerializeField] GameObject questObjectiveHolder;
    [SerializeField] GameObject questObjectivePrefab;

    void OnEnable(){
        DisplayQuests();
    }

    private void OnDisable()
    {
        Clear();
    }

    public void DisplayQuests()
    {
        Clear();
        for (int i = 0; i < questManager.quests.Length; i++)
        {
            GameObject newSlot = Instantiate(questSlotPrefab, transform);
        }

        questSlots = GetComponentsInChildren<QuestSlot>();

        for (int i = 0; i < questSlots.Length; i++)
        {
            Quest instance;

            if (questManager.GetQuest(i, out instance))
                questSlots[i].SetQuest(instance);
            if (i == selectedQuest)
                SelectSlot(questSlots[i]);
        }
    }

    public void SelectSlot(QuestSlot _slot)
    {
        for(int i = 0; i < questSlots.Length; i++)
        {
            questSlots[i].Deselect();
        }
        _slot.Select();

        //Set the selected quest display info
        questNameText.SetText ( _slot.quest.questName );
        questDescriptionText.SetText(_slot.quest.questDescription);
        ClearObjectives();
        for (int i = 0; i < _slot.quest.questObjectives.Length; i++)
        {
            GameObject newObjectiveSlot = Instantiate(questObjectivePrefab, questObjectiveHolder.transform);
        }

    }

    public void Clear()
    {
        foreach (Transform child in transform)
            GameObject.Destroy(child.gameObject);
        questSlots = new QuestSlot[0]; //creates an array with no items
        selectedQuest = 0;
        ClearObjectives();
    }
    public void ClearObjectives()
    {
        foreach (Transform child in questObjectiveHolder.transform)
            GameObject.Destroy(child);
    }
}
