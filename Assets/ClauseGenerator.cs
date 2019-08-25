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
        Debug.Log("Regular text sample: " + "bike test anchovies revolver highvault");
        Debug.Log("Robust text sample: " + randomClause.ToString().Trim());
        //String[] testStringArray = { "string1", "string2", "string3" };
        return randomClause.ToString().Trim();
        ////return this.wordList[0].ToString() + " " + wordList[1].ToString() + " " + wordList[2].ToString();
        ////return "someword" + " " +  "anotherword" + " " + "moreword";
        //randomClause.Clear();
        //randomClause.Append(testStringArray[0]);
        //randomClause.Append(" ");
        //randomClause.Append(testStringArray[1]);
        //randomClause.Append(" ");
        //randomClause.Append(testStringArray[2]);
        //return randomClause.ToString();
    }
}
