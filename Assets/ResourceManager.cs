using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class ResourceManager : MonoBehaviour
{
    public TextMeshProUGUI resourceDisplay;

    void Start()
    {
        resourceDisplay.text = "0";
    }

    public void requestResourcesBeAdded(int clauseValue)
    {
        awardResources(clauseValue);
    }

    private void awardResources(int clauseValue) 
    {
        int startingResources = Int32.Parse(resourceDisplay.text);
        int resultingResources = startingResources + clauseValue;
        resourceDisplay.text = resultingResources.ToString();
    }

    public bool checkForAvailableFunds(int cost)
    {
        if (Int32.Parse(resourceDisplay.text) - cost >= 0)
        {
            return true;
        }
        return false;
    }

    public void pullFunds(int charged)
    {
        resourceDisplay.text = (Int32.Parse(resourceDisplay.text) - charged).ToString();
    }
}
