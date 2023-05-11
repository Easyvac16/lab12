using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Apartment
    {
        public string Resident1 { get; set; }
        public string Resident2 { get; set; }

        public Apartment(string resident1 = "", string resident2 = "")
        {
            Resident1 = resident1;
            Resident2 = resident2;
        }

        public override string ToString()
        {
            if (Resident2 != "")
            {
                return Resident1 + " and " + Resident2;
            }
            else if (Resident1 != "")
            {
                return Resident1;
            }
            else
            {
                return "Vacant";
            }
        }
    }

    
    class House : IEnumerable
    {
        private List<Apartment> apartments = new List<Apartment>();

        // Додавання нової квартири
        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        // Повернення ітератора для класу House
        public IEnumerator<Apartment> GetEnumerator()
        {
            return apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            House house = new House();
            house.AddApartment(new Apartment("Oleg", "Denis"));
            house.AddApartment(new Apartment("Bob"));
            house.AddApartment(new Apartment("Andriy", "Vadim"));
            house.AddApartment(new Apartment());



            // Виводимо інформацію про будинок та його квартири
            Console.WriteLine("House Information:");
            foreach (Apartment apartment in house)
            {
                Console.WriteLine("- " + apartment);
            }
            Console.WriteLine();

        }
    }
}
