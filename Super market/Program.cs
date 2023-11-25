using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Super_market
{
    internal class Program
    {
        public class superMarket
        {
            string user_name = "mahmoud";
            string password = "123321";
            int menu_size = 12;
            string[] products = { " Tomato", " Rise", " Meat", " Water", " Checken", " Pepsi", " Cola", " Cheese", " Ice cream", "Potatos", "Fruits", "Vegetables"};
            int[] prices = { 5, 15, 180, 6, 40, 6, 7, 40, 5, 4, 15, 10 };
            public void Show_Menu()
            {
                Console.WriteLine("-----------------------------------");

                for (int i = 0; i < menu_size; i++)
                {
                    Console.WriteLine($"{i + 1} - {products[i]}   {prices[i]} LE");
                    if (i == 2 || i == 5 || i == 8 || i == 11)
                    {
                        Console.WriteLine("-----------------------------------");
                    }
                }
            }
            public void Buy_product()
            {
                int Choice_option = 0;
                int num_products = 0;
                int[] product_carry = new int[12];
            that:
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine("- Enter the numbers of Products to buy");
                Console.Write("\n----------------\nOption : ");
                try
                {
                    num_products = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n----------------------------------------\n" + e.Message +
                                   "\n----------------------------------------\n"); goto that;
                }
                do
                {
                there:
                    Console.WriteLine("- Choose the procces\n_______________________\n1- Add products to card\n2- Show the Reciept\n3- Return Back \n");
                    Console.Write("\n----------------\nOption : ");
                    try
                    {
                        Choice_option = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n----------------------------------------\n" + e.Message +
                                          "\n----------------------------------------\n");
                    }
                    switch (Choice_option)
                    {
                        case 1:
                            for (int j = 0; j < num_products; j++)
                            {
                                Console.WriteLine("Enter number of product\n------------------------");
                                product_carry[j] = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("\nOrder Done !\n");
                            break;
                        case 2:
                            int total = 0;
                            Console.WriteLine("______________ Your Reciept _____________\n");
                            try
                            {
                                for (int s = 0; s < num_products; s++)
                                {
                                    Console.WriteLine($"{s + 1} {products[product_carry[s] - 1]}  {prices[product_carry[s] - 1]} LE");
                                    Console.WriteLine("------------------------");
                                    total += prices[product_carry[s] - 1];
                                }
                                Console.WriteLine($"\nTotal cost is : {total}\n------------------------\n");
                            }
                            catch { Console.WriteLine("Empty\n_________________________________________\n"); }
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("*Enter only 1 , 2 or 3 !\n");
                            goto there;
                            break;
                    }
                }
                while (Choice_option != 3);
            }
            public void User_page()
            {
                int User_option = 0;
                Console.WriteLine("------------------------\nPlease enter your Name");
                string user_name = Console.ReadLine();
                Console.WriteLine($"\n______________ Welcome {user_name} !! ______________\n");
                do
                {
                here:
                    Console.WriteLine("\n- Choose the number :\n-------------------" +
                        "\n1- Show the nenu\n2- Buy a product\n3- Return the Main Page");
                    Console.Write("\n----------------\nOption : ");
                    try
                    {
                        User_option = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n----------------------------------------\n" + e.Message +
                                        "\n----------------------------------------\n");
                    }
                    switch (User_option)
                    {
                        case 1:
                           Show_Menu();
                            break;
                        case 2:
                          Buy_product();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("*Enter only 1 , 2 or 3 !\n");
                            goto here;
                            break;
                    }
                } while (User_option != 3);
            }
            public void Create()
            {
                int identity = 0;
                Console.WriteLine("-------------------------------------\nEnter Your Name : ");
                string newManeger_name = Console.ReadLine();
                Console.WriteLine("Enter Your Password : ");
                string newManeger_pass = Console.ReadLine();
                Console.WriteLine("\nI am not Robot [] press\nnumber from 1 to 4 to Check");
                identity = int.Parse(Console.ReadLine());
            
                switch (identity)
                {
                    case 1 :
                        Console.WriteLine("smaewl34");
                        break;
                    case 2:
                        Console.WriteLine("fdsga7sg");
                        break;
                    case 3:
                        Console.WriteLine("qmaewl34");
                        break;
                    case 4:
                        Console.WriteLine("lj9ryt6d");
                        break;
                }
                Console.WriteLine("Please Enter the Code");
                string code = Console.ReadLine();
                if (code == "smaewl34" || code == "fdsga7sg" || code == "qmaewl34" || code == "lj9ryt6d")
                {
                    Console.WriteLine("-----------------------------\nNow Login to Enter");
                    Console.WriteLine("-----------------------------\nReEnter Your Name : ");
                    string Rename = Console.ReadLine();
                    Console.WriteLine("-------------------\nReEnter Your Password : ");
                    string Repass = Console.ReadLine();
                    if (newManeger_name == Rename && newManeger_pass == Repass)
                    {
                        Maneger_Control(newManeger_name);
                    }
                    else
                    { Console.WriteLine("\nWrong input Please Enter valid data "); Create(); }
                }
                else
                {
                    Console.WriteLine("Please try again");
                    
                }
            }
            public void Login()
            {
                Console.WriteLine("Enter Your User Name");
                string name_try = Console.ReadLine();
                Console.WriteLine("Enter Your Password");
                string pass_try = Console.ReadLine();
                if (name_try == user_name && pass_try == password)
                {

                    Maneger_Control(user_name);
                }
                else
                    Console.WriteLine("\n-------------------\nWrong Data Please Enter Again\n-------------------\n");
            }
            public void Add()
            {
                string[] product2=new string[30];
                int[] price2= new int[30];
                product2[0] = "Tomato"; product2[1] = "Rise"; product2[2] = "Meat"; product2[3] = "Water"; product2[4] = "Checken";
                product2[5] = "Pepse"; product2[6] = "Cola"; product2[7] = "Cheese"; product2[8] = "Ice cream"; product2[9] = "Potatos";
                product2[10] = "Fruits"; product2[11] = "Vegetables";
                price2[0] = 5; price2[1] = 15; price2[2] = 180; price2[3] = 6; price2[4] = 40; price2[5] = 6; price2[6] = 6; price2[7] = 40;
                price2[8] = 5; price2[9] = 4; price2[10] = 15; price2[11] = 10;
                  string ch = "";
                  Console.WriteLine("The Menu is Now 12 Element\nEnter the new size ");
                  menu_size = int.Parse(Console.ReadLine());
                if (menu_size > 12)
                {
                    for (int k = 0; k < menu_size - 12; k++)
                    {
                        Console.WriteLine("Enter the Product Name :");
                        product2[k + 12] = Console.ReadLine();
                        Console.WriteLine("Enter the Product price :");
                        price2[k + 12] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Do you want to show the New Menu ? (y or n)");
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("-----------------------------------");

                        for (int i = 0; i < menu_size; i++)
                        {
                            Console.WriteLine($"{i + 1} - {product2[i]}   {price2[i]} LE");
                            if (i == 2 || i == 5 || i == 8 || i == 11||i==14||i==18)
                            {
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                    }
                    else if (ch == "n")
                    {
                        Maneger_Control("");
                    }
                }
                else if (menu_size < 12&& menu_size>0)
                {
                    Console.WriteLine("Done");
                    Console.WriteLine("Do you want to show the New Menu ? (y or n)");
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("-----------------------------------");

                        for (int i = 0; i < menu_size; i++)
                        {
                            Console.WriteLine($"{i + 1} - {product2[i]}   {price2[i]} LE");
                            if (i == 2 || i == 5 || i == 8 || i == 11 || i == 14 || i == 18)
                            {
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                    }
                    else if (ch == "n")
                    {
                        Maneger_Control("");
                    }
                }
            }
            public void Edit()
            {
                int product_num, choice_edit=0;
                string new_name;
                Console.WriteLine("Enter the numbers of Products to Edit\n-------------------------------------");
                int num_product=int.Parse(Console.ReadLine());
                for (int x = 0; x < num_product; x++)
                {
                    Console.WriteLine("Enter the Number of Product\n---------------------------");
                    product_num= int.Parse(Console.ReadLine());
                    these:
                    Console.WriteLine("\nDo you want to edit Name or Price\n--------------------------------- \n1- Name\n2- Price\n3- Both of them");
                    Console.Write("\n----------------\nOption : ");
                    try
                    {
                        choice_edit = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n----------------------------------------\n" + e.Message +
                                       "\n----------------------------------------\n"); goto these;
                    }
                    switch(choice_edit)
                    {
                        case 1:
                            Console.WriteLine("\nEnter the new name : ");
                            new_name = Console.ReadLine();
                            products[product_num - 1] = new_name;
                            break;
                            case 2:
                            Console.WriteLine("Enter the new price : ");
                            int new_price = int.Parse(Console.ReadLine());
                            prices[product_num - 1] = new_price;
                            break;
                        case 3:
                            Console.WriteLine("\nEnter the new name : ");
                             new_name = Console.ReadLine();
                            products[product_num - 1] = new_name;
                            Console.WriteLine("Enter the new price : ");
                            new_price = int.Parse(Console.ReadLine());
                            prices[product_num - 1] = new_price;
                            break;
                    }
                }
                Console.WriteLine("\nDo you want to Show the New Menu ? (y or n)");
                string check = Console.ReadLine();
                if (check == "y")
                {
                    Show_Menu();
                }
                else if (check == "n") { Maneger_Control(""); }
                else 
                    Console.WriteLine("Enter only y or n ");
            }
            public void Maneger_Control(string name)
            {
                int option_control = 0;
                Console.WriteLine($"\n_____________________ Welcome {name} _____________________\n");
                do
                {
                    choose:
                    Console.WriteLine("\n------------------\nChoose the Procces :\n--------------------\n" +
                                    "1- Add Element to Menu\n2- Edit an Element in the Menu\n3- Retun Back");
                    Console.Write("\n----------------\nOption : ");
                    try
                    {
                        option_control = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\n----------------------------------------\n" + e.Message +
                                          "\n----------------------------------------\n");
                    }
                    switch (option_control)
                    {
                        case 1:
                            Add();
                            break;
                        case 2:
                            Edit();
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("*Enter only 1 , 2 or 3 !\n");
                            goto choose;
                            break;
                    }
                } while (option_control!=3);
            }
            public void Maneger_page()
            {
                int Maneger_option = 0;
                do
                { 
                    Console.WriteLine("\n- Choose the number :\n-------------------" +
                     "\n1- Create A new Email\n2- Login\n3- Return the Main Page");
                    Console.Write("\n----------------\nOption : ");
                    Maneger_option = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------\n");
                    switch (Maneger_option)
                    {
                        case 1:
                           Create();
                            break;
                        case 2:
                          Login();
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                while (Maneger_option != 3);    
            }
        }
        static void Main(string[] args)
        {
            int option=0;
            Console.WriteLine("\t\t\t\t================== SuperMarket System ==================");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------" +
                              "-------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\t\t\t\t____________________ Enter to open ___________________\n");
            Console.ReadLine();
            Console.Clear();
            do
            { 
                Console.WriteLine("- Choose the Mood from the Following: \n\n1- User\n2- Manager\n3- Exit the program");
                Console.Write("\n----------------\nOption : ");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------\n");
                }
                catch(Exception e) { Console.WriteLine("\n----------------------------------------\n"+e.Message+
                    "\n----------------------------------------\n"); }
                switch (option)
                {
                    case 1:
                        superMarket obj1 = new superMarket();
                        obj1.User_page();
                        break;
                    case 2:
                        superMarket  obj2=new superMarket();
                        obj2.Maneger_page();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("*Enter only 1 ,2  or 3 !\n");
                        break;
                }
            } while (option != 3);
        }
    }
}
