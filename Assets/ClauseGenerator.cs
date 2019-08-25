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
    
    //private static string[] wordList = getWords();
    void Awake()
    {
        this.wordList = textAsset.text.Split(new[] { Environment.NewLine },
            StringSplitOptions.None);
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

        return randomClause.ToString().Trim() ;
    }

    //private static string[] getWords()
    //{
    //    string path = "Assets/ListOfWords.txt";

    //    StreamReader reader = new StreamReader(path);
    //    List<string> wordList = new List<string>();

    //    while (!reader.EndOfStream)
    //    {
    //        wordList.Add(reader.ReadLine());
    //    }
    //    return wordList.ToArray() ;
    //}
}
