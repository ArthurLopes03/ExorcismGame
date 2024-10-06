using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ritual : MonoBehaviour
{
    public RitualStep circle;
    public RitualStep item;
    public RitualStep incantation;

    public TextMeshProUGUI circleTag;
    public TextMeshProUGUI itemTag;
    public TextMeshProUGUI incantationTag;

    public Demon demon;

    public GameObject winText;
    public GameObject loseText;
    public GameObject Panel;

    public void SetCircle(RitualStep step)
    {
        circle = step;
        circleTag.text = step.name;
    }

    public void SetItem(RitualStep step)
    {
        item = step;
        itemTag.text = step.name;
    }

    public void SetIncantation(RitualStep step)
    {
        incantation = step;
        incantationTag.text = step.name;
    }

    public void PerformRitual()
    {
        if(circle != null || item != null || incantation != null)
        {
            int counter = 0;

            if(circle.counteringAttribtues.Contains(demon.temperment))
            {
                counter++;
            }

            if(item.counteringAttribtues.Contains(demon.type))
            {
                counter++;
            }

            if(incantation.counteringAttribtues.Contains(demon.kingdom))
            {
                counter++;
            }

            if(counter == 3)
            {
                Win();
            }
            else
            {
                Lose();
            }
        }
        else
        {
            Debug.Log("Please fill all slots");
        }
    }

    void Win()
    {
        Panel.gameObject.SetActive(false);
        winText.gameObject.SetActive(true);
    }

    void Lose()
    {
        Panel.gameObject.SetActive(false);
        loseText.gameObject.SetActive(true);
    }
}
