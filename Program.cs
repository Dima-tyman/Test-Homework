Console.Clear();

double InputNum (string nameVar) {
	double num;
	Console.Write($"Введите {nameVar}: ");
	while (!double.TryParse(Console.ReadLine(), out num))
		Console.Write($"Ошибка! Введите число {nameVar}: ");
	return num;
}

double  k1 = InputNum("k1"),
	b1 = InputNum("b1"),
	k2 = InputNum("k2"),
	b2 = InputNum("b2");

//y = k1 * x + b1
//y = k2 * x + b2

if (k1 * b1 == k2 * b2)
	Console.WriteLine("Прямые параллельны! Точки пересечения нет.");
else {
	double[] dotCoordinate =
		{(Math.Round(   (b2 - b1) / (k1 - k2)             , 2)),  //x
		 (Math.Round(  ((b2 - b1) / (k1 - k2)) * k2 + b2  , 2))}; //y

	Console.WriteLine($"Координаты точки пересечения прямых ({String.Join("; ", dotCoordinate)})");

	//второй вариант через обычные переменные
	//double x = (b2 - b1) / (k1 - k2);
	//double y = x * k2 + b2;

	//Console.WriteLine($"Координаты точки пересечения прямых ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}