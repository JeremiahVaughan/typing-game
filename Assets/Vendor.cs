using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour
{
    public ResourceManager resourceManager;
    public GameObject bearPrefab;

    public void requestBear()
    {
        int bearCost = 10;
        if (resourceManager.checkForAvailableFunds(bearCost))
        {
            resourceManager.pullFunds(bearCost);
            GameObject wordObj = Instantiate(bearPrefab, new Vector3(62.5f, -12.7f, 0f), new Quaternion());
            Debug.Log("perchased bear");
        }
    }
}
