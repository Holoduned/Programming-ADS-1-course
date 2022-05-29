using System;
using System.Reflection;
using System.Runtime.CompilerServices;

/*namespace Programming.ControlWork;

class Programm
{
    static void Main(string[] args)
    {
        // задача на события
        var fire = new ForestFire(18);
        var firefighters = new Firefighters();
        // var MES = new MinistryEmergencySituations();
        //
        // fire.Accident += firefighters.GoOnAccident;
        // fire.Accident += MES.GoOnAccident;
        //
        // fire.Heating();
        
        //задача на деревья
        var Tree = new BinarySearchTree<int>();
        string[] consoleRead = "7 5 12 4 6 11 16 13 3 5".Split(" ");
        
        foreach (var i in consoleRead)
        {
            Tree.Add(int.Parse(i));
        }
        //Tree.NodeHeight(3);
        //Console.WriteLine(Tree.NumOfLeaves());
        Tree.RainbowPrint();
        
        //рефлексияя
        /*Type EventType = typeof(ForestFire);
        var reflectionMethod = EventType.GetMethod("ReflectionEventMethod");
        
        reflectionMethod.Invoke(fire, parameters: null);
        
        var privateFields = EventType.GetField("critical_temperature",  BindingFlags.Instance | BindingFlags.NonPublic);
        Console.WriteLine(privateFields.GetValue(fire));
        
        var Property = EventType.GetProperty("ReflectionProperty");
        Console.WriteLine(Property.GetValue(fire));
        Property.SetValue(fire, 5);
        Console.WriteLine(Property.GetValue(fire));#1#

    }
}*/