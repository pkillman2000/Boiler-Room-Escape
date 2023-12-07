using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERController : MonoBehaviour
{
    [SerializeField]
    private GameObject _pictures;
    private bool _picturesActive;
    
    [SerializeField]
    private GameObject _pictureSockets;
    private bool _pictureSocketsActive;
    private int _socketsActivated;
    
    [SerializeField]
    private GameObject _hiddenDoorWall;
    [SerializeField]
    private GameObject _exitDoorObjects;
    [SerializeField]
    private GameObject _doorSwitch;

    // Start is called before the first frame update
    void Start()
    {
        _pictures.SetActive(false);
        _picturesActive = false;
        _socketsActivated = 0;

        _pictureSockets.SetActive(false);
        _pictureSocketsActive = false;

        _exitDoorObjects.SetActive(false);
        _doorSwitch.SetActive(false);

        _hiddenDoorWall.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cycle_Display_Pictures()
    {
        _picturesActive = !_picturesActive;
        _pictures.SetActive(_picturesActive );
    }

    public void Cycle_Display_Picture_Sockets()
    {
        _pictureSocketsActive= !_pictureSocketsActive;
        _pictureSockets.SetActive(_pictureSocketsActive);
    }

    public void ActivateSocket()
    {
        _socketsActivated++;

        if(_socketsActivated == 3)
        {
            _pictures.SetActive(false);
            _pictureSockets.SetActive(false);
            _hiddenDoorWall.SetActive(false);
            _exitDoorObjects.SetActive(true);
        }
    }
}
