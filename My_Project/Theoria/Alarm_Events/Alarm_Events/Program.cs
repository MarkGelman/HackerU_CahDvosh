// Создать класс "Alarm".
// Этот класс должен активировать событие "AlarmRung" при активации сигназлизации.
// Создать отдельный метод в другом классе (предположим "SecurityAgency") , который реагировал бы на звонок сигнализации

internal class Program
{
    private static void Main(string[] args)
    {
        Alarm a1 = new Alarm();
        SecurityAgency s1 = new SecurityAgency();
        a1.AlarmRung += s1.OnAlarmRung;
    }
}

internal class Alarm
{
    public delegate void AlarmEventHandler();
    public event AlarmEventHandler AlarmRung;

    public void TriggerAlarm()
    {
        Console.WriteLine("The Alarm is on!!!");
        AlarmRung?.Invoke();
    }
}

internal class SecurityAgency
{
    public void OnAlarmRung()
    {
        Console.WriteLine("Security agency alerted!");
    }

}