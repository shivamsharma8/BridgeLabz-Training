using System;

namespace CodeReview
{
    public class PhoneRecord
    {
        static void Main(string[] args)
        {
            const int max = 100;
            string[] names = new string[max];
            string[] numbers = new string[max];
            string[] gender = new string[max];
            string[] cities = new string[max];
            int count = 0;
            int choice;

            do
            {


                Console.WriteLine("Menu:");
                Console.WriteLine("1 Add Record");
                Console.WriteLine("2 Update Record");
                Console.WriteLine("3 Delete Record");
                Console.WriteLine("4 Search Record");
                Console.WriteLine("5 Display All Records");
                Console.WriteLine("6 Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name, Number Gender, City Respectively");
                        names[count] = Console.ReadLine();
                        numbers[count] = Console.ReadLine();
                        gender[count] = Console.ReadLine();
                        cities[count] = Console.ReadLine();

                        Console.WriteLine("Record Added Successfully");
                        count++;
                        break;

                    case 2:
                        Console.WriteLine("enter the Number to update info");
                        string number = Console.ReadLine();
                        int getIndexUpdate = -1;
                        for (int i = 0; i < count; i++)
                        {
                            if (number == numbers[i]) { getIndexUpdate = i; break; }
                        }
                        if (getIndexUpdate == -1)
                        {
                            Console.WriteLine("Number not found");
                            break;
                        }
                        Console.WriteLine("What you want to update. 1-name, 2-number, 3-gender, 4-city");
                        int updateChoice = int.Parse(Console.ReadLine());

                        switch (updateChoice)
                        {

                            case 1:
                                Console.WriteLine("enter name");
                                names[getIndexUpdate] = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("enter number");
                                numbers[getIndexUpdate] = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("enter gender");
                                gender[getIndexUpdate] = Console.ReadLine();
                                break;

                            case 4:
                                Console.WriteLine("enter city");
                                cities[getIndexUpdate] = Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("Enter valid choice");
                                break;

                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter number whose info you want to delete");
                        string deleteNumber = Console.ReadLine();

                        int getIndexDelete = -1;
                        for (int i = 0; i < count; i++)
                        {
                            if (deleteNumber == numbers[i]) { getIndexDelete = i; break; }
                        }
                        if (getIndexDelete == -1)
                        {
                            Console.WriteLine("Number not found");
                            break;
                        }
                        // Shift records left
                        for (int i = getIndexDelete; i < count - 1; i++)
                        {
                            names[i] = names[i + 1];
                            numbers[i] = numbers[i + 1];
                            gender[i] = gender[i + 1];
                            cities[i] = cities[i + 1];
                        }
                        count--;
                        Console.WriteLine("Record deleted successfully");
                        break;


                    case 4:
                        Console.WriteLine("Enter number whose info you want to search");
                        string searchNumber = Console.ReadLine();
                        int getIndexSearch = -1;
                        for (int i = 0; i < count; i++)
                        {
                            if (searchNumber == numbers[i]) { getIndexSearch = i; break; }
                        }
                        if (getIndexSearch == -1)
                        {
                            Console.WriteLine("Number not found");
                            break;
                        }
                        Console.WriteLine("Contact Info is : ");
                        Console.WriteLine("Name :" + names[getIndexSearch]);
                        Console.WriteLine("Number :" + numbers[getIndexSearch]);
                        Console.WriteLine("Gender :" + gender[getIndexSearch]);
                        Console.WriteLine("City :" + cities[getIndexSearch]);
                        break;

                    case 5:
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Record " + (i + 1) + ":");
                            Console.WriteLine("Name :" + names[i]);
                            Console.WriteLine("Number :" + numbers[i]);
                            Console.WriteLine("Gender :" + gender[i]);
                            Console.WriteLine("City :" + cities[i]);
                        }
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }



            } while (choice != 6);

        }

    }


}
