using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ClauseGenerator : MonoBehaviour {

    private static string[] wordList = System.IO.File.ReadAllLines(@"Assets\ListOfWords.txt");
    public static int desiredClauseLength = 35;

	public static string getRandomClause()
    {
        StringBuilder randomClause = new StringBuilder();
        string delimiter = " ";
        while(desiredClauseLength > randomClause.Length)
        {
            int randomIndex = Random.Range(0, wordList.Length);
            string randomWord = wordList[randomIndex];
            randomClause.Append(delimiter);
            randomClause.Append(randomWord);
        }
       
        return randomClause.ToString().Trim() ;
    }
}
