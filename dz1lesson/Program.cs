﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domasha
{
    class Program_dz1
    {

        /*
         * если просит ввести цифру надо ввести цифру , иначе будет краш. буду думать в сторону while
         */
        static void Main(string[] args)
        {
            var x = 0;
            var b = true;
            string first_name = "viktor"; 
            string last_name = "karas";
            do
            {
                Console.Clear();
                Console.WriteLine("Введите номер задачи 1-6, прочие символы не нравятся приложению ");
                x = Convert.ToInt32(Console.ReadLine());     // если программе сообщить пробел, или символ то она даст ошибку, 
                Console.Title = ("Меню");
                switch (x)
                {
                    case 1:
                        dz1();
                        break;
                    case 2:
                        dz2();
                        break;
                    case 3:
                        dz3();
                        break;
                    case 4:
                        dz4();
                        break;
                    case 5:
                        dz5( first_name, last_name);
                        break;
                    case 6:
                        dz6();
                        break;
                    case 7:
                        bonus();
                        break;
                    default:      // понравилась эта констуркция, не совсем понятно но понятно как использовать и редактировать , все дз буду оформлять по этому типу
                        b = !b; // думаю как сделать проверку на X при чем тут не равно b                       
                        Console.Write("пока пока");
                        break;
                }
                Console.ReadKey();
            } while (b);
        }
        #region задание 1
        /// <summary>
        /// 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        /// а) используя склеивание;
        /// б) используя форматированный вывод;
        /// в) используя вывод со знаком $.
        /// </summary>
        static void dz1()
        {
            Console.Title = ("1. Написать программу «Анкета».");
            Console.WriteLine("Привет, чтобы продолжить работу можно я задам тебе несколько вопросов?");
            String answer01 = Console.ReadLine();
            if (answer01 == "da" || answer01 == "lf" || answer01 == "Да" || answer01 == "ок" || answer01 == "ok" || answer01 == "yes" || answer01 == "да")
            {
                Console.WriteLine("Твое имя?, пожалуйста вводи символы по требованиб и цифры аналогично");
                String first_name = Console.ReadLine();
                Console.WriteLine("Привет " + first_name + " Напиши свою фамилию, пожалуйста?");
                String last_name = Console.ReadLine();
                Console.WriteLine(first_name + " " + last_name + ", а какого ты роста в см? // пожалуйста вводи цифры");
                String p_height = Console.ReadLine();
                Console.WriteLine("{0} {1}, а весишь сколько в кг? // пожалуйста вводи цифры", first_name, last_name);
                String p_kg = Console.ReadLine();
                Console.WriteLine($"{first_name} {last_name}, ростом {p_height} и весом {p_kg}, привет.");
            }

            else
            {
                Console.WriteLine("Нам не о чем говорить. Приходи когда будет настроение.");

            }        }
        #endregion
        #region задание 2
        /// <summary>
        /// 2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
        /// </summary>
        static void dz2()
        {
            Console.Title = ("2. Рассчитать и вывести индекс массы тела(ИМТ).");
            double weight, high;
            Console.Write("Введите ваш вес в кг: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост в см: ");
            high = Convert.ToInt32(Console.ReadLine());
            double I = weight / (Math.Pow(high / 100, 2));// weight / (high/100 * high/100);  // (Math.Pow(x / y, 2)) - возводит в степень 2 // Math.Sqrt извлекает квадрат
            Console.WriteLine("I = {0:f4}", I);
        }

        #endregion
        #region задание 3
        /// <summary>
        /// 3.	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
        ///     б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
        /// </summary>
        static void dz3()
        {
            Console.Title = ("3. Написать программу, которая подсчитывает расстояние между точками");
            double x2, y2, x1, y1; // объявляем переменные double значит с запятой можно вводить числа а также отрицательные -
            Console.Write("Введите x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double r = Convert.ToDouble(Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2))));
           // Console.WriteLine("{0:f2}", (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
           Console.WriteLine(r);
            methoddz3(x1, y1, x2, y2, r);
        }

        /// <summary>
        /// Метод который выводи на экран растояние между двумя заданными точками
        /// </summary>

         static void methoddz3(double x1, double y1, double x2, double y2, double r) // насколько я понимаю указывать тип переменных double очень важно. что будет чаще всего использоватся?
        {
            Console.WriteLine("{0:f2}", (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)))); // интиресны альтернативные записи
            Console.WriteLine(r); // спецально обратился к переменной r , и спецально указал её в параметрах метада, чтобы вызвать внутри, просто эксперемент на будущее
        }

        #endregion
        #region задание 4
        /// <summary>
        /// 4.	Написать программу обмена значениями двух переменных
        ///     а) с использованием третьей переменной;
        ///     б) *без использования третьей переменной.
        /// </summary>
        static void dz4()
        {
            Console.Title = ("4.	Написать программу обмена значениями двух переменных");
            double a, b;
            Console.Write("Введите значение а: ");  // не использовал .writeline для строчного вывода двух команд
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            /*вариант "А" с тремя переменными:*/
            double c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Вариант с тремя переменными а: " + a + "  b:" + b);

            //Вариант без третьей переменной
            //Следует обратить внимание на то, что в данном случае значения возвращаются к тем
            //которые были введены изначально 

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("математический трюк  a = a + b;     b = a - b;   a = a - b; ");
            Console.WriteLine("Вариант с двумя переменными а: " + a + "  b:" + b + " видим цифры введенные сначала");
        }

        #endregion
        #region задание 5
        /// <summary>
        //        5.
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организовать в центре экрана.
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        /// </summary>

        static void dz5(string first_name, string last_name)
        {
            Console.Title = ("5.	Об авторе");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("hello" + " " + first_name + " " + last_name);
            Console.WriteLine("Чтобы выполнить задание в) я попрошу тебя ввести координаты x и y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            string ms = "я пока не понял как как сообщить новое значение переменной, позвольте мне остаться викотором корасем из спб?";
            about(ms, x, y) ; // выводин инфу об авторе и собственно задание в)            

                    }

        /// <summary>
        /// вот и задание под В, ну или я не правильно понял, создаю метод about
        /// </summary>
         static void about(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
            //return first_name;
        }
        #endregion
        /// <summary>
        /// 6)  *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
        /// </summary>
        static void dz6()
        {
            Console.WriteLine("Пойду смотреть запись урока, не понимаю что требуется сделать.");
        }
        static void bonus()
        {
            Console.WriteLine("Вот и зачем ты нажал 7? это недостроенный бонусный уровень, как тебя зовут?");
            string u_name = Console.ReadLine();
            Console.WriteLine("пока пока " + u_name + " кликни чтонибудь для возврата в меню и не возвращайся");
        }
    }


}
