namespace Home_task_4;

class Program
{
    static void Main(string[] args)
    {
        // Вначале были животные
        Monkey monkey = new Monkey(0) { LvlKind = 10 };
        Rabbit rabbit = new Rabbit(23) { LvlKind = 100 };
        Wolf wolf = new Wolf(72) { WhatIsEating = "Зайцы, мелкие грызуны" };
        Tiger tiger = new Tiger(56) { WhatIsEating = "Туристы, крупные грызуны, козлы" };

        // Потом человек придумал зоопарк Nazareth
        Zoo zoo = new Zoo();

        // И наполнил он свой зоопарк разными техническими штуками
        Table table = new Table("Хайтек стол");
        Computer computer = new Computer("IMac ver.2019");
        zoo.Add(table);
        zoo.Add(computer);

        // И начал человек этих животных ловить и пленить в своём зоопарке
        // Но от обезьяны лишь труп доехал до берегов большой Земли
        zoo.Add(monkey);
        zoo.Add(rabbit);
        zoo.Add(wolf);
        zoo.Add(tiger);

        // Но понял человек, что Волк - это свободное животное и может оно жить только на свободе
        // И выпустил человек Волка из зоопарка и стал Волк свободен
        zoo.Remove(wolf);

        // Но кара настигла того, кто хотел приручить Волка
        zoo.BadRain();

    }

}
