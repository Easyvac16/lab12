using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

    public class Garage : IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            Garage garage = new Garage();
            garage.AddCar(new Car("Honda", "Civic", 2020));
            garage.AddCar(new Car("Toyota", "Corolla", 2019));
            garage.AddCar(new Car("Ford", "Mustang", 2022));

            foreach (Car car in garage)
            {
                Console.WriteLine($"{car.Make} {car.Model} ({car.Year})");
            }
        }
    }
}
