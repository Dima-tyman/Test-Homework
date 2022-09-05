Console.Clear();
        int lengthArray;
        Console.Write("Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
        Console.Write("Ошибка! Введите число: ");
        }

        int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];
        int[] arrayEvenInt = new int[array.Length];
        int[] arrayNotEvenInt = new int[array.Length];
        
        void FillArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = new Random().Next(1, 10);
            }
        }

        void WriteArray(int[] arr) {
            Console.Write($"Массив: ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write($"{arr[i]} ");
            }
        }
        
        void SplitArrayByEvenInt(int[] arr, int[] arrEven, int[] arrNoEven) {
            int iEven = 0, iNoEven = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0) {
                    arrEven[iEven] = arr[i];
                    iEven++;
                } else {
                    arrNoEven[iNoEven] = arr[i];
                    iNoEven++;
                }
            }
        }
        // добавить чек в случае отсутствия четных или нечетных чисел (ошибка деления на ноль)
        double AverArr (int[] arr) {
            int sum = 0, count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 0) break;
                sum += arr[i];
                count++;
            }
            double aver = sum / count;
            return aver;
        }
        
        FillArray(array);
        WriteArray(array);
        Console.WriteLine();
        SplitArrayByEvenInt(array, arrayEvenInt, arrayNotEvenInt);
        Console.WriteLine();
        WriteArray(arrayEvenInt);
        Console.WriteLine();
        WriteArray(arrayNotEvenInt);
        Console.WriteLine();
        Console.WriteLine(AverArr(arrayEvenInt));
        Console.WriteLine(AverArr(arrayNotEvenInt));
        Console.WriteLine(AverArr(arrayEvenInt) > AverArr(arrayNotEvenInt) ? "Even" : "NoEven"); //а если будет равно?
