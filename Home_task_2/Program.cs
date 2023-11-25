using System.Linq.Expressions;
using Home_task_2;
string? typeHomePet;
string? nameHomePet;


Console.WriteLine("Выберите домашнего питомца (Символ к - Кот или п - Пёс):");
typeHomePet = Console.ReadLine();

Console.WriteLine("Дайте имя домашнему питомцу:");
nameHomePet = Console.ReadLine();

if (nameHomePet == null)
{
    Console.WriteLine("Вы не ввели имя питомца.");
    return;
}

switch (typeHomePet)
{
    case "к":
    case "К":
        {
            Animal choicePet = new Cat(nameHomePet);
            Test(choicePet);
            break;
        }
    case "п":
    case "П":
        {
            Animal choicePet = new Dog(nameHomePet);
            Test(choicePet);
            break;
        }
    default:
        {
            Console.WriteLine("Вы ввели тип животного неверно.");
            return;
        }
}

static void Test(Animal pet)
{
    string? actionForPet;
    while (pet.Health > 0)
    {
        Console.WriteLine();
        Console.WriteLine();
        pet.Say();
        pet.PrintHealth();

        Console.WriteLine("Что сделать с животным наказать(н) или покормить(п)?");
        actionForPet = Console.ReadLine();

        switch (actionForPet)
        {
            case "п":
            case "П":
                {
                    if (pet.Health < 100)
                    {
                        pet.Feed(15);
                    }
                    else
                    {
                        Console.WriteLine("Сейчас рожа треснет от еды, АСТАНАВИСЬ!");
                    }

                    break;
                }
            case "н":
            case "Н":
                {
                    pet.Punish(12);
                    break;
                }
            default:
                {
                    Console.WriteLine("Вы ввели неизвестное действие. Можно ввести только п или н.");
                    return;
                }
        }

    }
    Console.WriteLine();
    // отсылка на мем с Тамагочи
    Console.WriteLine("Он умирал в говне, пока ты спал!");
}