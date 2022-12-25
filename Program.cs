// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter first number");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
int n2 = int.Parse(Console.ReadLine());

for(int z = n1;z<= n2;z++)
{
    if (z<=1)
    {
        continue;
    }
    else
    {
        int y = 0;
        for (int i = 2;i<z;i++)
        {
            if (z%i ==0)
            {
                y = 1;
                break;
            }
                        
        }
        if(y==0)
        {
            Console.WriteLine(z);
        }



    }
}

