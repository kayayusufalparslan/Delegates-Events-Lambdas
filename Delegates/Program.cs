    internal class Program
    {
        public delegate float MyDelegate(float price);

        static float zone1(float price)
        {
            return price * 25 / 100;
        }
        static float zone2(float price)
        {
            return (price * 12 / 100) + 25;
        }
        static float zone3(float price)
        {
            return price * 8 / 100;
        }
        static float zone4(float price)
        {
            return (price * 4 / 100) + 25;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the zone: ");  
                string customerZone = Console.ReadLine();
                if(customerZone == "exit")
                {
                    break;
                }
                Console.WriteLine("Enter the product price: ");
                float itemPrice = float.Parse(Console.ReadLine());

                MyDelegate fee = zone1;  

                if (customerZone == "zone1")    
                {
                    Console.WriteLine("Total shipping fee is " + fee(itemPrice) + "$");
                }
                else if (customerZone == "zone2")
                {
                    fee = zone2;
                    Console.WriteLine("Total shipping fee is " + fee(itemPrice) + "$");
                }
                else if (customerZone == "zone3")
                {
                    fee = zone3;
                    Console.WriteLine("Total shipping fee is " + fee(itemPrice) + "$");
                }
                else if (customerZone == "zone4")
                {
                    fee = zone4;
                    Console.WriteLine("Total shipping fee is " + fee(itemPrice) + "$");
                }
                else
                {
                    Console.WriteLine("You wrote something wrong! \nTry Again..");
                }
            }

        }
    }
