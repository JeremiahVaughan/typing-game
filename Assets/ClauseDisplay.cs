using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text;
using System.Text.RegularExpressions;

public class ClauseDisplay : MonoBehaviour {

    public TextMeshProUGUI textMeshPro;
    private RectTransform rectTransform;


    public void setClause(string clause)
    {
        this.textMeshPro.text = clause;
    }

    public void highlightLetter(int typeIndex)
    {
        ;
 
        string text = this.textMeshPro.text;

        text = removeAllTags(text);
        text = applyAllTags(text, typeIndex);

        this.textMeshPro.text = text;
        

    }

    public void removeClause()
    {
        Destroy(gameObject);
    }

    private string applyAllTags(string theString, int typeIndex)
    {
        string startColorTag = "<#FF8000>";
        string endColorTag = "</color>";
        string startMarkTag = "<mark=#ffff00aa>";
        string endMarkTag = "</mark>";

        string augmentedText = startMarkTag + startColorTag + 
            theString.Substring(0, typeIndex + 1) + 
            endColorTag + endMarkTag;
        string regularText = theString.Substring(typeIndex + 1, theString.Length - (typeIndex + 1));

        return augmentedText + regularText;
    }


    private string removeAllTags(string theString)
    { 
        theString = removeTag(theString, "[<][#]......[>]");
        theString = removeTag(theString, "[<][/].....[>]");
        theString = removeTag(theString, "[<]mark[=][#]........[>]");
        theString = removeTag(theString, "[<][/]mark[>]");

        return theString;
    }

    private string removeTag(string theString, string tagPattern)
    {
        Match match = Regex.Match(theString, tagPattern);

        if (match.Success)
        {
            theString = Regex.Replace(theString, tagPattern, "");
        }
        return theString;
    }
}
