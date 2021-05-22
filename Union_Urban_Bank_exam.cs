using System;

public class Applicant{
    private String name;
    private String address;
    private String phno;
    private String gender;
    private String documentType;
    private String documentNo;

    public String Name{
        set{name = value;}
        get { return name;}
    }
    public String Address{
        set{address = value;}
        get { return address;}
    }
    public String Phno{
        set{phno = value;}
        get { return phno;}
    }
    public String Gender{
        set{gender = value;}
        get { return gender;}
    }
    public String DocumentType{
        set{documentType = value;}
        get { return documentType;}
    }
    public String DocumentNo{
        set{documentNo = value;}
        get { return documentNo;}
    }
}

public class Program{
    public String ValidateDocumentType(String documentType){

        if (documentType == "Aadhaar"){
            return "valid";
        }
        else if (documentType == "Driving Licence"){
            return "valid";
        }
        else if (documentType == "Pan"){
            return "valid";
        }
        else{
            return "invalid";
        }
    }
    public String ValidateDocumentNo(String documentNumber, String documentType){
        if (documentType == "Aadhaar"){
            int count = 0;
            for (int i = 0; i < documentNumber.Length; i++){
                if (documentNumber[i] >= '0' && documentNumber[i] <= '9'){
                    continue;
                }
                else{
                    count++;
                }
            }
            if (count == 0){
                return "valid";
            }
            else {
                return "invalid";
            }
        }
        else if (documentType == "Pan"){
            int count = 0;
            for (int i = 0; i < 5; i++){
                if (documentNumber[i] >= 'A' && documentNumber[i] <= 'Z'){
                    continue;
                }
                else{
                    count++;
                }
            }
            for (int i = 5; i < 9; i++){
                if (documentNumber[i] >= '0' && documentNumber[i] <= '9'){
                    continue;
                }
                else{
                    count++;
                }
            }
            if (!(documentNumber[documentNumber.Length - 1] >= 'A' && documentNumber[documentNumber.Length - 1] <= 'Z')){
                count++;
            }
            if (count == 0){
                return "valid";
            }
            else {
                return "invalid";
            }
        }
        else if(documentType == "Driving Licence"){
            int count = 0;
            for (int i = 0; i < documentNumber.Length; i++){
                if (i == 1 || i == 6){
                    if (documentNumber[i] == '/'){
                        continue;
                    }
                    else{
                        count++;
                    }
                }
                else if (documentNumber[i] >= '0' && documentNumber[i] <= '9'){
                    continue;
                }
                else{
                    count++;
                }
            }
            if (count == 0){
                return "valid";
            }
            else {
                return "invalid";
            }
        }
        else {
            return "invalid";
        }
    }
    public String Credentials(Applicant applicantObj){
        if (ValidateDocumentNo(applicantObj.DocumentNo, applicantObj.DocumentType) == "valid" && ValidateDocumentType(applicantObj.DocumentType) == "valid"){
            return applicantObj.Name.ToUpper() + ", your registration is completed for the application.";
        }
        else if(ValidateDocumentType(applicantObj.DocumentType) == "invalid"){
            return "Document Type is Invalid for - " + applicantObj.Name;
        }
        else if(ValidateDocumentNo(applicantObj.DocumentNo, applicantObj.DocumentType) == "invalid"){
            return "Document Number is Invalid for - " + applicantObj.Name;
        }
        else{
            return "Document Type is Invalid for - " + applicantObj.Name;
        }
        
    }
    public static void Main(){
        Console.WriteLine("Enter the applicant name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the phone number");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter the gender (Male/Female/Others)");
        string gender = Console.ReadLine();
        Console.WriteLine("Enter the document type");
        string documentType = Console.ReadLine();
        Console.WriteLine("Enter the document number");
        string documentNumber = Console.ReadLine();
        Applicant applicantObj = new Applicant();
        applicantObj.Name = name;
        applicantObj.Address = address;
        applicantObj.Phno = phone;
        applicantObj.Gender = gender;
        applicantObj.DocumentType = documentType;
        applicantObj.DocumentNo = documentNumber;
        Program program = new Program();
        Console.WriteLine(program.Credentials(applicantObj));
    }
}