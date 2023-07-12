// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using лаба1;

int all = 0;

UMarket pfc = new UMarket();

ChocoBar choco = new ChocoBar { Name = "Шоколадка", Carbohydrate = true, Fat = false, Protein = false, Colvo = 0 };
Crisps chips = new Crisps { Name = "Чипсы", Carbohydrate = false, Fat = true, Protein = false, Colvo = 0 };
BalykCheese cheese = new BalykCheese { Name = "Сыр балык", Carbohydrate = false, Fat = false, Protein = true, Colvo = 0 };
Chicken chicken = new Chicken { Name = "Куриное филе", Carbohydrate = false, Fat = false, Protein = true, Colvo = 0 };
Fruit fruit = new Fruit { Name = "Фрукты", Carbohydrate = true, Fat = false, Protein = false, Colvo = 0 };
OliveOil oil = new OliveOil { Name = "Оливковое масло", Carbohydrate = false, Fat = true, Protein = false, Colvo = 0 };
DumplingsMeat DumpMeat = new DumplingsMeat { Name = "Пельмени мясные", Carbohydrate = false, Fat = false, Protein = true, Colvo = 0 };
DumplingsBerries DumpBerry = new DumplingsBerries { Name = "Пельмени с ягодами", Carbohydrate = true, Fat = false, Protein = false, Colvo = 0 };
Cheburec chebu = new Cheburec { Name = "Чебурек", Carbohydrate = false, Fat = true, Protein = false, Colvo = 0 };

Cart<Food> allFood = new Cart<Food>();
allFood.Foodstuffs = new List<Food>
{
    choco,
    chips,
    cheese,
    chicken,
    fruit,
    oil,
    DumpMeat,
    DumpBerry,
    chebu
};

Cart<Food> basket = new Cart<Food>();
basket.Things = new List<Food>();

UMarket id = new UMarket();
UMarket ip = new UMarket();

Console.Clear();
Console.WriteLine("1. Приступить к выбору товара\n" +
                  "2. Фильтр\n");

Console.Write("Выберите номер операции: ");
string? a = Console.ReadLine();

switch (a)
{
    case "1":
        id.Id = 1;
        ip.Ip = 0;
        while (all == 0)
        {
            Console.Clear();
            Console.WriteLine("Выберете товар из списка: \n");
            Console.WriteLine("1. Шоколадка\n" +
                              "2. Чипсы\n" +
                              "3. Сыр балык\n" +
                              "4. Куриное филе\n" +
                              "5. Фрукты\n" +
                              "6. Оливковое масло\n" +
                              "7. Пельмени мясные\n" +
                              "8. Пельмени с ягодами\n" +
                              "9. Чебурек\n" +
                              "10. Посмотреть в корзину\n" +
                              "11. Сбалансировать питание\n"+
                              "12. Всё взял");

            Console.Write("Выберите номер товара: ");
            string? b = Console.ReadLine();

            switch (b)
            {
                case "1":
                    if (choco.Colvo == 0)
                    {
                        basket.Things.Add(choco);
                        pfc.Carbohydrates++;
                        choco.Colvo++;
                    }
                    else choco.Colvo++;
                    break;
                case "2":
                    if (chips.Colvo == 0)
                    {
                        basket.Things.Add(chips);
                        pfc.Fats++;
                        chips.Colvo++;
                    }
                    else chips.Colvo++;
                    break;
                case "3":
                    if (cheese.Colvo == 0)
                    {
                        basket.Things.Add(cheese);
                        pfc.Proteins++;
                        cheese.Colvo++;
                    }
                    else cheese.Colvo++;
                    break;
                case "4":
                    if (chicken.Colvo == 0)
                    {
                        basket.Things.Add(chicken);
                        pfc.Proteins++;
                        chicken.Colvo++;
                    }
                    else chicken.Colvo++;
                    break;
                case "5":
                    if (fruit.Colvo == 0)
                    {
                        basket.Things.Add(fruit);
                        pfc.Carbohydrates++;
                        fruit.Colvo++;
                    }
                    else fruit.Colvo++;
                    break;
                case "6":
                    if (oil.Colvo == 0)
                    {
                        basket.Things.Add(oil);
                        pfc.Fats++;
                        oil.Colvo++;
                    }
                    else oil.Colvo++;
                    break;
                case "7":
                    if (DumpMeat.Colvo == 0)
                    {
                        basket.Things.Add(DumpMeat);
                        pfc.Proteins++;
                        DumpMeat.Colvo++;
                    }
                    else DumpMeat.Colvo++;
                    break;
                case "8":
                    if (DumpBerry.Colvo == 0)
                    {
                        basket.Things.Add(DumpBerry);
                        pfc.Carbohydrates++;
                        DumpBerry.Colvo++;
                    }
                    else DumpBerry.Colvo++;
                    break;
                case "9":
                    if (chebu.Colvo == 0)
                    {
                        basket.Things.Add(chebu);
                        pfc.Fats++;
                        chebu.Colvo++;
                    }
                    else chebu.Colvo++;
                    break;
                case "10":
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    for (int i = 0; i < basket.Things.Count; i++)
                    {
                        Console.WriteLine($"{basket.Things[i].Name}: {basket.Things[i].Colvo}шт.");
                    }
                    Console.WriteLine("--------------------------");
                    Console.ReadKey();
                    break;
                case "11":
                    basket.CartBalansing(allFood.Foodstuffs, basket.Things, id.Id, ip.Ip, pfc.Proteins, pfc.Fats, pfc.Carbohydrates);
                    break;
                case "12":
                    all++;
                    break;
            }
        }
        break;

    case "2":
        id.Id = 2;
        Console.Clear();
        Console.WriteLine("Выберете товар из списка: \n");
        Console.WriteLine("1. Снэки\n" +
                          "2. Полезная пища\n" +
                          "3. Полуфабрикаты\n");

        Console.Write("Выберите номер товара: ");
        string? c = Console.ReadLine();

        switch (c)
        {
            case "1":
                ip.Ip = 1;
                while (all == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Выберете товар из списка: \n");
                    Console.WriteLine("1.Шоколадка\n" +
                                      "2. Чипсы\n" +
                                      "3. Сыр балык\n" +
                                      "4. Посмотреть в корзину\n" +
                                      "5. Сбалансировать питание\n" +
                                      "6. Всё взял");

                    Console.Write("Выберите номер товара: ");
                    string? e = Console.ReadLine();

                    switch (e)
                    {
                        case "1":
                            if (choco.Colvo == 0)
                            {
                                basket.Things.Add(choco);
                                pfc.Carbohydrates++;
                                choco.Colvo++;
                            }
                            else choco.Colvo++;
                            break;
                        case "2":
                            if (chips.Colvo == 0)
                            {
                                basket.Things.Add(chips);
                                pfc.Fats++;
                                chips.Colvo++;
                            }
                            else chips.Colvo++;
                            break;
                        case "3":
                            if (cheese.Colvo == 0)
                            {
                                basket.Things.Add(cheese);
                                pfc.Proteins++;
                                cheese.Colvo++;
                            }
                            else cheese.Colvo++;
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("--------------------------");
                            for (int i = 0; i < basket.Things.Count; i++)
                            {
                                Console.WriteLine($"{basket.Things[i].Name}: {basket.Things[i].Colvo}шт.");
                            }
                            Console.WriteLine("--------------------------");
                            Console.ReadKey();
                            break;
                        case "5":
                            basket.CartBalansing(allFood.Foodstuffs, basket.Things, id.Id, ip.Ip, pfc.Proteins, pfc.Fats, pfc.Carbohydrates);
                            break;
                        case "6": all++; break;
                    }
                }
                break;
            case "2":
                ip.Ip = 2;
                while (all == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Выберете товар из списка: \n");
                    Console.WriteLine("1. Куриное филе\n" +
                                      "2. Фрукты\n" +
                                      "3. Оливковое масло\n" +
                                      "4. Посмотреть в корзину\n" +
                                      "5. Сбалансировать питание\n" +
                                      "6. Всё взял");

                    Console.Write("Выберите номер товара: ");
                    string? f = Console.ReadLine();

                    switch (f)
                    {
                        case "1":
                            if (chicken.Colvo == 0)
                            {
                                basket.Things.Add(chicken);
                                pfc.Proteins++;
                                chicken.Colvo++;
                            }
                            else chicken.Colvo++;
                            break;
                        case "2":
                            if (fruit.Colvo == 0)
                            {
                                basket.Things.Add(fruit);
                                pfc.Carbohydrates++;
                                fruit.Colvo++;
                            }
                            else fruit.Colvo++;
                            break;
                        case "3":
                            if (oil.Colvo == 0)
                            {
                                basket.Things.Add(oil);
                                pfc.Fats++;
                                oil.Colvo++;
                            }
                            else oil.Colvo++;
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("--------------------------");
                            for (int i = 0; i < basket.Things.Count; i++)
                            {
                                Console.WriteLine($"{basket.Things[i].Name}: {basket.Things[i].Colvo}шт.");
                            }
                            Console.WriteLine("--------------------------");
                            Console.ReadKey();
                            break;
                        case "5":
                            basket.CartBalansing(allFood.Foodstuffs, basket.Things, id.Id, ip.Ip, pfc.Proteins, pfc.Fats, pfc.Carbohydrates);
                            break;
                        case "6": all++; break;
                    }
                }
                break;
            case "3":
                ip.Ip = 3;
                while (all == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Выберете товар из списка: \n");
                    Console.WriteLine("1. Пельмени мясные\n" +
                                      "2. Пельмени с ягодами\n" +
                                      "3. Чебурек\n" +
                                      "4. Посмотреть в корзину\n" +
                                      "5. Сбалансировать питание\n" +
                                      "6. Всё взял");

                    Console.Write("Выберите номер товара: ");
                    string? g = Console.ReadLine();

                    switch (g)
                    {
                        case "1":
                            if (DumpMeat.Colvo == 0)
                            {
                                basket.Things.Add(DumpMeat);
                                pfc.Proteins++;
                                DumpMeat.Colvo++;
                            }
                            else DumpMeat.Colvo++;
                            break;
                        case "2":
                            if (DumpBerry.Colvo == 0)
                            {
                                basket.Things.Add(DumpBerry);
                                pfc.Carbohydrates++;
                                DumpBerry.Colvo++;
                            }
                            else DumpBerry.Colvo++;
                            break;
                        case "3":
                            if (chebu.Colvo == 0)
                            {
                                basket.Things.Add(chebu);
                                pfc.Fats++;
                                chebu.Colvo++;
                            }
                            else chebu.Colvo++;
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("--------------------------");
                            for (int i = 0; i < basket.Things.Count; i++)
                            {
                                Console.WriteLine($"{basket.Things[i].Name}: {basket.Things[i].Colvo}шт.");
                            }
                            Console.WriteLine("--------------------------");
                            Console.ReadKey();
                            break;
                        case "5":
                            basket.CartBalansing(allFood.Foodstuffs, basket.Things, id.Id, ip.Ip, pfc.Proteins, pfc.Fats, pfc.Carbohydrates);
                            break;
                        case "6":
                            all++;
                            break;
                    }
                }
                break;
        }
        break;
}

