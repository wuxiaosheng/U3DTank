using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCtrl
{
    // Start is called before the first frame update
    GameObject _tank;
    GameCtrl _ctrl;
    public void start(GameCtrl ctrl)
    {
        _ctrl = ctrl;
        _tank = GameObject.Find("Tank");
    }

    // Update is called once per frame
    public void update()
    {
        
    }

    public Vector3 getTankPos() {
        return _tank.transform.position;
    }
}