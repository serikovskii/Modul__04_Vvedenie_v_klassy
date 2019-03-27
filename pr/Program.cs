using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Создать класс Money, разработав следующие элементы класса:
Поля:
- Номинал купюры
- Количество купюр
Конструктор:
- Позволяющий создать экземпляр класса с заданными значениям полей
Методы:
- Вывести номинал и количество купюр
- Определить, хватит ли денежных средств на покупку товара на сумму N тенге
	- Определить, сколько штук товара стоимости n тенге можно купить на имеющиеся денежные средства
Свойства:
	- Позволяющее получить-установить значение полей (доступное для чтения и записи)
	- Позволяющее расчитать сумму денег (доступное только для чтения)
 
*/


namespace ClassWorkClasses
{
     class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.SetNominal(500);
            money.SetCount(5);
            Console.Write("Баланс: ");
            Console.WriteLine(money.GetSumMoney());

            int price = 1000;
            Console.Write("Цена товара: ");
            Console.WriteLine(price);
            Console.Write("Кол-во товаров: ");
            if (money.HowMoneyProduct(price))
            {
                Console.WriteLine(money.HowMoneyProducts(price));
            }

            Console.ReadLine();
        }
    }

}

