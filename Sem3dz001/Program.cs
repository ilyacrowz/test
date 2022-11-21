Console.WriteLine("Enter a five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
string arr = Convert.ToString(num);
if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        Console.WriteLine("You namber is a palindorm");
    }   
else
    {
        Console.WriteLine("Your number is not a palindrome");    
    }