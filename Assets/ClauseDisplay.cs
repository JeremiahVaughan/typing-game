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
    private TypedSubClause typedSubClause;
    private UntypedSubClause untypedSubClause;


    public void setClause(string clause)
    {
        this.textMeshPro.text = applyTextPolish(clause);
        untypedSubClause = new UntypedSubClause(clause);
        typedSubClause = new TypedSubClause("");
    }

    public void highlightNextLetter()
    {
        typedSubClause.push(untypedSubClause.pop());
        
        this.textMeshPro.text = applyTextPolish(typedSubClause.toStringWithTypedTextIndicators() + 
            untypedSubClause.ToString());  
    }

    public void markCurrentCharRed()
    {
        this.textMeshPro.text = applyTextPolish(typedSubClause.toStringWithTypedTextIndicators() + 
            untypedSubClause.toStringWithFirstCharRed());
    }

    private string applyTextPolish(string text) {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("<b><font=\"LiberationSans SDF\">" + text + "</font><b>");
        return stringBuilder.ToString();
    }


    public void removeClause()
    {
        Destroy(gameObject);
    }
}
