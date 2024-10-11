
//Get regNr input- får vara max 10 tecken
string[] parkingSpaces = new string[100];

int choice = 0;

Console.WriteLine("Your vehicles registration");
string regNumber = Console.ReadLine();

if(regNumber.Length < 11|| regNumber == null || regNumber == " ")
{
    Console.WriteLine("Invalid registration");
}


Console.WriteLine("");
//hitta input i parkingSpaces
//ta bort det från parkingSpaces





