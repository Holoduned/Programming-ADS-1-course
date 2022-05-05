namespace Programming.ControlWork;

public class OnAccidentEventArgs : EventArgs
{
}

public class ForestFire
{
    private double current_temperature;
    private double critical_temperature = 40; //температура, при которой начинаются лесные пожары
    private double heatingSpeed = 3; //температура потепления
    
    public int ReflectionProperty { get; set; }
    
    public event EventHandler<OnAccidentEventArgs> Accident;
    
    public ForestFire(double temperature)
    {
        current_temperature = temperature;
    }
    
    public void Heating()
    {
        while (current_temperature < critical_temperature)
        {
            current_temperature += heatingSpeed;
            Console.WriteLine($"Текущая температура: {current_temperature} / {critical_temperature}");
            
            if (current_temperature >= critical_temperature)
            {
                Accident(this, new OnAccidentEventArgs());
            }
        }
    }

    public static void ReflectionEventMethod()
    {
        Console.WriteLine(":')");
    }
}

public class Firefighters
{
    public void GoOnAccident(object? obj, OnAccidentEventArgs onAccidentEventArgs)
    {
        Console.WriteLine("Пожарная служба выехала на место пожара!"); 
    }                                                        
}

public class MinistryEmergencySituations
{
    public void GoOnAccident(object? obj, OnAccidentEventArgs onAccidentEventArgs)
    {
        Console.WriteLine("Служба МЧС эвакуирует ближайшие населенные пункты!"); 
    }   
}