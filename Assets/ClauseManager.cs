using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClauseManager : MonoBehaviour {

    public ClauseSpawner clauseSpawner;
    private Clause activeClause;

    private void Start()
    {
        AddClause();
    }

    private void AddClause()
    {
        ClauseDisplay clauseDisplay = clauseSpawner.spawnClause();

        activeClause = new Clause(ClauseGenerator.getRandomClause(), clauseDisplay);

    }

    public void TypeLetter(char letter)
    {
        activeClause.typeLetter(letter);
    }
    
}
