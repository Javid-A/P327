namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Worst syntax
            //Item item1 = new Item(90);
            //Item item2 = new Item(80);
            //Item item3 = new Item(100);

            //Item item4 = new Item("Awesome");
            //Item item5 = new Item("Medium");
            //Item item6 = new Item('A');
            //Item item7 = new Item('E');
            //Console.WriteLine(item1.Quality);
            //Console.WriteLine(item4.quality);
            //Console.WriteLine(item5.quality);
            //Console.WriteLine(item6._quality);
            //Console.WriteLine(item7._quality); 
            #endregion

            //Item<char> item1 = new Item<char>('A');
            //Item<string> item2 = new Item<string>("Awesome");
            //Item<int> item3 = new Item<int>(100);
            //Item<double> item4 = new Item<double>(99.95);
            //Item<Category> item5 = new Item<Category>(new Category());

            //IntList list = new IntList();
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);

            //foreach (int number in list.GetDatas())
            //{
            //    Console.WriteLine(number);
            //}

            //StringList stringList = new StringList();

            //stringList.Add("Samra");
            //stringList.Add("Asiman");
            //stringList.Add("Lutfu");

            //foreach (string item in stringList.GetDatas())
            //{
            //    Console.WriteLine(item);
            //}

            Computer lenovo = new Computer("Lenovo", "16GB", "1TB");
            Computer asus = new Computer("ASUS", "16GB", "512GB");
            Computer acer = new Computer("Acer", "16GB", "2TB");

            //ComputerList computerList = new ComputerList();
            //computerList.Add(lenovo);
            //computerList.Add(asus);
            //computerList.Add(acer);

            //foreach (Computer item in computerList.GetDatas())
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<int> intList = new CustomList<int>();
            //intList.Add(1);
            //intList.Add(2);
            //intList.Add(3);

            //foreach (var item in intList.GetDatas())
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<string> stringList = new CustomList<string>();
            //stringList.Add("Mahammad");
            //stringList.Add("Toghrul");
            //stringList.Add("Hamid");

            //foreach (var item in stringList.GetDatas())
            //{
            //    Console.WriteLine(item);
            //}


            //CustomList<Computer> computerList = new CustomList<Computer>();
            //computerList.Add(lenovo);
            //computerList.Add(asus);
            //computerList.Add(acer);

            //foreach (var item in computerList.GetDatas())
            //{
            //    Console.WriteLine(item);
            //}

            //Computer[] arr = { asus, lenovo, acer };
            //SuperMarket<Computer,int> basket = new SuperMarket<Computer,int>(arr);


            //basket.Total = 7000;
            //foreach (var item in basket.basket)
            //{
            //    Console.WriteLine(item);
            //}

            //SuperMarket<Computer, double> basket2 = new SuperMarket<Computer, double>(arr);

            //basket2.Total = 7000.23;

            //Item<Employee> item5 = new Item<Employee>(new Employee());
            Item<Computer> item5 = new Item<Computer>(acer);
            //Item<Electronics> item6 = new Item<Electronics>(new Electronics());
            //Item<string> item4 = new Item<string>("a");
            //Item<int> item1 = new Item<int>(1);
            //Item<double> item2 = new Item<double>(1.1);
            //Item<byte> item3 = new Item<byte>(250);
            //Item<char> item4 = new Item<char>('a');

            Phone phone = new Phone();
            phone.Resolution = 5;

            Box<Phone> box = new Box<Phone>(phone);

            box.Safety();
        }
    }
}