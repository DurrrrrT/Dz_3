// System.Console.WriteLine("Введите 5 значное число ");
// int a = Convert.ToInt32(Console.ReadLine());
//                                                    //12321
// if (a < 99999 & a >= 10000)
// {
//     int x = a / 1000;//x=12321/1000=12
//     int num1 = x / 10;//num1=12/10=1
//     int num2 = x % 10;//num2=12%10=2
//     int y = a % 100;  //12321%100=21
//     int num3 = y / 10;//num3=21/10=2
//     int num4 = y % 10;//num4=21%10=1

//     if ((num1 == num4) && (num2 == num3))
//     {
//         System.Console.WriteLine("Это палиндром ");
//     }
//     else
//     {
//         System.Console.WriteLine("Это не палиндром ");
//     }

// }
// else
// {
//     System.Console.WriteLine("Неверное число ");
// }


// System.Console.WriteLine("Введите 5 значное число ");
// string a = Convert.ToString(Console.ReadLine());

// char[] array = a.ToCharArray();
// Array.Reverse(array);
// string b = new string(array);
// if (a == b)
// {
//     System.Console.WriteLine("Полиндром ");
// }
// else

// {
//     System.Console.WriteLine("Не полиндром ");
// }


string s = Console.ReadLine();              
if (s.Length == 5)                          
{
    if (s[0] == s[4] && s[1] == s[3])
    {
        System.Console.WriteLine("Палиндром ");
    }
    else
    {
        System.Console.WriteLine("Не палиндром ");
    }

}
else
{
    System.Console.WriteLine("Число не пятизначное ");
}
