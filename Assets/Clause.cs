using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


public class Clause : MonoBehaviour {

    public string clause;
    public int clauseValue = 100;
    public int penalty = 5;

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

    public string getNextLetter()
    {
        return clause[typeIndex].ToString();
    }

    public void typeLetter(string letter)
    {
        if (endOfClauseReached() && (letter == " " || letter == "\r"))
        {
            clauseDisplay.removeClause();
            respawn();
        }

        if (typeIndex < clause.Length && getNextLetter() == letter)
        {
            clauseDisplay.highlightNextLetter();
            typeIndex++;

        } else if (typeIndex < clause.Length && getNextLetter() != letter)
        {
            clauseDisplay.markCurrentCharRed();
            owner.requestCameraShake();
            applyPenalty();
        }
        
    }

    private void respawn()
    {
        owner.requestRespawn(clauseValue);
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

    private void applyPenalty()
    {
        if (clauseValue - penalty > 0)
        {
            clauseValue = clauseValue - penalty;
        } else
        {
            clauseValue = 0;
        }
    }
}
