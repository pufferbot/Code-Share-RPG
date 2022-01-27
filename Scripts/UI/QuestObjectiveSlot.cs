using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestObjectiveSlot : MonoBehaviour
{
    public int index = 0;
    public QuestObjective questObjective = null; //holds the quest objective info; eg. the name or whether it is complete

    public Image panel;
    public Color notSelectedColor;
    public Color selectedColor;

    public TextMeshProUGUI nameBox;

    public void SetQuestObjective(QuestObjective _questObjective) //setting the slot to display a quest objective
    {
        nameBox.text = _questObjective.objectiveDescription;
        questObjective = _questObjective;
    }

    public void RemoveQuestObjective()  //the slot will clear itself of the quest objective it currently is storing
    {
        this.questObjective= null;
        this.nameBox.text = null;
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
