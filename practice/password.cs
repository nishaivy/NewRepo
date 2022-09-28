using System;
public class Password
{
public static void Main()
{
string username, password;
int attempt = 0,crrt=0;
       Console.Write("Check username and password :\n");
do
{
Console.Write("Input a username: ");
username = Console.ReadLine();
 
Console.Write("Input a password: ");
password = Console.ReadLine();
if( username == "nisha" && password == "12345" )
{
    crrt=1;
    attempt=3;
}

else
{
    crrt=0;
    attempt++;
}
}
while (( username != "nisha" || password != "12345" )
        && (attempt != 3));
        if (crrt == 0)
        {
            Console.Write("\nLogin attemp more than three times. Try later!\n");
        }
        else  
        if(crrt==1)
        {
            Console.Write("\nPassword entered correctly!\n");	}         
    }
}

//output
// Check username and password :
// Input a username: dsgh
// Input a password: fghw
// Input a username: rtyu
// Input a password: fgh
// Input a username: nisha
// Input a password: 12345
// Password entered correctly!