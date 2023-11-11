// Создать класс Термостат, который бы актирвировал событие TemperatureThrisholdExceeded каждый раз когда термостат выходит
// за определённые ему рамки (24).
// Написать отдельный метод в другом классе ("AirCondition"), который активировал бы систему охлаждения при возникновении данного
// события


internal class Program
{
    private static void Main(string[] args)
    {
        AirCondition a1 = new AirCondition();
        Thermostat t = new Thermostat(24, 22);
        t.ThermostatThrisholdExceeded += a1.TurnOn;

        t.Temperature += 5;
        t.Temperature -= 5;
        t.Temperature += 5;
    }
}

internal class AirCondition
{
    public void TurnOn()
    {
        Console.WriteLine("The AC is on!!!");
    }
}

internal class Thermostat
{
    public delegate void TemperatureThrisholdExceededHandler();
    public event TemperatureThrisholdExceededHandler ThermostatThrisholdExceeded;

    private int _threshold;
    private double _temperature;

    public int Threshold { get { return _threshold; } set { _threshold = value; } }

    public double Temperature 
    { 
        get 
        { 
            return _temperature; 
        } 
        set 
        {
            if(value > Threshold) 
            {
                ThermostatThrisholdExceeded?.Invoke();
            }

            _temperature = value;
        }
    }

    public Thermostat(int threshold, double temperature)
    {
        Threshold = threshold;
        Temperature = temperature;
    }


}
