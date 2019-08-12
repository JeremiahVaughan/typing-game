using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

    public ClauseManager clauseManager;

	// Update is called once per frame
	void Update () {
		foreach (char letter in Input.inputString)
        {
            clauseManager.TypeLetter(letter);
        }

	}
}
