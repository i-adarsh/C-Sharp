using System;

public class Person{
    private String firstName;
    private String lastName;
    private DateTime dob;

    public String FirstName{
        set{firstName = value;}
        get { return firstName;}
    }
    public String LastName{
        set{ lastName = value;}
        get { return lastName;}
    }
    public DateTime Dob{
        set{dob = value;}
        get { return dob;}
    }
    public int GetAge(DateTime dob){
        int age = 0;
        age = DateTime.Now.Year - dob.Year;
        if (DateTime.Now.DayOfYear < dob.DayOfYear){
            age = age - 1;
            return age;
        }
        return age;
    }
    public String Adult{
        // get { return group;}
        get{ if (GetAge(dob) > 18){
            return "Adult";
            }
            else{
            return "Child";
            } 
            }
    }

    public void DisplayDetails(){
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", GetAge(dob));
        Console.WriteLine(Adult);
    }
    
}

public class Program{
    public static void Main(String [] args){
        Console.WriteLine("Enter first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());
        Person person = new Person();
        person.FirstName = firstName;
        person.LastName = lastName;
        person.Dob = dob;
        // person.Adult = person.GetAge(dob).ToString();
        person.DisplayDetails();
    }
}