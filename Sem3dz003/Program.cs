Console.WriteLine("Add to num :");
int num = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <= num; i++)
    {
        double numq = Math.Pow(i, 3);
        Console.WriteLine(numq);
    }