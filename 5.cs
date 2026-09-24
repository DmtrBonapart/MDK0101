// Dictionary<string, int> products = new Dictionary<string, int>();
// string product = "";

// //ввожу название продукта
// while (product != "выход")
// {
//     Console.Write("введи продукт: ");
//     product = Console.ReadLine();

//     if (product != "выход")
//     {
//         //проверяю, есть ли продукт в словаре
//         if (products.ContainsKey(product))
//         {
//             //увеличиваю количество продукта
//             products[product]++;
//         }
//         else
//         {
//             //добавляю новый продукт
//             products.Add(product, 1);
//         }

//         Console.WriteLine($"количество {product}: {products[product]}");
//     }
// }