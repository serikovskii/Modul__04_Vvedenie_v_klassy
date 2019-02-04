using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    public class Auto
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string IsFromBrand { get; set; }
        public double Engine { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        private static int _countAuto;
        private double _mileage;
        private double _gasMileage;
        public static int _numFormula;
        static Auto()
        {
            _numFormula = 100;
            _countAuto = 0;
        }

        public Auto(string brand, double engine, double gasMileage)
        {
            Brand = brand;
            Engine = engine;
            _gasMileage = gasMileage;
            _mileage = 0;
            _countAuto++;
        }

        public Auto(string brand, int year, string isFromBrand, double engine, int price, string color, double gasMileage)
        {
            Brand = brand;
            Year = year;
            IsFromBrand = isFromBrand;
            Engine = engine;
            Price = price;
            Color = color;
            _mileage = 0;
            _gasMileage = gasMileage;
            _countAuto++;
        }

        public int GetCountAuto()
        {
            return _countAuto;
        }

        public double GetMileage()
        {
            return _mileage;
        }
        private void SetMileage(double mileage)
        {
            _mileage += mileage;
        }

        public double GetGasMileage()
        {
            return _gasMileage;
        }



        public void TripByAuto(int gasoline)
        {
            SetMileage((gasoline / GetGasMileage()) * _numFormula);
        }
    }
}
