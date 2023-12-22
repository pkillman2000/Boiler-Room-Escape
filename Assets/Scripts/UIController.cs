using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * This script displays the various clues
 * on the clue board
*/

public class UIController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _clueText;

    [SerializeField]
    private string[] _clueContent;
    private int _clueIndex = 0;

    // Advances index to next clue
    public void DisplayNextClue()
    {
        _clueIndex++;
    }

    // Is used by the Gaze Interactor to display/hide the clues
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
