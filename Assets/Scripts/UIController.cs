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

    // Start is called before the first frame update
    void Start()
    {
        _clueText.text = _clueContent[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
