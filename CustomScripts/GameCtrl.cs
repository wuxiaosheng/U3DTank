using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public CameraCtrl _camera;
    public TankCtrl _tank;
    void Start()
    {
        _tank = new TankCtrl();
        _tank.start(this);
        _camera = new CameraCtrl();
        _camera.start(this);
    }

    // Update is called once per frame
    void Update()
    {
        _tank.update();
        _camera.update();
    }
}
