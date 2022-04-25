using System;
using System.Reflection;
namespace Programming.Programming.Домашние__2_семестр.Homework_25_04_2022;

class Programm
{
    static void Main(string[] args)
    {
        var PowerStation = new PowerStationClass(50);
        var FireStation = new Firefighters();
        var MES = new MinistryEmergencySituations();
        
        PowerStation.Accident += FireStation.GoOnAccident;
        PowerStation.Accident += MES.GoOnAccident;
        
        PowerStation.Start();
    }
}