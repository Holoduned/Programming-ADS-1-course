using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Контрольная_15_12_2021
{
    abstract public class Technic
    {
        public string Name, Manufacturer, EnergoConsuption;
        public int Power;

        public Technic(string name, string manufacturer, string consuption, int power)
        {
            Name = name; Manufacturer = manufacturer; EnergoConsuption = consuption; Power = power;
        }

        public override int GetHashCode()
        {
            return Power * 31;
        }

        public override string ToString()
        {
            return $"{Name}, {EnergoConsuption}";
        }

        public override bool Equals(object obj)
        {
            var compare = obj as Technic;
            if (compare.Power == Power)
            {
                return true;
            }
            return false;
        }
    }

    public class KitchenTechnic : Technic
    {
        public string Embedded;
        public KitchenTechnic(string name, string manufacturer, string consuption, int power, string embed)
            :base(name, manufacturer, consuption, power)
        {
            Embedded = embed;
        }

        public void Installation()
        {
            if (Embedded == "Встраиваемая")
            {
                Console.WriteLine($"Кухонная техника {Name} производителя {Manufacturer} была встроена в нынешнюю кухню заказчика");
            }
            else { Console.WriteLine($"Кухонная техника {Name} производителя {Manufacturer} была установлена"); }
        }
    }

    public static class TechnicExtensions
    {
        public static int Renovation(this Technic technic)
        {
            return new Random().Next(20000);
        }
    }

    public class Queue : ICloneable
    {
        public KitchenTechnic[] technics = { };

        public void Add(KitchenTechnic technic)
        {
            KitchenTechnic[] array = new KitchenTechnic[technics.Length + 1];
            technics.CopyTo(array, 0);
            array[array.Length - 1] = technic;
            technics = array;
        }

        public KitchenTechnic Read()
        {
            var technic = technics[0];
            var technicslist = technics.ToList();
            technicslist.RemoveAt(0);
            technics = technicslist.ToArray();
            return technic;
        }

        public void QueuePrint()
        {
            for (int i = 0; i < technics.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {technics[i].Name}");
            }
        }

       
        public Queue(KitchenTechnic[] technics)
        {
            this.technics = technics;
        }

        public Queue()
        {
        }

        public object Clone()
        {
            return new Queue(technics = this.technics);
        }
    }

}