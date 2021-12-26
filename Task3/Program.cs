using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* turbo.az

saytina daxil olub orada bir Car modelinin tesvirini arashdirin
Sonra 4 xususiyyeti olacaq sekilde bir Car classı yaradın
-marka
-model
-year
-price
son dersdeki kimi istifadeciden say saorushulsun ve o qeder sayda mashini massive elave etmek(butun gostericilerini) */


            Console.Write("Nece eded masin axtarirsiniz? Masin sayi: ");
            CarClass[] cars = new CarClass[Convert.ToInt32(Console.ReadLine())];


            for (int i = 0; i < cars.Length; i++)
            {
                CarClass carsInstance = new CarClass();
                cars[i] = carsInstance;

                Console.Write("Masin markasi daxil et: ");
                carsInstance.brand = Console.ReadLine();

                Console.Write("Masin modeli daxil et: ");
                carsInstance.model = Console.ReadLine();

                Console.Write("Istehsal tarixi daxil et: ");
                carsInstance.productionDate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masin rengi daxil et: ");
                carsInstance.color = Console.ReadLine();
                
                Console.Write("Qiymet daxil et: ");
                carsInstance.price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Axtardiginiz {i + 1}ci masin budur: {carsInstance.GetCar()}");
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Yuxarida axtardiginiz masin siyahisi bunlardir: ");

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetCar());

            }

            Console.WriteLine("----------------------------------------------------");


        }
    }
}
