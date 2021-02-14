using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;//BackgroundColor-свойство,фон; свойство должно чему нибудь равно;
            Console.ForegroundColor = ConsoleColor.Cyan;//цвет текста
            Console.Clear();//Clear-очистка (и закрашивает весь фон)
            Random rnd = new Random();//конструктор-это метод,функция; rnd-название переменной
            Console.WriteLine("jah-Resit uravnenie");
            string soov = Console.ReadLine();//soov-переменная, input(python), (то что будет веденно с клавитуры)
            int numa = 0;//num-переменная
            int numb = 0;
            int numz = 0;
            int numx = 0;
            Console.WriteLine("(b+z)*(a-b)/x");
            if (soov == "jah")
            {
                Console.Write("a=");
                numa = Convert.ToInt32(Console.ReadLine());//Convert.ToInt32- всё что будеть веденно с клавиатуры, будет превращена в цифры

                Console.Write("b=");
                numb = Convert.ToInt32(Console.ReadLine());

                Console.Write("z=");
                numz = Convert.ToInt32(Console.ReadLine());

                Console.Write("x=");
                numx = Convert.ToInt32(Console.ReadLine());
            }
            int summa = numb + numz;
            //Console.WriteLine(summa);
            int nesumma = numa - numb;
            //Console.WriteLine(nesumma);
            int sum = summa * nesumma;
            //Console.WriteLine(sum);
            int otvet = sum / numx;
            Console.WriteLine("c={0}", otvet.ToString());

            //Console.WriteLine(otvet);//Console.WriteLine-выводит информацию на экран; nimetus-переменная
            StreamWriter filesse = new StreamWriter(@"..\..\Zadaca.txt", true);//filesse-переменная;..\..\-выйдет из двух папок; true-будет добавлять (новые файлы);если по русски - то надо писать (encoding-8-utf)
            filesse.WriteLine("Otvet: c= {0}", otvet.ToString());//место {0} поставит в num, место {1} поставит в nimetus
            filesse.Close();//закрывает файл
            //int num = rnd.Next(1, 8);//num-название переменной; Next-свойство

            string fio = "";
            int gruppa = 0;
            int nomer = 0;
            int vozrast = 0;
            string pol = "";
            int nomer_lab = 0;
            string nazvanie = "";
            Console.WriteLine("Anketa");
            Console.WriteLine("FIO");
            fio = Console.ReadLine();
            Console.Write("Gruppa-");
            gruppa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nomer Varianta-");
            nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vozrast-");
            vozrast = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vas pol-");
            pol = Console.ReadLine();
            Console.Write("Nomer laborotornoi rabote");
            nomer_lab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nazvanie laborotornoi rabote-");
            nazvanie = Console.ReadLine();


            
            //Console.WriteLine(nimetus);//Console.WriteLine-выводит информацию на экран; nimetus-переменная
            StreamWriter filesse1 = new StreamWriter(@"..\..\Dannie.txt", true);//filesse-переменная;..\..\-выйдет из двух папок; true-будет добавлять (новые файлы);если по русски - то надо писать (encoding-8-utf)
            filesse1.WriteLine("FIO-{0}, Gruppa {1}, Nomer {2}, Vozrast {3}, pol {4}, nomer lab{5}, nazvanie {6}", fio, gruppa.ToString(), nomer.ToString(), vozrast.ToString(), pol, nomer_lab.ToString(), nazvanie);//место {0} поставит в num, место {1} поставит в nimetus
            filesse1.Close();//закрывает файл
            //int num = rnd.Next(1, 8);//num-название переменной; Next-свойство 
        }
    }
}
