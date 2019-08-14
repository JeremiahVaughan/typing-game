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
        string startColorTag = "<#FF8000>";
        string endColorTag = "</color>";
        string text = this.textMeshPro.text;

        //Debug.Log("going in: " + text);

        text = removeColorTags(text, startColorTag, endColorTag);

        //Debug.Log("comming out: " + text);

        string highlightedText = startColorTag + text.Substring(0, typeIndex + 1) + endColorTag;
        //Debug.Log("Highlighted Text: " + text.Substring(0, typeIndex + 1));
        string regularText = text.Substring(typeIndex + 1, text.Length - (typeIndex + 1));
        //Debug.Log("Regular Text: " + regularText);
        this.textMeshPro.text = highlightedText + regularText;
        

    }

    public void removeClause()
    {
        Destroy(gameObject);
    }

    private string removeColorTags(string theString, string startTag, string endTag)
    {
        string escapedStartTag = Regex.Escape(startTag);
        string escapedEndTag = Regex.Escape(endTag);
        //Debug.Log("escaped tag: " + escapedEndTag);
        
        string startTagPattern = "[<][x]......[>]";
        string endTagPattern = "[<][/].....[>]";

        Match matchStart = Regex.Match(theString, startTagPattern);
        Match matchEnd = Regex.Match(theString, endTagPattern);
        Debug.Log("found tag: " + matchStart.Success.ToString());
        if (matchStart.Success && matchEnd.Success)
        {
            theString.Remove(theString.IndexOf(escapedStartTag), startTag.Length);
            theString.Remove(theString.IndexOf(escapedEndTag), endTag.Length);
            //Debug.Log(theString.IndexOf(startTag));
            //Debug.Log(theString.IndexOf(endTag));
        }
        return theString;
    }
}
