using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TestApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float health1 = rand.Next(80, 140); //Так как здоровье у нас может быть значнием с точкой - float!!!
            int armor1 = rand.Next(30,60);
            int damage1 = rand.Next(5,6);

            float health2 = rand.Next(75, 180);
            int armor2 = rand.Next(30, 60);
            int damage2 = rand.Next(1, 10);

            Console.WriteLine($"\n\nY бойца 1 - {health1} здоровья\n\n{damage1} - урона\n\n{armor1} - защиты\n\n");
            Console.WriteLine($"\n\nУ бойца 2 - {health2} здоровья\n\n{damage2} - урона\n\n{armor2} - защиты\n\n");
            
            
            while(health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1; //Конвертируем значения в сингл
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor1;

                Console.WriteLine($"\n\nЗдоровье бойца 1 - {health1}\n\nЗдоровье бойца 2 - {health2}");
                Console.ReadKey();
                if (health1 <= 0 && health2 <=0)
                {
                    Console.WriteLine("Ничья. Оба мертвы");
                    break;
                }
                else if (health1 <= 0 )
                {
                    Console.WriteLine($"\n\nВоин 1 пал");
                }
                else if (health2 <= 0)
                {
                    Console.WriteLine($"\n\nВоин 2 пал");
                }
            }
        }   

    }
} 

