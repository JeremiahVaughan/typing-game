using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text;

public class ClauseDisplay : MonoBehaviour {

    public TextMeshProUGUI text;
    private RectTransform rectTransform;


    public void setClause(string clause)
    {
        this.text.text = clause;
    }

    public void highlightLetter(int typeIndex)
    {
        UIVertex[] uIVertices = text.textInfo.meshInfo.uiVert;
    }

    public void removeClause()
    {
        Destroy(gameObject);
    }
}
