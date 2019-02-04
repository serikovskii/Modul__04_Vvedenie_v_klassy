using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Program
    {
        public static void Main()
        {
            int sizeCars = 3;
            Auto[] cars = new Auto[sizeCars];
            for (int i = 0; i < sizeCars; i++)
            {
                cars[i] = new Auto("Camry 70", 2.4, 14);
                switch (i)
                {
                    case 0: cars[i].Year = 2017; cars[i].IsFromBrand = "USA"; cars[i].Color = "Black"; break;
                    case 1: cars[i].Year = 2018; cars[i].IsFromBrand = "Japan"; cars[i].Color = "Red"; break;
                    case 2: cars[i].Year = 2019; cars[i].IsFromBrand = "UAE"; cars[i].Color = "White"; break;

                }
            }
            cars[0].TripByAuto(1900);
            cars[1].TripByAuto(1200);
            cars[2].TripByAuto(900);
            cars[0].TripByAuto(500);
            Auto carPrado = new Auto("Prado 150", 2018, "Japan", 2.7, 50000, "Black", 18);
            carPrado.TripByAuto(2064);


            Console.WriteLine("Марка авто: {0} \nГод выпуска: {1} \nСтрана производитель: {2} \nОбъем: {3} \nЦена: {4} \nЦвет: {5} \nРасход бензина на 100 км: {6}л \nПробег {7}км",
                              carPrado.Brand, carPrado.Year, carPrado.IsFromBrand, carPrado.Engine, carPrado.Price, carPrado.Color, carPrado.GetGasMileage(), Math.Round(carPrado.GetMileage(), 1));
            Console.WriteLine("Количество созданных машин: " + carPrado.GetCountAuto());
            Console.ReadLine();
        }
    }
}
