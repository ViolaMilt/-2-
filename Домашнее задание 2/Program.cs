//Задача 10
 Console.WriteLine ( "Введите трехзначное число:  ");
 string k = Console.ReadLine();
 
   char[] arr = new char[k.Length];
            for (int i = 0; i < k.Length; i++)
            {
               arr[i] = k[i];
            }
            Console.WriteLine(arr[2] +""+arr[1] +""+arr[0]);

