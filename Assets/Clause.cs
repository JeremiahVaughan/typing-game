using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Clause {

    public string clause;
    private int typeIndex;

    ClauseDisplay clauseDisplay;

    public Clause(string clause, ClauseDisplay clauseDisplay)
    {
        this.clause = clause;
        typeIndex = 0;

        this.clauseDisplay = clauseDisplay;
        clauseDisplay.setClause(clause);
    }

    public char getNextLetter()
    {
        return clause[typeIndex];
    }

    public void typeLetter(char letter)
    {
        if (typeIndex <= clause.Length && getNextLetter() == letter)
        {
            clauseDisplay.highlightLetter(typeIndex);
            typeIndex++;
        } else if (typeIndex >= clause.Length)
        {
            clauseDisplay.removeClause();
        }
        
    }
}
