// Dictionary<string, string> contacts = new Dictionary<string, string>();
// string command = "";

// //выполняю команды пока не введу выход
// while (command != "выход")
// {
//     Console.Write("введи команду (добавить, поиск, просмотр, выход): ");
//     command = Console.ReadLine();

//     if (command == "добавить")
//     {
//         Console.Write("введи имя: ");
//         string name = Console.ReadLine();
//         Console.Write("введи номер телефона: ");
//         string phone = Console.ReadLine();

//         //добавляю контакт в телефонную книгу
//         contacts[name] = phone;
//         Console.WriteLine("контакт добавлен");
//     }
//     else if (command == "поиск")
//     {
//         Console.Write("введи имя: ");
//         string name = Console.ReadLine();

//         //проверяю наличие контакта
//         if (contacts.ContainsKey(name))
//         {
//             Console.WriteLine($"номер: {contacts[name]}");
//         }
//         else
//         {
//             Console.WriteLine("контакт не найден");
//         }
//     }
//     else if (command == "просмотр")
//     {
//         //вывожу все контакты
//         foreach (var contact in contacts)
//         {
//             Console.WriteLine($"{contact.Key}: {contact.Value}");
//         }
//     }
//     else if (command != "выход")
//     {
//         Console.WriteLine("неизвестная команда");
//     }
// }

// Console.WriteLine("программа завершена");