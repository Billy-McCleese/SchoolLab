

using SchoolDemo;

Console.WriteLine("Welcome to the School Online System! Please login to continue.");

do
{
    Console.WriteLine("Enter your email address: ");

    string userEmail = Console.ReadLine();

    Console.WriteLine("Enter your password: ");
    string userPassword = Console.ReadLine();


    if (passwordIsCorrect)
    {
        //log the user in
        //the whole app functions here. 
    }
    else
    {
        Console.WriteLine("Sorry");
    }



    Console.WriteLine("Would you like to restart the app?");
} while (Console.ReadLine() == "y");


Student s1 = new Student();
s1.CurrentStatus = RegistrationStatus.Accepted;


