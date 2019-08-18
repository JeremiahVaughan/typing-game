using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Clause {

    public string clause;
    private int typeIndex;

    ClauseDisplay clauseDisplay;
    ClauseManager owner;

    public Clause(string clause, ClauseDisplay clauseDisplay, ClauseManager owner)
    {
        this.clause = clause;
        typeIndex = 0;

        this.clauseDisplay = clauseDisplay;
        clauseDisplay.setClause(clause);

        this.owner = owner;
    }

    public char getNextLetter()
    {
        return clause[typeIndex];
    }

    public void typeLetter(char letter)
    {
        if (typeIndex < clause.Length && getNextLetter() == letter)
        {
            clauseDisplay.highlightNextLetter();
            typeIndex++;

            if (endOfClauseReached())
            {
                clauseDisplay.removeClause();
                respawn();
            }

        } else if (typeIndex < clause.Length && getNextLetter() != letter)
        {
            clauseDisplay.markCurrentCharRed();
        }
        
    }

    private void respawn()
    {
        owner.requestRespawn();
    }

    private bool endOfClauseReached()
    {
        if (clause.Length == typeIndex)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
