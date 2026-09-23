// Console.Write("введи размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[n];

// //ввожу элементы 
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"введи {i + 1} число: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// //считаю сумму
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += numbers[i];
// }

// //считаю среднее 
// double srednee = (double)sum / n;

// Console.WriteLine($"среднее арифметическое: {srednee}");

// //вывожу массив в обратном порядке
// Console.WriteLine("массив в обратном порядке:");

// for (int i = n - 1; i >= 0; i--)
// {
//     Console.Write($"{numbers[i]} ");
// }

// Console.WriteLine();

// //нахожу число, которое ближе всего к среднему
// int blizaisee = numbers[0];
// //нахожу растояние между последним числом и средним
// double raznica = Math.Abs(numbers[0] - srednee);

// for (int i = 1; i < n; i++)
// {
//     double tecuschRaznica = Math.Abs(numbers[i] - srednee);

//     //сравниваю расстояние до среднего
//     if (tecuschRaznica < raznica)
//     {
//         raznica = tecuschRaznica;
//         blizaisee = numbers[i];
//     }
// }

// Console.WriteLine($"ближе всего к среднему: {blizaisee}");