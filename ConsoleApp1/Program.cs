string username,password ;
Console.Write ("Enter Username : ");
username = Console.ReadLine() ;
Console.Write("Password : ");            
password = Console.ReadLine() ;
Console.WriteLine  ("Welcome "  + username );
Console.Write("How May I Help You ? : ");
Console.Read() ;
int examresult = 70;
Console.WriteLine("Your Letter Grade ");

if (examresult > 60 && examresult < 80)
    Console.WriteLine("B");
else if (examresult > 40 && examresult < 60)
    Console.WriteLine("C");
else if (examresult > 20 && examresult < 40)
    Console.WriteLine("D");
else if (examresult > 0 && examresult < 20)
    Console.WriteLine("F");
else if (examresult > 80 && examresult < 100)
    Console.WriteLine("A");
Console.Read() ;