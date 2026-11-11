class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceInMeters = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceInMeters} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage > 0
        ? $"Battery at {_batteryPercentage}%"
        : "Battery empty"; 
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceInMeters += 20;
            _batteryPercentage -= 1;
        }
    }
}
