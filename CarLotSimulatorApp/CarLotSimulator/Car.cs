namespace CarLotSimulator;

public class Car
{
    private int year;
    private string make;
    private string model;
    private string enginenoise;
    private string honknoise;
    private bool isdriveable;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Make
    {
        get {return make;}
        set {make = value;}
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
}

    public string EngineNoise
    {
        get { return enginenoise; }
        set { enginenoise = value; }
    }

    public string HonkNoise
    {
        get { return honknoise; }
        set { honknoise = value; }
    }

    public bool IsDriveable
    {
        get { return isdriveable; }
        set { isdriveable = value; }
    }

    public void MakeEngineNoise(string noise)
    {
        enginenoise = noise;
    }

    public void MakeHonkNoise(string noise)
    {
        honknoise = noise;
    }
}