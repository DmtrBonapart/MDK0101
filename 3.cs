// int[] numbers = new int[100];
// int count = 0;
// bool repeat = false;
// //ввожу числа в массив
// while (!repeat)
// {
//     Console.Write("введи число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     //проверяю встречалось ли число раньше
//     for (int i = 0; i < count; i++)
//     {
//         if (numbers[i] == number)
//         {
//             repeat = true;
//             break;
//         }
//     }
//     //добавляю число если не повторяется
//     if (!repeat)
//     {
//         numbers[count] = number;
//         count++;
//     }
// }
// //вывожу массив
// Console.WriteLine("массив:");
// for (int i = 0; i < count; i++)
// {
//     Console.Write($"{numbers[i]} ");
// }