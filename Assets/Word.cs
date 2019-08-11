using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

    public string word;
    private int typeIndex;

    WordDisplay wordDisplay;

    public Word(string word, WordDisplay wordDisplay)
    {
        this.word = word;
        typeIndex = 0;

        this.wordDisplay = wordDisplay;
        wordDisplay.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }
}
