using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestDisplay : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] GameObject questSlot;
    public QuestManager questManager;
    public QuestSlot[] questSlots;
    public int selectedQuest = 0;

    [SerializeField] TextMeshProUGUI questNameText;
    [SerializeField] Image iconDisplay;
    [SerializeField] TextMeshProUGUI questInfoText;
    [SerializeField] TextMeshProUGUI questDescriptionText;

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
            GameObject newSlot = Instantiate(questSlot, transform);
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
        //questInfoText.SetText(_slot.questInstance.questName);
        questDescriptionText.SetText(_slot.quest.questDescription);
        iconDisplay.sprite = _slot.icon.sprite;
        iconDisplay.SetNativeSize();
        RectTransform rt = iconDisplay.transform.GetComponent<RectTransform>();
        float width = rt.sizeDelta.x / rt.sizeDelta.y;
        rt.sizeDelta = new Vector2(width * 128, 128);

    }

    public void Clear()
    {
        foreach (Transform child in transform)
            GameObject.Destroy(child.gameObject);
        questSlots = new QuestSlot[0]; //creates an array with no items
        selectedQuest = 0;
    }

}
