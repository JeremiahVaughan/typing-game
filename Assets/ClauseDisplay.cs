using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text;

public class ClauseDisplay : MonoBehaviour {

    public TextMeshProUGUI textMeshPro;
    private RectTransform rectTransform;


    public void setClause(string clause)
    {
        this.textMeshPro.text = clause;
    }

    public void highlightLetter(int typeIndex)
    {
        string text = this.textMeshPro.text;
        string highlightedText = "<#FF8000>" + text.Substring(0, typeIndex) + "</color>";
        string regularText = text.Substring(typeIndex, text.Length - typeIndex);
        this.textMeshPro.text = highlightedText + regularText;
    }

    public void removeClause()
    {
        Destroy(gameObject);
    }
}
