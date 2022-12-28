namespace Asynchronous_programming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Thread thread1 = new Thread(Write0);

            //Thread thread2 = new Thread(Write1);

            //thread1.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine(2);
            //}
            //thread2.Start();

            //Task task = Task.Run(() =>
            //{
            //    Console.WriteLine("Hello P327");
            //});
            //Console.ReadLine();

            //Boiling();
            //Cooking();
            //Cleaning();
            //Task task = Task.WhenAll(Boiling(), Cleaning(), Cooking());

            //task.ContinueWith(t =>
            //{
            //    Console.WriteLine("Start eating");
            //});
            ////Console.WriteLine("Test");

            //Console.Read();

            //HttpClient client = new HttpClient();
            //string source =await client.GetStringAsync("https://www.google.com");
            //Console.WriteLine("Test");
            //Console.WriteLine(source.Length);
            await Boiling();
            await Cleaning();
            await Cooking();
        }


        public async static Task<bool> Boiling()
        {
            bool task = await Task.Run(() =>
            {
                Console.WriteLine("Start boiling");
                Thread.Sleep(10000);
                Console.WriteLine("Boiling finished");
                return true;
            });
            bool tea = await Task.Run(() =>
            {
                Console.WriteLine("Tea start");
                Thread.Sleep(3000);
                Console.WriteLine("Tea finished");
                return true;
            });
            return tea;
        }

        public async static Task Cooking()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Start cooking");
                Thread.Sleep(5000);
                Console.WriteLine("Cooking finished");
            });
        }

        public async static Task Cleaning()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Start cleaning");
                Thread.Sleep(2000);
                Console.WriteLine("Cleaning finished");
            });
        }

        public static void Write0()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }
        public static void Write1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
    }
}