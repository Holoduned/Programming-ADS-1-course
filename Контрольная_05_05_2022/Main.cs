using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Programming.ControlWork;

class Programm
{
    static void Main(string[] args)
    {
        var dogs = new List<Dog>
        {
            new Dog {Id = 1, Name = "Рекс", OwnerId = 1, Age = 5},
            new Dog {Id = 2, Name = "Мухтар",OwnerId = 1, Age = 5},
            new Dog {Id = 3, Name = "Руди", OwnerId = 2, Age = 8},
            new Dog {Id = 4, Name = "Тори", OwnerId = 3, Age = 2},
            new Dog {Id = 5, Name = "Фокс", OwnerId = 4, Age = 9},
            new Dog {Id = 6, Name = "Грей", OwnerId = 5, Age = 1},
            new Dog {Id = 7, Name = "Тоша", OwnerId = 5, Age = 3},
            new Dog {Id = 8, Name = "Ричи", OwnerId = 1, Age = 4},
            new Dog {Id = 9, Name = "Альма", OwnerId = 3, Age = 6},
            new Dog {Id = 10, Name = "Альт", OwnerId = 2, Age = 4},
        };
        
        var owners = new List<Owner>
        {
            new Owner {Id = 1, Name = "Андрей", Birthday = "20/09/1998"},
            new Owner {Id = 2, Name = "Маша", Birthday = "21/04/1998"},
            new Owner {Id = 3, Name = "Лола", Birthday = "10/03/1998"},
            new Owner {Id = 4, Name = "Коля", Birthday = "16/09/1998"},
            new Owner {Id = 5, Name = "Миша", Birthday = "20/12/1998"},
        };
        
        Tasks.Task1(dogs, owners);
        // задача на события
        //var fire = new ForestFire(18);
        //var firefighters = new Firefighters();
        // var MES = new MinistryEmergencySituations();
        //
        // fire.Accident += firefighters.GoOnAccident;
        // fire.Accident += MES.GoOnAccident;
        //
        // fire.Heating();

        //задача на деревья
        // var Tree = new BinarySearchTree<int>();
        // string[] consoleRead = "7 5 12 4 6 11 16 13 3 5".Split(" ");
        //
        // foreach (var i in consoleRead)
        // {
        //     Tree.Add(int.Parse(i));
        // }
        //Tree.NodeHeight(3);
        //Console.WriteLine(Tree.NumOfLeaves());
        //Tree.RainbowPrint();

        //рефлексияя
        /*Type EventType = typeof(ForestFire);
        var reflectionMethod = EventType.GetMethod("ReflectionEventMethod");
        
        reflectionMethod.Invoke(fire, parameters: null);
        
        var privateFields = EventType.GetField("critical_temperature",  BindingFlags.Instance | BindingFlags.NonPublic);
        Console.WriteLine(privateFields.GetValue(fire));
        
        var Property = EventType.GetProperty("ReflectionProperty");
        Console.WriteLine(Property.GetValue(fire));
        Property.SetValue(fire, 5);
        Console.WriteLine(Property.GetValue(fire));*/

    }
}


public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OwnerId { get; set; }
    public int Age { get; set; }
}
    
public class Owner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Birthday { get; set; }
}

public class Tasks
{
    public static void Task1(List<Dog> dogs, List<Owner> owners)
    {
        var list = dogs.Select(dog => $"{dog.Name} {owners.Find(owner => owner.Id == dog.OwnerId).Name}").ToArray();
        foreach (var el in list)
            Console.WriteLine(el);
    }

    public static void Task2(List<Dog> dogs, List<Owner> owners)
    {
        var list = owners.Select(owner =>
            $"{owner.Name} {dogs.GroupBy(dog => owners.Find(owner => owner.Id == dog.OwnerId)).Count()}");
        foreach (var el in list)
            Console.WriteLine(el);

    }
}