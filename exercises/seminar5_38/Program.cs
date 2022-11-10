//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    void arrCreate ()

    {
        Random rndInt = new Random();

        Random rndDouble = new Random();

        int size = rndInt.Next(10, 15);

        // double xxx = rndDouble.NextDouble();

        // Console.WriteLine(xxx);

        double[] nums = new double[rndInt.Next(3, 8)];
        
        for (int i = 0; i < nums.Length ; i++ )  // можно было бы суммировать по проверке на остаток от деления i на два, не создавая новый цикл, как правильно? 

        {
            nums[i] = rndDouble.NextDouble()*rndInt.Next(-100, 100); 
            //Console.WriteLine(nums[i]);
        }


        double maxValue = nums[0];
        double minValue = nums[0];

        for (int i = 0; i < nums.Length ; i++ )
        {
          if(nums[i] > maxValue)
          {
           maxValue = nums[i];
          }
          else if(nums[i] < minValue)
          {
            minValue = nums[i];
          }
        }
  
         Console.WriteLine($"разница между максимальным {maxValue} и минимальным {minValue} значениями элементов сгенерированного массива равна {maxValue - minValue}");
         }

    arrCreate ();