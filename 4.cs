// //ввожу оценки 
// for (int i = 1; i <= 3; i++)
// {
//     double sum = 0;
//     Console.WriteLine($"ввожу оценки {i} студента");
//     for (int j = 1; j <= 5; j++)
//     {
//         Console.Write($"введи {j} оценку: ");
//         //перевожу текст в число
//         int mark = Convert.ToInt32(Console.ReadLine());
//         //добавляю оценку к общей сумме
//         sum += mark;
//     }
//     //считаю среднюю 
//     double average = sum / 5;
//     Console.WriteLine($"средняя оценка {i} студента: {average}");
// }