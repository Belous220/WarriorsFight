using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TestApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //помечаю вещи которые долго не мог допереть
            Random rand = new Random();
            int sword, bow, spear;

            float health1 = rand.Next(80, 140); //Так как здоровье у нас может быть значнием с точкой - float!!!
            int armor1 = rand.Next(30, 60);
            

            string[] WarriorsNames = { "Pasha", "Arina", "Elena", "Helga",
                                "Vanya", "Dasha","Mark", "Ulius","Varus"};
            
            int nIndex1 = rand.Next(WarriorsNames.Length);
            int nIndex2 = rand.Next(WarriorsNames.Length);


            float health2 = rand.Next(75, 180);
            int armor2 = rand.Next(30, 60);
            int damage2 = rand.Next(1, 10);
            int damage1 = rand.Next(1, 10);

            Console.WriteLine($"Выберите оружие для бойца {WarriorsNames[nIndex1]}, это может быть лук - 1,копье - 2 или меч - 3 ");
            Console.Write("Введите номер выбранного оружия:");
            int userweapon = Convert.ToInt32(Console.ReadLine());

            if (userweapon == 1)
            {
                damage1 = 12;
            }
            else if (userweapon == 2)
            {
                damage1 = 8;
            }
            else if (userweapon == 3)
            {
                damage1 = 10;
            }
            else if (userweapon >3 || userweapon <=0)
            {
                Console.WriteLine("Такого оружия нет");
                return;
            }
            
            /* switch (weapons)
            {
                case "Копье" :
                    Console.WriteLine("Вы выбрали копье");
                    userdamage = 15;
                    break;
                case "Меч":                                          Пытался сделать выборку оружия через УО Свитч,но не смог понять как вывести из него полученные значения     
                    Console.WriteLine("Вы выбрали меч");
                    break;
                case "Лук":
                    Console.WriteLine("Вы выбрали лук");
                    break;
            }
            */
            
            
            Console.WriteLine($"\n\nY бойца {WarriorsNames[nIndex1]} - {health1} здоровья\n\n{damage1} - урона\n\n{armor1} - защиты\n\n");
            Console.WriteLine($"\n\nУ бойца {WarriorsNames[nIndex2]} - {health2} здоровья\n\n{damage2} - урона\n\n{armor2} - защиты\n\n");
            while(health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1; //Конвертируем значения в сингл
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor1;

                Console.WriteLine($"\n\nЗдоровье бойца {WarriorsNames[nIndex1]} - {health1}\n\nЗдоровье бойца {nIndex2} - {health2}");
                Console.ReadKey();
                if (health1 <= 0 && health2 <=0)
                {
                    Console.WriteLine("Ничья. Оба мертвы");
                    break;
                }
                else if (health1 <= 0 )
                {
                    Console.WriteLine($"\n\nВоин {WarriorsNames[nIndex1]} пал");
                }
                else if (health2 <= 0)
                {
                    Console.WriteLine($"\n\nВоин {WarriorsNames[nIndex2]} пал");
                }
            }
        }   

    }
} 

