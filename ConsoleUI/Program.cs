using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine("Model Year:"+car.ModelYear+"Description : "+car.Description+"Brand Name : "+ brandManager.GetById(car.BrandId).BrandName+"Daily price:"+car.DailyPrice);
            }

            Console.WriteLine("----------------");
            carManager.Add(new Car { DailyPrice = -100 });
            brandManager.Add(new Brand { BrandName = "x" });

        }
    }
}
