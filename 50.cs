Console.Clear();

int[,] FillTable (int rows, int columns, int min, int max) {
	int[,] result = new int[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			result[i, j] = new Random().Next(min, max);
	return result;
}

void PrintTable (int[,] table) {
	int rows = table.GetUpperBound(0) + 1;
	int columns = table.GetUpperBound(1) + 1;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++)
			Console.Write($"{table[i, j]}  ");
		Console.WriteLine();
		}
}

int[,] table = FillTable(5, 5, 0, 10);

Console.WriteLine("Снегерированный массив:");
PrintTable(table);

int i, j;
Console.Write("Введите строку: ");
while (!int.TryParse(Console.ReadLine(), out i) || i <= 0) Console.Write("Ошибка! ВВедите положительное число: ");
Console.Write("Введите столбец: ");
while (!int.TryParse(Console.ReadLine(), out j) || j <= 0) Console.Write("Ошибка! ВВедите положительное число: ");

if (i <= table.GetUpperBound(0) + 1 && j <= table.GetUpperBound(1) + 1)
	Console.WriteLine($"Элемент на данной позиции: {table[i - 1, j - 1]}");
else
	Console.WriteLine("Элемент на данной позиции отсутствует.");