// Console.Write("введи кол-во студентов: ");
// int students = Convert.ToInt32(Console.ReadLine());
// Console.Write("введи кол-во предметов: ");
// int subjects = Convert.ToInt32(Console.ReadLine());
// int[,] marks = new int[students, subjects];
// //ввожу оценки 
// for (int i = 0; i < students; i++)
// {
//     int sum = 0;
//     for (int j = 0; j < subjects; j++)
//     {
//         Console.Write($"введи оценку {j + 1} предмета для {i + 1} студента: ");
//         //перевожу текст в число
//         marks[i, j] = Convert.ToInt32(Console.ReadLine());
//         //добавляю оценку к сумме
//         sum += marks[i, j];
//     }
//     //считаю среднюю оценку студента
//     double average = (double)sum / subjects;
//     //вывожу среднюю
//     Console.WriteLine($"средняя оценка {i + 1} студента: {average}");
// }