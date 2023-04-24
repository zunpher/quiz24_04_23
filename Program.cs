using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter amount of item(s): ");
        int amount = int.Parse(Console.ReadLine());

        string[] itemsName = new string[amount];
        string[] tItem = new string[amount];

        for (int i = 0; i<amount; i++) {
            Console.Write("Enter item name: ");
            itemsName[i] = Console.ReadLine();

            Console.Write("Enter type of item: ");
            tItem[i] = Console.ReadLine();

            Console.WriteLine();
        }

        Console.Write("Enter search mode: ");
        string mode = Console.ReadLine();

        switch (mode) {
            case "ShowAll" :
            for (int i = 0; i<amount; i++) {
                Console.WriteLine("{0}", itemsName[i]);
                Console.WriteLine("{0}", tItem[i]);
                Console.WriteLine();
            }
            break;

            case "Weapon" :
            break;

            default :
            Console.WriteLine("End");
            break;
        }
    }
}