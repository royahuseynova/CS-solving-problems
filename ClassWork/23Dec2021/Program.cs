using System;

namespace _23Dec2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telefon secin: ");
            Product[] phonesArray = new Product[Convert.ToInt32(Console.ReadLine())];

          
            for (int i = 0; i < phonesArray.Length; i++)
            {
                Product phonesInstance = new Product();
                phonesArray[i] = phonesInstance;

                
                
                phonesInstance.Id = Id;

                
                

               
            }

            

            foreach (var phone in phonesArray)
            {
                Console.WriteLine(phonesArray.GetPhone());

            }
        }
    }
}

