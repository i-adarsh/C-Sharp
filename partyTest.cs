using System;

public class Program{
    public double BillGeneration(int numberOfGuests){
        double total;
        if (numberOfGuests >= 1 && numberOfGuests <= 49){
            total = numberOfGuests * 350;
            return total;
        }
        else if(numberOfGuests >= 50 && numberOfGuests <= 99){
            total = numberOfGuests * 350;
            total = total + (total * 0.12f);
            return total;
        }
        else if(numberOfGuests >= 100 && numberOfGuests <= 149){
            total = numberOfGuests * 350;
            total = total + (total * 0.15f);
            return total;
        }
        else if(numberOfGuests >= 150 && numberOfGuests <= 200){
            total = numberOfGuests * 350;
            total = total + (total * 0.18f);
            return total;
        }
        else{
            return 0;
        }
    }
    public static void Main(){
        Console.WriteLine("Enter the name of the customer");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the date");
        string date = Console.ReadLine();
        Console.WriteLine("Enter the number of guests");
        int number = Convert.ToInt32(Console.ReadLine());
        Program program = new Program();
        double price = program.BillGeneration(number);
        if (price == 0){
            Console.WriteLine("Check for a separate plan");
        }
        else{
            Console.WriteLine("Happy Events");
            Console.WriteLine("Name of the customer: {0}", name);
            Console.WriteLine("Date of the event: {0}", date);
            Console.WriteLine("No. of guests: {0}", number);
            Console.WriteLine("Total Amount: Rs.{0}", Math.Round(price));
        }
    }


}