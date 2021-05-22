using System;

namespace Sonu{
    public class Adarsh{
        public static void Main(){
            string [] name = new string[6];
            int bill = 0, daisy = 0, tommy = 0;
            for (int i = 0; i < name.Length; i++){
                Console.Write("Player Name : ");
                name[i] = Console.ReadLine();
                if (name[i][0] == ' '){
                    continue;
                }
                if (i != 0){
                    if (name[i-1][0] == name[i][0]){
                        if(name[i][0] == 'B'){
                            bill += 2;
                            continue;
                        }
                        if(name[i][0] == 'D'){
                            daisy += 2;
                            continue;
                        }
                        if(name[i][0] == 'T'){
                            tommy += 2;
                            continue;
                        }
                    }
                }
                if(name[i][0] == 'B'){
                    bill += 1;
                }
                if(name[i][0] == 'D'){
                    daisy += 1;
                }
                if(name[i][0] == 'T'){
                    tommy += 1;
                }
            }
            Console.WriteLine("Bill Score : {0}", bill);
            Console.WriteLine("Tommy Score : {0}", tommy);
            Console.WriteLine("Daisy Score : {0}", daisy);
        }
    }
}