using System;
namespace MobilePhoneShop
{
    class Programs
    {
        static void Main(string[] args)
        {
            int choose;
            string[] mainMenu = { "Import and Export Management", "Mobile Phone Information", "Customer", "Exit" };
            do
            {
                choose = Menu("\t\tMobile Phone Shop", mainMenu);
                switch (choose)
                {
                    case 1:
                    Console.WriteLine("1");
                    break;
                    case 2:
                    Console.WriteLine("2");
                    break;
                    case 3:
                    Console.WriteLine("3");
                    break;
                    case 4:
                    Console.WriteLine("4");
                    break;
                    
                }
                
            } while (choose != 4 );
            
        }
        static int Menu(string title, string[] menuItems)
        {
            int choose = 0;
            string line = "=================================================";
            Console.WriteLine(line);
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(line);
            Console.WriteLine();
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {menuItems[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(line);
            Console.Write("#Your choice: ");
            int.TryParse(Console.ReadLine(), out choose);
            while (choose < 1 || choose > menuItems.Length)
            {
                Console.WriteLine("Error! Re-enter: ");
                int.TryParse(Console.ReadLine(), out choose);
            }
            return choose;
        }
        static void EnterToContinue(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadLine();
        }

    }
}