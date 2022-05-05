namespace Programming.Programming.Домашние__2_семестр.Homework_25_04_2022;

public class PowerStationClass
{
    private double current_temperature;
    private double critical_temperature = 360;
    private double heatingSpeed = 60;
    
    //public delegate void MethodContainer();
    public event EventHandler<OnEmergencyEventArgs> Accident;
    
    private System.Timers.Timer TickTimer;

    public PowerStationClass(double temperature)
    {
        current_temperature = temperature;
    }
    
    public void Start()
    {
        Console.WriteLine($"Текущая температура: {current_temperature} / {critical_temperature}");
        TickTimer = new System.Timers.Timer(3000);
        
        TickTimer.Elapsed += TimeHeating;
        
        TickTimer.Start();
        Console.ReadLine();
        TickTimer.Stop();
    }
    
    private void TimeHeating(object source, EventArgs e)
    {
        current_temperature += heatingSpeed;
        if (current_temperature >= critical_temperature)
        {
            Accident(this, new OnEmergencyEventArgs());
            current_temperature = 0;
        }
        Console.WriteLine($"Текущая температура: {current_temperature} / {critical_temperature}");
    }
}

public class OnEmergencyEventArgs : EventArgs
{
}

public class Firefighters
{
    public void GoOnAccident(object? sender, OnEmergencyEventArgs onEmergencyEventArgs)
    {
        Console.WriteLine("Пожарная служба выехала на место происшествия!"); 
    }                                                        
}

public class MinistryEmergencySituations
{
    public void GoOnAccident(object? sender, OnEmergencyEventArgs onEmergencyEventArgs)
    {
        Console.WriteLine("МЧС выехала на место происшествия!"); 
    }   
}

