using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[System.Serializable]
public class UntypedSubClause
{
    private StringBuilder untypedSubClause;

    public UntypedSubClause(string subClause)
    {
        untypedSubClause = new StringBuilder(subClause);
    }

    public char pop()
    {
        char result = untypedSubClause[0];
        untypedSubClause.Remove(0, 1);
        return result;
    }

    public string toStringWithFirstCharRed()
    {
        char currentCharacture = getNextChar();
        string highlightColor = "";

        if (currentCharacture == ' ')
        {
            highlightColor = "#F50F0F";
        }
        else
        {
            highlightColor = "#000000";
        }

        string textColor = "#F50F0F";

        StringBuilder untypedSubClauseCopy = new StringBuilder(untypedSubClause.ToString());
        StringBuilder subClauseSnapshot = new StringBuilder("");
        subClauseSnapshot.Append(
            "<mark=" + highlightColor + ">" +
            "<" + textColor + ">" +
            currentCharacture +
            "</color>" +
            "</mark>" +
            untypedSubClauseCopy.Remove(0, 1).ToString()
            );

        return subClauseSnapshot.ToString();
    }

    private char getNextChar()
    {
        return untypedSubClause[0];
    }

    override
    public string ToString()
    {
        return untypedSubClause.ToString();
    }
}
