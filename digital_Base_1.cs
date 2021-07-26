using System;

public class Program{
    public string GetTheWord(string incompleteword, string clueword){
            char [] arr = new char[incompleteword.Length];
            for (int i = 0; i < incompleteword.Length; i++){
                if (incompleteword[i] == '?'){
                    arr[i] = clueword[i];
                }
                else{
                    arr[i] = incompleteword[i];
                }
            }
            return new string(arr);
        }
    public static void Main(){
        Console.WriteLine("Enter the incomplete word");
        string incompleteword = Console.ReadLine();
        Console.WriteLine("Enter the clue word");
        string clueword = Console.ReadLine();
        Program program = new Program();
        Console.WriteLine(program.GetTheWord(incompleteword, clueword));
    }
}


// BT_1234:Sreejith:A:54000
// BW_3456:Vignesh:B:50000
// BS_89:Yaksh:A:9800
// AL_6789:Bkumar:C:52000
// WB_Afsal:C:67000