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
        this.textMeshPro.text = clause;
        untypedSubClause = new UntypedSubClause(clause);
        typedSubClause = new TypedSubClause("");
    }

    public void highlightNextLetter()
    {
        typedSubClause.push(untypedSubClause.pop());
        
        this.textMeshPro.text = typedSubClause.toStringWithTypedTextIndicators() + 
            untypedSubClause.ToString();  
    }

    public void markCurrentCharRed()
    {
        this.textMeshPro.text = typedSubClause.toStringWithTypedTextIndicators() + 
            untypedSubClause.toStringWithFirstCharRed();
    }


    public void removeClause()
    {
        Destroy(gameObject);
    }
}
