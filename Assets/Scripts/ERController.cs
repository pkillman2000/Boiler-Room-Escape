using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERController : MonoBehaviour
{
    [SerializeField]
    private GameObject _pictures;
    private bool _picturesActive;
    private bool _clueZeroComplete;

    [SerializeField]
    private GameObject _pictureSockets;
    private bool _pictureSocketsActive;
    private int _pictureSocketsActivated;
    
    [SerializeField]
    private GameObject _hiddenDoorWall;
    [SerializeField]
    private GameObject _exitDoorObjects;
    [SerializeField]
    private GameObject _chainsLocks;
    [SerializeField]
    private GameObject _doorSwitch;
    [SerializeField]
    private Rigidbody _cabinetRigidbody;
    private int _lockSocketActivated;

    [SerializeField]
    private Animator _exitDoorAnimator;

    [SerializeField]
    private UIController _uiController;


    // Start is called before the first frame update
    void Start()
    {
        _pictures.SetActive(false);
        _picturesActive = false;
        _pictureSocketsActivated = 0;

        _pictureSockets.SetActive(false);
        _pictureSocketsActive = false;

        _exitDoorObjects.SetActive(false);
        _chainsLocks.SetActive(false);
        _doorSwitch.SetActive(false);
        _lockSocketActivated = 0;

        _hiddenDoorWall.SetActive(true);
    }

    // Clue 0 - Flip both levers - Display pictures and picture sockets
    public void Cycle_Display_Pictures()
    {
        if (!_clueZeroComplete) 
        {
            _picturesActive = !_picturesActive;
            _pictures.SetActive(_picturesActive);
            CheckClueZero();
        }
    }

    public void Cycle_Display_Picture_Sockets()
    {
        if (!_clueZeroComplete)
        {
            _pictureSocketsActive = !_pictureSocketsActive;
            _pictureSockets.SetActive(_pictureSocketsActive);
            CheckClueZero();
        }
    }

    private void CheckClueZero()
    {
        if(_picturesActive && _pictureSocketsActive) 
        { 
            _uiController.DisplayNextClue();
            _clueZeroComplete = true;
        }
    }

    // Clue 1 - Picture sockets filled - Display door and keys
    public void ActivatePictureSocket()
    {
        _pictureSocketsActivated++;

        if(_pictureSocketsActivated == 3)
        {
            _pictures.SetActive(false);
            _pictureSockets.SetActive(false);
            _hiddenDoorWall.SetActive(false);
            _exitDoorObjects.SetActive(true);
            _chainsLocks.SetActive(true);
            _cabinetRigidbody.isKinematic = false;
            _uiController.DisplayNextClue();
        }
    }

    // Clue 2 - Use keys to unlock chains - Switch is hi-lited.
    public void ActivateKeySocket()
    {
        _lockSocketActivated++;
        if(_lockSocketActivated == 2) 
        {
            _chainsLocks.SetActive(false);
            _doorSwitch.SetActive(true);
            _uiController.DisplayNextClue();
        }
    }

    // Clue 3 - Flip green lightswitch to exit
    public void OpenDoors()
    {
        _exitDoorAnimator.SetTrigger("OpenDoor");
    }
}
