// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



    void arrCreate ()

    {
        Random rnd = new Random();

        int[] nums = new int[rnd.Next(10, 25)];
        
        int evenCount = 0;

        for (int i = 0; i < nums.Length ; i++ )

        {
            nums[i] = rnd.Next(100, 999);  

            if (nums[i] % 2 == 0) 
            {
                evenCount++;
            } 
        }
        
        Console.WriteLine($"число четных вхождеий массива равно {evenCount}");
    }

    arrCreate ();

