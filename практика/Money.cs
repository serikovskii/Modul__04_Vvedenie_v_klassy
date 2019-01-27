using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses
{
    public class Money
    {
        private int _nominal;
        private int _count;
        private int _sumMoney;

        public Money()
        {

        }

        public Money(int nominal, int count)
        {
            _nominal = nominal;
            _count = count;

        }

        public int GetNominal()
        {
            return _nominal;
        }

        public void SetNominal(int nominal)
        {
            _nominal = nominal;
        }

        public int GetCoutn()
        {
            return _count;
        }

        public void SetCount(int count)
        {
            _count = count;
        }

        public int GetSumMoney()
        {
            _sumMoney = _nominal * _count;
            return _sumMoney;
        }



        public bool HowMoneyProduct(int price)
        {

            if (GetSumMoney() >= price)
            {
                return true;
            }
            return false;
        }

        public int HowMoneyProducts(int price)
        {
            return GetSumMoney() / price;

        }
    }
}
