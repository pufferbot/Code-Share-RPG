using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestSlot : MonoBehaviour
{
    public int index = 0;
    public Quest quest = null; //holds the quest and info; eg. the objective tree or whether it is complete

    public Image panel;
    public Color notSelectedColor;
    public Color selectedColor;

    public TextMeshProUGUI nameBox;
    public Image icon;

    private void Awake()
    {
        icon.sprite = null;
    }

    public void SetQuest(Quest _quest) //setting the slot to display a quest
    {
        nameBox.text = _quest.questName;
        quest = _quest;
        icon.sprite = _quest.icon;

        quest = _quest;
        icon.SetNativeSize(); //stops squishing and stretching of icon
        RectTransform rt = icon.transform.GetComponent<RectTransform>();
        float width = rt.sizeDelta.x / rt.sizeDelta.y; //makes height consistant and width proportional between quests
        rt.sizeDelta = new Vector2(width * 64, 64);
    }

    public void RemoveQuest()  //the slot will clear itself of the quest it currently is storing
    {
        this.quest = null;
        this.nameBox.text = null;
        this.icon.sprite = null;
    }

    public void Selected()
    {
        if (GetComponentInParent<InventoryDisplay>())
        {
            //GetComponentInParent<InventoryDisplay>().SelectSlot(this);
        }
    }

    public void Select()
    {
        panel.color = selectedColor;
    }

    public void Deselect()
    {
        panel.color = notSelectedColor;
    }
}
