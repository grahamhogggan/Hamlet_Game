using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private TextWriter writer;
    [SerializeField] private float waitToHideTime;
    [SerializeField] private TMP_Text nextGoalText;
    [SerializeField] private GameObject nextGoalPanel;
    [SerializeField] private GameObject hide;

    void Update()
    {
        Debug.Log(PersistentData.tutorialStep);
        if (Overlord.paused) return;
        if (writer.TimeSinceFinished() > waitToHideTime)
        {
            hide.SetActive(false);
        }
        else
        {
            hide.SetActive(true);
        }
        if (nextGoalText.text == "")
        {
            nextGoalPanel.SetActive(false);
        }
        else
        {
            nextGoalPanel.SetActive(true);
        }
        if (PersistentData.tutorialStep == 1)
        {
            writer.SetTarget("Welcome to Denmark, have a moment to take in your surroundings");
            PersistentData.tutorialStep = 2;
        }
        else if (PersistentData.tutorialStep == 2)
        {
            if (writer.TimeSinceFinished() >= 7)
            {
                PersistentData.tutorialStep = 3;
            }
        }
        else if (PersistentData.tutorialStep == 3)
        {
            writer.SetTarget("Before heading inside the castle, you need to gather resources. Go collect 5 pieces of wood");
            PersistentData.tutorialStep = 4;
        }
        else if (PersistentData.tutorialStep == 4)
        {
            nextGoalText.text = "Gather 5 wood";
            int numCollected = PlayerInventory.Quantity("wood") + PlayerInventory.Quantity("palm wood");
            if (numCollected >= 5)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 5;
            }
        }
        else if (PersistentData.tutorialStep == 5)
        {
            writer.SetTarget("Press TAB to enter your inventory. Click the '+' next to the planks recipe to craft wood planks");
            PersistentData.tutorialStep = 6;
        }
        else if (PersistentData.tutorialStep == 6)
        {
            nextGoalText.text = "Craft 5 planks";
            int numCrafted = PlayerInventory.Quantity("planks");
            if (numCrafted >= 5)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 7;
            }
        }
        else if (PersistentData.tutorialStep == 7)
        {
            writer.SetTarget("You'll also want to be able to mine more effectively. Craft sticks, and then craft a pickaxe");
            PersistentData.tutorialStep = 8;
        }
        else if (PersistentData.tutorialStep == 8)
        {
            nextGoalText.text = "Craft a pickaxe";
            int numCrafted = PlayerInventory.Quantity("pickaxe");
            if (numCrafted >= 1)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 9;
            }
        }
        else if (PersistentData.tutorialStep == 9)
        {
            writer.SetTarget("Using this pickaxe, you can collect more valuable materials found only underground. Collect 3 coal");
            PersistentData.tutorialStep = 10;
        }
        else if (PersistentData.tutorialStep == 10)
        {
            nextGoalText.text = "Collect 3 coal";
            int numCrafted = PlayerInventory.Quantity("coal");
            if (numCrafted >= 3)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 11;
            }
        }
        else if (PersistentData.tutorialStep == 11)
        {
            writer.SetTarget("Use the coal and a stick to craft a torch. Torches heal you as you stand next to them");
            PersistentData.tutorialStep = 67;
        }
        else if (PersistentData.tutorialStep == 67)
        {
            nextGoalText.text = "Craft a torch";
            int numCrafted = PlayerInventory.Quantity("torch");
            if (numCrafted >= 1)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 12;
            }
        }
        else if (PersistentData.tutorialStep == 12)
        {
            writer.SetTarget("Metal can be used to make tools");
            PersistentData.tutorialStep = 13;
        }
        else if (PersistentData.tutorialStep == 13)
        {
            nextGoalText.text = "Collect 5 metal";
            int numCrafted = PlayerInventory.Quantity("metal");
            if (numCrafted >= 5)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 14;
            }
        }
        else if (PersistentData.tutorialStep == 14)
        {
            nextGoalText.text = "Craft a sword by crafting 3 metal into a beam, then combining with a stick";
            int numCrafted = PlayerInventory.Quantity("sword");
            if (numCrafted >= 1)
            {
                nextGoalText.text = "";
                PersistentData.tutorialStep = 15;
            }
        }
        else if (PersistentData.tutorialStep == 15)
        {
            if (writer.TimeSinceFinished() >= 4)
            {
                PersistentData.tutorialStep = 16;
            }
        }
        else if (PersistentData.tutorialStep == 16)
        {
            writer.SetTarget("You may have noticed the energy you've been gathering by mining and fighting. This can be used to unlock upgrades in your inventory");
            PersistentData.tutorialStep = 17;
        }
        else if (PersistentData.tutorialStep == 17)
        {
            if (writer.TimeSinceFinished() >= 10)
            {
                PersistentData.tutorialStep = 18;
            }
        }
        else if (PersistentData.tutorialStep == 18)
        {
            writer.SetTarget("Good luck on your journey. Be prepared for a fight on Night 5");
            PersistentData.tutorialStep = 19;
        }
    }
}
