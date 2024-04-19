using System;


class Math
{
    public static Func<int, int, int> Sum;

    static void Main2()
    {
        Math.Sum = (int x, int y) => x + y;
    }
}
class Program
{

    delegate void Message();
    delegate void Message2();
    delegate void Message3();
    delegate void Message4();
    delegate void Message5();
    delegate void Message6();
    delegate void Message7();
    delegate void Message8();
    delegate void Message9();
    delegate void Message10();
    delegate int Operation(int x, int y);
    delegate int Operation2(int x, int y);
    delegate void Operation3(int x, int y, int z);
    static void Main()
    {
        Console.Title = "Malinin Mikhail 2PKS-120";

        Message mes;
        mes = Hello;
        mes();

        void Hello() => Console.WriteLine("1. Создание делегата и добавление в него методов, в зависимости от времени суток: ");



        if (DateTime.Now.TimeOfDay > new TimeSpan(6, 00, 00) && DateTime.Now.TimeOfDay < new TimeSpan(11, 59, 59))
        {
            Message mes2;
            mes2 = Hello2;
            mes2();
            void Hello2() => Console.WriteLine("Morning");
        }
        if (DateTime.Now.TimeOfDay > new TimeSpan(12, 00, 00) && DateTime.Now.TimeOfDay < new TimeSpan(17, 59, 59))
        {
            Message mes3;
            mes3 = Hello3;
            mes3();
            void Hello3() => Console.WriteLine("Lunch");
        }
        if (DateTime.Now.TimeOfDay > new TimeSpan(18, 00, 00) && DateTime.Now.TimeOfDay < new TimeSpan(23, 59, 59))
        {
            Message mes4;
            mes4 = Hello4;
            mes4();
            void Hello4() => Console.WriteLine("Evening");
        }
        if (DateTime.Now.TimeOfDay > new TimeSpan(00, 00, 00) && DateTime.Now.TimeOfDay < new TimeSpan(5, 59, 59))
        {
            Message mes5;
            mes5 = Hello5;
            mes5();
            void Hello5() => Console.WriteLine("Night");
        }
        Message3 slov;
        slov = Two;
        slov();
        Message4 slov2;
        slov2 = Two2;
        slov2();

        void Two() => Console.WriteLine("\n " + "  2. Переопределение делегата: ");
        void Two2() => Console.WriteLine("\n" + "   делегат указывает на метод Add");
        Message5 plus = Hello6;
        plus();
        Operation op = Add;
        int result = op(4, 5);
        Console.WriteLine(" Результат: " + result);
        void Hello6() => Console.WriteLine("  Operation del = Add;" + "\n" + "int result = del(4,5);" + "\n" + "Console.WriteLine(Результат: + result + /n)");
        int Add(int x, int y) => x + y;
        Message6 slov3;
        slov3 = Two3;
        slov3();

        void Two3() => Console.WriteLine("\n" + "   теперь делегат указывает на метод Multiply");
        Message7 plus2 = Hello7;
        plus2();
        Operation op2 = Multiply;
        int result2 = op2(4, 5);
        Console.WriteLine("         Результат: " + result2);
        int Multiply(int x, int y) => x * y;
        void Hello7() => Console.WriteLine("  del = Multiply;" + "\n" + "result = del(4,5);" + "\n" + "Console.WriteLine(Результат: + result + )");
        Message8 slov4;
        slov4 = Two4;
        slov4();
        Message9 slov5;
        slov5 = Two5;
        slov5();
        void Two4() => Console.WriteLine("\n" + "   3. Присваивание делегату метода из другого класса");
        void Two5() => Console.WriteLine("\n" + "   делегату присваивается метод Sum из класса Math ");
        Message10 plus3 = Hello8;
        plus3();
        Math math = new Math();
        Math.Sum = (int x, int y) => x + y; ;
        int result3 = Math.Sum(10, 100);
        Console.WriteLine("\n" + " Результат: " + result3);
        void Hello8() => Console.WriteLine("  Math math = new Math();" + "\n" + "OperationForClass delSum = math.Sum;" + "\n" + "int resultSum = delSum(10,100);" + "\n" + "Console.WriteLine(Результат:  + resultSum );");

    }
}

