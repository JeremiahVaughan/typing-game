using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[System.Serializable]
public class TypedSubClause
{
    private StringBuilder typedSubClause;

    public TypedSubClause(string subClause)
    {
        typedSubClause = new StringBuilder(subClause);
    }

    public void push(char currentChar)
    {
        typedSubClause.Append(currentChar);
    }

    public string toStringWithTypedTextIndicators()
    {
        string highlightColor = "#F6FA0F";
        string textColor = "#000000";

        StringBuilder subClauseSnapShot = new StringBuilder("");

        subClauseSnapShot.Append("<mark=" + highlightColor + ">" + "<" + textColor + ">" +
            typedSubClause.ToString() +
            "</mark></color>");

        return subClauseSnapShot.ToString();
    }

}
