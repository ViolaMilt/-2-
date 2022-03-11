//Задача 10
 Console.WriteLine ( "Введите трехзначное число:  ");
 string k = Console.ReadLine();
 
   char[] arr = new char[k.Length];
            for (int i = 0; i < k.Length; i++)
            {
               arr[i] = k[i];
            }
            Console.WriteLine(arr[2] +""+arr[1] +""+arr[0]);


//Задача 10.Второй вариант  
  Console.WriteLine ( "Введите техзначное число:  ");
 string n = Console.ReadLine();
 string itog = string.Concat(k[2] , k[1] , k[0]);
Console.WriteLine(itog);

//Задача 10.Третий вариант 
Console.WriteLine("Введите число: ");
string slovo = Console.ReadLine();
//Functia10(slovo);
Console.WriteLine(Functia10(slovo));
string Functia10(string k)
 {
 string itog = string.Concat(k[2] , k[1] , k[0]);
 
 return itog;}

//Задача 13
 Console.WriteLine ( "Введите число:  ");
 string y = Console.ReadLine();
 int d = y.Length;
  
   if (d > 2)
         {
            Console.WriteLine( y[2]);
         }
         else
         {
             Console.WriteLine("Третьей цифры нет");
         } 

  //Задача 15
    Console.WriteLine("Введите цифру,соответствующую дню недели:1-Пн,2-Вт,3-Среда,4-Чт,5-Пт,6-Сб,7-Вс");
    int f = Convert.ToInt32 (Console.ReadLine());
    if (f == 6 || f == 7 )
    {
        Console.WriteLine("Да, выходной");
    }
    else
    {
        Console.WriteLine("Нет, рабочий");
    }
