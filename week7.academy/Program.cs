using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace week7.academy
{
    public class Program
    {
        public static async Task Main()
        {
            //Task[] t = new Task[2];
            //string[] files = null;
            //string[] dir = null;
            ////string[] dee = null;

            //string docdirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //t[0] = Task.Factory.StartNew(() => files= Directory.GetFiles(docdirectory));
            //t[1] = Task.Factory.StartNew(() => dir= Directory.GetDirectories(docdirectory));
            ////t[2] = Task.Factory.StartNew(() =>  Directory.Delete(docdirectory));

            //Task.Factory.ContinueWhenAll(t, completedfile =>
            //{
            //    Console.WriteLine("{0}:- Contains", docdirectory);
            //    Console.WriteLine("{0}:- files", files.LongLength);
            //    Console.WriteLine("{0}:- subdirectories", dir.Length);
            //    //Console.WriteLine("{0}:- Delete", t[2]);
            //});

            //Console.Read();

            //Console.WriteLine();

            //Console.Write("Enter path: ");

            //string sam = Console.ReadLine();
            //if (sam == null)
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //else
            //{
            //    if (Directory.Exists(sam))
            //    {

            //        Directory.Delete(sam);
            //        Console.WriteLine("Folder deleted.");
            //    }            
            //     else 

            //     {
            //            Console.WriteLine("Not found");
            //     }
            //}


            //Console.WriteLine("calulation started");           
            // await Calculate();



            //Task.Run(() => Console.WriteLine(multiply()));
            //Task.Run(() => Console.WriteLine(Add()));
            //Console.ReadKey();



            Console.WriteLine("Calculation Started");
            await calculate();



        }


        //public static async Task Calculate()
        //{

        //    await Task.Run(() =>
        //             calculate1()
        //    );
        //     await Task.Run(() =>
        //           calculate2()
        //    );

        //    await Task.Run(() =>
        //           calculate3()
        //     );

        //    Console.Read();

        //}


        //public static async Task<int> calculate1()
        //{
        //    Thread.Sleep(3000);
        //    Console.WriteLine("calculation 1 in progress");
        //    return 500;

        //}


        //public static async Task<int> calculate2()
        //{

        //    Console.WriteLine("calculation 2 in progress");
        //    return 2100;
        //}

        //public static async Task<int> calculate3()
        //{

        //    Console.WriteLine("calculation 3 in progress");
        //    return 100;
        //}

        public static int multiply()
        {
            Thread.Sleep(2000);
            return 5 * 8;
        }
        public static int Add()
        {
            return 5 + 8;              
        }

        static async Task calculate()
        {

            var a = await Task.Run(() =>
             Multiplication()
              );

            var b = await Task.Run(() =>
             Addition()
             );
            Console.Write($" Multiplication: {a} Addition: {b}");
            Console.ReadKey();

        }


        static async Task<int> Multiplication()
        {

           Thread.Sleep(2000);
            return 5 * 8;
        }


        static async Task<int> Addition()
        {
            return 5 + 8;

        }

    }
}
