namespace Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting & Downcasting
            //int[] arr = { 1, 2, 3, 4 };
            //int[] arr2 = (int[])arr.Clone();
            //int number = 3000;
            //byte num = (byte)number;

            //Console.WriteLine(num);

            //Samoyed samoyed = new Samoyed();
            //LionFish fish = new LionFish();

            //Dog samoyed = new Samoyed();

            //Animal animal = new Samoyed();

            //Console.WriteLine(samoyed.GetType());
            //Console.WriteLine(animal.GetType());

            //Animal animal = new LionFish();
            //Animal animal = new Samoyed();

            //LionFish fish = animal as LionFish;//==> null

            //if(fish != null)
            //{
            //    fish.Poison = "Deadly";
            //    Console.WriteLine(fish.Poison);
            //}


            //Console.WriteLine(fish == null);

            //if (animal is LionFish castFish)
            //{
            //    //(LionFish)animal
            //    LionFish fish = castFish;
            //    fish.Poison = "Deadly";
            //    Console.WriteLine(fish.Poison);
            //}
            //Dog pitbull = new Pitbull();
            //Dog samoyed = new Samoyed();
            //Dog husky = new Husky();
            //Dog chihuahua = new Chihuahua();
            //Dog golden = new Golden();
            //Treatment(pitbull);
            //Treatment(samoyed);
            //Treatment(husky);
            //Treatment(chihuahua);
            //Treatment(golden);

            //Dog[] dogs = { pitbull, samoyed, husky }; 
            #endregion

            //Dollar dollar = new Dollar { USD =300};
            //Manat manat = dollar;
            //Console.WriteLine(manat.AZN);
            //Manat manat1 = new Manat { AZN = 400 };

            //Dollar dollar1 = (Dollar)manat1;
            //Console.WriteLine(dollar1.USD);

            Person person1 = new Person(40);
            Person person2 = new Person(40);

            Console.WriteLine(person1==person2);
            Console.WriteLine(person1==person2);
        }
        #region Upcasting & Downcasting
        //static void Treatment(Pitbull pitbull)
        //{
        //    Console.WriteLine($"Some process for {pitbull.GetType().Name}");
        //    pitbull.Bark();
        //}
        //static void Treatment(Husky husky)
        //{
        //    Console.WriteLine($"Some process for {husky.GetType().Name}");
        //    husky.Bark();
        //}
        static void Treatment(Samoyed samoyed)
        {
            Console.WriteLine($"Some process for {samoyed.GetType().Name}");
            samoyed.Bark();
        }

        static void Treatment(Dog dog)
        {
            Console.WriteLine($"Some process for {dog.GetType().Name}");
            //if (dog is Samoyed casted)
            //{
            //    Samoyed samoyed = casted;
            //    samoyed.Fur = "Samoyed's fur is gone";
            //    Console.WriteLine(samoyed.Fur);
            //}else if (dog is Husky castedHusky)
            //{
            //    Husky husky = castedHusky;
            //    husky.Fur = "Husky's fur is gone";
            //    Console.WriteLine(husky.Fur);
            //}
            //else if (dog is Chihuahua castedChihuahua)
            //{
            //    Chihuahua chihuahua = castedChihuahua;
            //    chihuahua.Fur = "Chihuahua's fur is gone";
            //    Console.WriteLine(chihuahua.Fur);
            //}
            if (dog is IShavable shavable)
            {
                shavable.Shave();

            }
            dog.Bark();
        }
        #endregion
    }

    //class Dollar
    //{
    //    public double USD;
    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        Dollar dollar = new Dollar { USD = manat.AZN / 2 };
    //        return dollar;
    //    }
    //}

    //class Manat
    //{
    //    public double AZN;
    //    public static implicit operator Manat(Dollar dollar)
    //    {
    //        return new Manat { AZN = dollar.USD * 2 };
    //    }
    //}

    class Person
    {
        public byte Age;

        public Person(byte age)
        {
            Age = age;
        }
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
        public static bool operator >=(Person p1, Person p2)
        {
            return p1.Age >= p2.Age;
        }
        public static bool operator <=(Person p1, Person p2)
        {
            return p1.Age <= p2.Age;
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }

    }
}