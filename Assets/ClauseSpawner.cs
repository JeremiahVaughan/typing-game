using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClauseSpawner : MonoBehaviour {

    public GameObject clausePrefab;
    public Transform clauseCanvas;


	public ClauseDisplay spawnClause()
    {
        GameObject wordObj = Instantiate(clausePrefab, clauseCanvas);
        ClauseDisplay wordDisplay = wordObj.GetComponent<ClauseDisplay>();

        return wordDisplay;
    }
}
