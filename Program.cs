// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("enter first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
int num2 = int.Parse(Console.ReadLine());
for (int x = num1;x < num2;x++ )
{
    int z = the_output(x);
    if (x==z)
    {
        Console.WriteLine(x);
    }
}
 static int the_output(int range)
{
    int all = 0;
    for(int i=1;i<range;i++)
    {
        if (range%i==0)
        {
            all = all + i;
        }

    }
    return all;
}
