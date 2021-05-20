using System;

public class Account{
    private int id;
    private String accountType;
    private double balance;

    public int Id{
        set{id = value;}
        get { return id;}
    }
    public String AccountType{
        set{accountType = value;}
        get { return accountType;}
    }
    public double Balance{
        if (balance < 0){
            balance = 0;
        }
    }
    public boolean WithDraw (double amount){
        if (balance > amount){
            balance -= amount;
            return true;
        }
        else{
            return false;
        }
    }
    public String GetDetails(){
        return "Account Id: "+id.ToString()+"\nAccount Type: "+accountType+"\nBalance: " + balance.ToString();
    }
    public Account(){

    }
    public Account(int id, String accountType, double balance){
        this.id = id;
        this.accountType = accountType;
        this.balance = balance;
    }
}

public class Program{
    public static void Main(String [] args){
        Console.WriteLine("Enter account id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter account type");
        String type = Console.ReadLine();
        Console.WriteLine("Enter account balance");
        double balance = Convert.ToDouble(Console.ReadLine());
        Account account = new Account(id, type, balance);
        Console.WriteLine(account.GetDetails());
    }
}

