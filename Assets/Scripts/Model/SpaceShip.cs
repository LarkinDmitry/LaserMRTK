using System;
using UnityEngine;

class SpaceShip : MonoBehaviour
{
    public GameObject LaserGun;

    private Laser myLaser;

    public event Action<bool> changedLaserState;

    private void Start()
    {
        myLaser = LaserGun.GetComponent<Laser>();

        myLaser.SetActiv(true);
        myLaser.SetLaserRange(10);
        myLaser.SetLaserPower(5);
    }


    public void SetLaserState(bool state)
    {
        myLaser.SetActiv(state);
        changedLaserState?.Invoke(myLaser.GetActivState());
    }
}
