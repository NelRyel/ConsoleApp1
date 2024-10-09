// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x=0;
//try
//{

//    x = Convert.ToInt32(Console.ReadLine());
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//for (int i = 0; i < 1025; i++)
//{

//    Console.WriteLine(MegaPrint(x));
//    x++;
//}
int[] arr = [12, 18, 42];
DumpMath(arr);

//Разработайте функцию, которая принимает целое число в качестве аргумента и возвращает строку, содержащую это число и слово "компьютер" 
//    в нужном склонении по падежам в зависимости от числа. Например, при вводе числа 25 функция должна возвращать "25 компьютеров", для 
//    числа 41 — "41 компьютер", а для числа 1048 — "1048 компьютеров".

string MegaPrint(int a)
{
    string s = "";
    s += a;
    if (s.Length ==1)
    {
        if (s[s.Length-1].ToString() == "1")
        {
            s += " компьтер";
            return s;
            
            
        }
        if (s[s.Length-1].ToString() =="2" || s[s.Length-1].ToString() == "3" || s[s.Length-1].ToString() == "4")
        {
            s += " компьютера";
            return s;


        }

        if (s[s.Length - 1].ToString() == "0" || s[s.Length - 1].ToString() == "5" || s[s.Length - 1].ToString() == "6" || s[s.Length - 1].ToString() == "7"
            || s[s.Length - 1].ToString() == "8" || s[s.Length - 1].ToString() == "9")
        {
            s += " компьютеров";
            return s;


        }

        return "ANOTHER WRONG";

    }
    if (s.Length >= 2)
        
    {
        if(s[s.Length - 1].ToString() == "1"&& s[s.Length - 2].ToString() == "1")
        {
            s += " компьютеров";
            return s;
        }

        if (s[s.Length - 1].ToString() == "1")
        {
            s += " компьтер";
            return s;
        }
        s += " компьютеров";
        return s;

    }
    else
    {
        return "WRONG";
    }
}



void DumpMath(int[]arr)
{
    double x = 1;
    double a;
    for(int j=0; j<arr.Length; j++)
    {
     for(int i=0; i < arr[j]; i++)
        {
            a = arr[j] / x;
            if (IsCeloe(a) == true)
            {
                Console.WriteLine( x);
            };
            x++;
        }
    }


   
}

bool IsCeloe(double n)
{
    if (n % 1 == 0)
    {
        return true;
    }
    else { return false; }
}
