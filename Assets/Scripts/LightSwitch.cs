using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]
    private bool _switchStatus = false;
    [SerializeField]
    private Animator _animator;

    private void Start()
    {
        _animator.SetBool("SwitchOn", _switchStatus);
    }

    public void CycleSwitch()
    {
        _switchStatus = !_switchStatus;
        _animator.SetBool("SwitchOn", _switchStatus);
    }
}
