using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private bool _leverStatus = false;
    [SerializeField]
    private Animator _animator;

    private void Start()
    {
        _animator.SetBool("LeverOn", _leverStatus);
    }

    public void CycleLever()
    {
        _leverStatus = !_leverStatus;
        _animator.SetBool("LeverOn", _leverStatus);
    }
}
