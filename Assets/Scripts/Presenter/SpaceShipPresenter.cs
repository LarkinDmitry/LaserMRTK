class SpaceShipPresenter
{
    private ILaserProperty view;
    private SpaceShip model;

    public SpaceShipPresenter(ILaserProperty view, SpaceShip model)
    {
        this.view = view;
        this.model = model;
    }

    // pass command to model
    public void SetLaserPower(bool state)
    {
        model.SetLaserState(state);
    }
}
