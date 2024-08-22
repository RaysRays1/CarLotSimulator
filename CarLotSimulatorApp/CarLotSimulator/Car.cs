namespace CarLotSimulator;

public class Car
{
    private int year;
    private string make;
    private string model;
    private string enginenoise;
    private string honknoise;
    private bool isdriveable;

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }
    public void MakeEngineNoise(string noise)
    {
        enginenoise = noise;
    }

    public void MakeHonkNoise(string noise)
    {
        honknoise = noise;
    }
}