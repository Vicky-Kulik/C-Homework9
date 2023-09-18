//Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

 void Palindrom ()
{
    Console.Write("Введите пятизначное число: ") ;
    string str = (Console.ReadLine ()) ;
    
    if (str[0] == str [4] && str[1] == str [3] && str.Length == 5 )
            {
            Console.WriteLine($"Число {str} палиндром");
            }

    if (str[0] != str [4] && str[1] != str [3] && str.Length == 5 )
            {
            Console.WriteLine($"Число {str} не является палиндром");
            }
    if (str.Length != 5 )
             {
                Console.WriteLine("Вы ввели не пятизначное число");
             }
}

Palindrom ();
