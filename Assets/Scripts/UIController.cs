using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _clueText;

    [SerializeField]
    private string[] _clueContent;
    private int _clueIndex = 0;


    public void DisplayNextClue()
    {
        _clueIndex++;
    }

    public void DisplayText(bool display)
    {
        if(display)
        {
            _clueText.text = _clueContent[_clueIndex];
        }
        else
        {
            _clueText.text = string.Empty;
        }
    }
}
