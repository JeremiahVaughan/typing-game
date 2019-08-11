using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

    public List<Word> words;

    public WordSpawner wordSpawner;

    private void Start()
    {
        AddWord();
        AddWord();
        AddWord();
    }

    private void AddWord()
    {
        WordDisplay wordDisplay = wordSpawner.SpawnWord();

        Word word = new Word(WordGenerator.getRandomWord(), wordDisplay);
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {

    }
    
}
