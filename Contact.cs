public class AddressBook
{
    string cityname;
    string state;
    double zipcode;
    long phoneNo;
    string email_id;
    void name(string firstname,string lastname)
    { 
        string fullname = firstname+ " " + lastname;

        
        Console.WriteLine("Your firstname is:- :" + firstname);
        Console.WriteLine("Your lastname  is:-  :" + lastname);
        Console.WriteLine("Your fullname  is:-  :" + fullname);
      

    }
    /*void CityAdress()
    {
        string cityname;
        string state;
        int zipcode;
        long phoneNo;
        string email_id;


    }*/
    public static void Main()
    {
        AddressBook add = new AddressBook();
        add.name("Nitish", "Mehta");

        add.cityname = "Bangalore";
        add.state = "karnataka";
        add.zipcode = 5600068;
        add.phoneNo = 8252669501;
        add.email_id = "nkrmehta09@gmail.com";

         
              Console.WriteLine("cityname is :-" +add.cityname);
              Console.WriteLine("state    is :-" + add.state);
              Console.WriteLine("zipcode  is :-" + add.zipcode);
              Console.WriteLine("phoneNo  is :-" + add.phoneNo);
              Console.WriteLine("mail_id  is :-" + add.email_id);
        }
}