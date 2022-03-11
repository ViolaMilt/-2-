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
