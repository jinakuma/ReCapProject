using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest();
        }
        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.ColorName + " " + car.BrandName + " " + car.CarName);
            }
        }
    }
}
