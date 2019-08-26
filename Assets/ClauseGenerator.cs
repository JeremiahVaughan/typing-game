using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;


public class ClauseGenerator : MonoBehaviour {

    public TextAsset textAsset;
    private string[] wordList;
    public int desiredClauseLength = 35;
    
    void Awake()
    {
        this.wordList = textAsset.text.Split(',');
    }

    public string getRandomClause()
    {
        StringBuilder randomClause = new StringBuilder();
        char delimiter = ' ';
        while(desiredClauseLength > randomClause.Length)
        {
            int randomIndex = UnityEngine.Random.Range(0, wordList.Length);
            string randomWord = wordList[randomIndex];
            randomClause.Append(delimiter);
            randomClause.Append(randomWord);
        }

        return randomClause.ToString().Trim();
    
    }
}
