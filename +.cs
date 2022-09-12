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

int[,] table = FillTable(4, 4, 0, 10);

Console.WriteLine("Снегерированный массив:");
PrintTable(table);

int[] sumColumns = new int[table.GetUpperBound(1) + 1];

for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
	for (int j = 0; j < table.GetUpperBound(0) + 1; j++)
		sumColumns [i] += table[j, i];

int sumCorner = table[0, 0] +
		table[0, table.GetUpperBound(1)] +
		table[table.GetUpperBound(0), 0] + 
		table[table.GetUpperBound(0), table.GetUpperBound(0)];
int sumColumMax = sumColumns.Max();

if (sumCorner == sumColumMax)
	Console.WriteLine($"Сумма углов ({sumCorner}) и макс. стобца ({sumColumMax}) равны.");
else if (sumCorner > sumColumMax)
	Console.WriteLine($"Сумма углов ({sumCorner}) больше суммы макс. стобца ({sumColumMax}).");
else
	Console.WriteLine($"Сумма углов ({sumCorner}) меньше суммы макс. стобца ({sumColumMax}).");
