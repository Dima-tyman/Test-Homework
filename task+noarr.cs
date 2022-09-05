        Console.Clear();
        int lengthArray;
        Console.Write("Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out lengthArray)) {
        Console.Write("Ошибка! Введите число: ");
        }

        int[] array = new int[lengthArray > 0 ? lengthArray : -lengthArray];
        
        void FillArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = new Random().Next(-9, 10);
            }
        }

        void WriteArray(int[] arr) {
            Console.Write($"Массив: ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write($"{arr[i]} ");
            }
        }
        
        void CheckAverEvenInt(int[] arr) {
            int iEven = 0, iNoEven = 0, sumEven = 0, sumNoEven = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 == 0) {
                    sumEven += arr[i];
                    iEven++;
                } else {
                    sumNoEven += arr[i];
                    iNoEven++;
                }
            }
            double averEven = sumEven / iEven;
            double averNoEven = sumNoEven / iNoEven;
            Console.WriteLine(averEven > averNoEven ? "Even" : "NoEven");
        }
        
        FillArray(array);
        WriteArray(array);
        Console.WriteLine();
        CheckAverEvenInt(array);
