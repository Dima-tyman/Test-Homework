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

double[] averangeColumns = new double[table.GetUpperBound(1) + 1];

for (int i = 0; i < table.GetUpperBound(1) + 1; i++) {
	for (int j = 0; j < table.GetUpperBound(0) + 1; j++)
		averangeColumns [i] += table[j, i];
	averangeColumns [i] /= table.GetUpperBound(0) + 1;
}

Console.WriteLine("Средние значения");
Console.WriteLine(String.Join(" ", averangeColumns));