using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl
{
    // Start is called before the first frame update
    GameObject _camera;
    GameCtrl _ctrl;
    public void start(GameCtrl ctrl)
    {
        _ctrl = ctrl;
        _camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    public void update()
    {
        
    }
}
