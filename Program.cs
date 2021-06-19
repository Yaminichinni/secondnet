using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace AsncAww1
{
    class Program
    {




        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                string a = Method2();
                Console.WriteLine(a);



            });
        }




        public static string Method2()
        {
            Console.WriteLine("wait for string to return");
            Thread.Sleep(5000);
            return "this is method 2";
        }
        static void Main(string[] args)
        {
            Method1();

            Console.ReadKey();
        }



    }
}