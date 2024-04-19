using System;

namespace EVENT
{
    public delegate void Del();
    class ClassEvent
    {
        public event Del Event;
        public void funEvent() { Event(); }
    }
    class forEvent
    {
        public void fun0() { Console.WriteLine("Происходит СОБЫТИЕ!"); }
        public void fun1() { Console.WriteLine("Лиса поймала петуха"); }
        public void fun2() { Console.WriteLine("И посадила в клетку."); }
        public void fun3() { Console.WriteLine("\"Я откормлю Вас, ха-ха-ха!"); }
        public void fun4() { Console.WriteLine("И съем Вас, как конфетку.\""); }
    }
}


namespace ConsoleApp15
{
    using EVENT;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Malinin Mikhail 2PKS-120";

            Console.Write("Программа демонстрирует вызов различных событий.\n\nПусть в пространстве имён EVENT объявлён один делегат del и два класса:\n\n* класс classEvent, содержащий событие Event и функцию funEvent для генерирования события;\n\n* класс - forEvent с функциями, предназначенными для включения различных событий в период исполнения.\n\nФормально класс forEvent не связан ни с каким-либо делегатом, ни событием.\n\nКоды по шагам:\n\n1. Первоначально создаётся объект ob класса, содержащего событие.\n\n2. Далее к объекту присоединяется ссылка на делегат для статической функции fun0. Теперь функция funEvent уже может вызвать событие(в частности функцию fun0). До присоединения указателя объект ob ссылался на null.\n\n3. Для включения в событие нестатических функций необходимо создать объект соответствующего класса(obb) и присоеденить ссылки к нужному событию.\n\nВ программе организованы два вызова события:\n\n* после присоединения только статической функции и\n* после присоединения всех функций.\n----------------------------------------------\nРЕЗУЛЬТАТ РАБОТЫ:\n\n\n");
            var ob = new ClassEvent();
            var obb = new forEvent();
            ob.Event += obb.fun0;
            ob.Event += obb.fun1;
            ob.Event += obb.fun2;
            ob.Event += obb.fun3;
            ob.Event += obb.fun4;
            ob.funEvent();
        }
    }
}
