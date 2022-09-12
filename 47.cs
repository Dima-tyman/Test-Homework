Console.Clear();

int m, n;
Console.Write("Введите число строк: ");
while (!int.TryParse(Console.ReadLine(), out m)) Console.Write("Ошибка! ВВедите число: ");
Console.Write("Введите число столбцов: ");
while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("Ошибка! ВВедите число: ");

double[,] FillTable (int rows, int columns, int min, int max, int round) {
	double [,] result = new double[rows, columns];
	for (int i = 0; i < rows; i++)
		for (int j = 0; j < columns; j++)
			result[i, j] = Math.Round(new Random().NextDouble() * //случайное дробная от 0 до 1
			(Math.Abs(max) + Math.Abs(min)) + min, round);        //конвертация в диапозон min/max
	return result;
}

void PrintTable (double[,] table, int space) {
	int rows = table.GetUpperBound(0) + 1;
	int columns = table.GetUpperBound(1) + 1;
	Console.SetCursorPosition(0, Console.CursorTop + 1);
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < columns; j++) {
			Console.SetCursorPosition(0 + (space * j), Console.CursorTop);
			Console.Write($"{table[i, j]}  ");
			}
		Console.SetCursorPosition(0, Console.CursorTop + 2);
		}
	Console.SetCursorPosition(0, Console.CursorTop - 1);
}

int CountNumber (int num) {
	int count = 1;
	for (int i = 10; num / i != 0; i*= 10) count++;
	return count;
}

int maxNum = 10, minNum = -10, roundNum = 2; //параметры случайных чисел

int spaceNum = 4 + roundNum + CountNumber(Math.Max(Math.Abs(maxNum), Math.Abs(maxNum))); //определение величины пробела для вывода
// 4 - двойной пробел + знак минус + запятая
double[,] table = FillTable(m, n, minNum, maxNum, roundNum);

Console.WriteLine($"Таблица случайных вещественных чисел от {minNum} до {maxNum}");
PrintTable(table, spaceNum);