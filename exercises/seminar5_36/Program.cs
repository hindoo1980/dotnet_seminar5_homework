//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


    void arrCreate ()

    {
        Random rnd = new Random();

        int[] nums = new int[rnd.Next(5, 10)];
        
        for (int i = 0; i < nums.Length ; i++ )  // можно было бы суммировать по проверке на остаток от деления i на два, не создавая новый цикл, как правильно? 

        {
            nums[i] = rnd.Next(1, 100); 
        }

        int oddPosSumm = nums[1];

        for (int i = 3; i < nums.Length ; i = i + 2 )
        {
          oddPosSumm =  oddPosSumm + nums[i]; 
        }
  
        Console.WriteLine($"сумма всех вхождеий массива с нечетным индексом равна {oddPosSumm}");
    }


    arrCreate ();

