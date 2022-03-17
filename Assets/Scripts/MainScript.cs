using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject rotateButtonView;
    public GameObject laserPropertyView;
    public GameObject laserGunModel;
    
    private void Awake()
    {
        // create presenters for views
        //rotateButtonView.GetComponent<UILaserRotateButtons>().CreatePresenter(laserGunModel.GetComponent<SpaceShip>());
        //laserPropertyView.GetComponent<UILaserPropertyFields>().CreatePresenter(laserGunModel.GetComponent<SpaceShip>());
    }

    private void Start()
    {
        // set start value for example
        //laserGunModel.GetComponent<SpaceShip>().SetLaserRange(50f);
        //laserGunModel.GetComponent<SpaceShip>().SetLaserPower(25f);
        //laserGunModel.GetComponent<SpaceShip>().Rotate(Vector3.zero);
    }
}
