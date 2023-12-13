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

    // Start is called before the first frame update
    void Start()
    {
        _clueText.text = _clueContent[_clueIndex];
    }

    public void DisplayNextClue()
    {
        _clueIndex++;
        _clueText.text = _clueContent[_clueIndex];
    }
}
