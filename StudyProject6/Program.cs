using System;

namespace My
{
    class first
    {
        private string str;
        public string Srt
        {
            get { return str; }
            set { str = value; }
        }
        public static string str1 = "==================";
        public static string str2 = "++++++++++++++++++";
        public static string str3 = "------------------";
        public static string str4 = "__________________";
        public static string str5 = "******************";

    }
    class second
    {
        delegate void word();
        delegate void word1();
        delegate void word2();
        delegate void word3();
        delegate void word4();
        delegate void word5();
        delegate void text();

        static void Main()
        {
            Console.Title = "Malinin Mikhail 2PKS-120";

            text text;
            text = damn;
            text();
            void damn() => Console.WriteLine("В пространстве имен My создается 2 класса - First и Second." + "\n" + "В классе first" + "\n" + " 1. создается закрытое поле str. Показан прием передачи значения закрытому полю." + "\n" + " 2. создаются 5 функций для их дальнейшей привязки к делегату." + "\n" + "В классе second" + "\n" + " 1. Рассмотрены различные способы добавления методов в делегат." + "\n" + "\n" + "\n");

            word say;
            say = good;
            say();
            void good() => Console.WriteLine("работает say" + "\n" + "Итоговое значение str1 = " + first.str1);


            word say1;
            say1 = good1;
            say1();
            void good1() => Console.WriteLine("работает say1" + "\n" + "Итоговое значение str2 = " + first.str2);

            word say2;
            say2 = good2;
            say2();
            void good2() => Console.WriteLine("работает say2" + "\n" + "Итоговое значение str3 = " + first.str3);

            word say3;
            say3 = good3;
            say3();
            void good3() => Console.WriteLine("работает say3" + "\n" + "Итоговое значение str4 = " + first.str4);

            word say4;
            say4 = good4;
            say4();
            void good4() => Console.WriteLine("работает say4" + "\n" + "Итоговое значение str5 = " + first.str5);

        }

    }
}