using Xunit.Sdk;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        
        _speed = speed;           
        _batteryDrain = batteryDrain;
 }



    public bool BatteryDrained()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
    }

    public int DistanceDriven()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
    }

    public void Drive()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }

    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
