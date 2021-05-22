using System;

public class Shop{
    private String shopName;
    private String shopAddress;
    private String [] products;

    public String ShopName{
        set{shopName = value;}
        get { return shopName;}
    }
    public String ShopAddress{
        set{shopAddress = value;}
        get { return shopAddress;}
    }
    public String[] Products{
        set{products = value;}
        get { return products;}
    }
}

public class Program{
    public static String ProductAvailability(Shop shopObj, String product){
        int count = 0;
        for (int i = 0; i < shopObj.Products.Length; i++){
            if (shopObj.Products[i] == product){
                count++;
            }
        }
        if (count == 0){
            return "Product is NotAvailable at" + shopObj.ShopName + ", " + shopObj.ShopAddress
        }
        else{
            return "Product is Available at " + shopObj.ShopName + ", " + shopObj.ShopAddress
        }
    }

    public static void Main(){
        Console.WriteLine("Enter the Shop Name:")
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Address:");
        string add = Console.ReadLine();
        Console.WriteLine("Enter number of products:")
        int n = Convert.ToInt32(Console.ReadLine());
        string [] product = new string[n];
        for (int i = 0; i <n; i++){
            product[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the product to be searched:")
        string search = Console.ReadLine();
        Shop shop = new Shop();
        shop.ShopName = name;
        shop.ShopAddress = add;
        shop.Products = product;
        Console.WriteLine(ProductAvailability(shop, search));
    }

}

