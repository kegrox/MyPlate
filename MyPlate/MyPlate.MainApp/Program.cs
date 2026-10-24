using System.Globalization;

namespace MyPlate.MainApp;

class Program
{
    static void Main(string[] args)
    {
        // моцарелла, 100г
        int cheeseCalories = 250;
        int doughCalories = 270;
        int tomatoCalories = 80;
        int pepperoniCalories = 500;

        Console.WriteLine("Выберите пиццу: ");
        Console.WriteLine("1 — Маргарита");
        Console.WriteLine("2 — Пепперони");
        Console.WriteLine("3 — Овощная");
        
        int pizzaType = Convert.ToInt32(Console.ReadLine());

        switch (pizzaType)
        {
            case 1:
                Console.WriteLine("Введите вес пиццы: "); 
                int pizzaMass = Convert.ToInt32(Console.ReadLine());
                while (pizzaMass < 10)
                {
                    Console.WriteLine("Введите массу не меньше 10г.");
                    pizzaMass = Convert.ToInt32(Console.ReadLine());
                }
                double pizzaDoughGram = pizzaMass * 0.5;
                double pizzaCheeseGram = pizzaMass * 0.3;
                double pizzaTomatoGram = pizzaMass * 0.2;
                double cheeseCaloriesInPizza = (pizzaCheeseGram / 100 * cheeseCalories);
                double doughCaloriesInPizza = (pizzaDoughGram / 100 * doughCalories);
                double tomatoCaloriesInPizza = (pizzaTomatoGram / 100 * tomatoCalories);
                double pizzaCalories = cheeseCaloriesInPizza + doughCaloriesInPizza + tomatoCaloriesInPizza;
                Console.Write("Всего калорий в пицце: ");
                Console.WriteLine(Math.Round(pizzaCalories, MidpointRounding.AwayFromZero));
                Console.Write("Всего калорий в сыре: ");
                Console.WriteLine(Math.Round(cheeseCaloriesInPizza, MidpointRounding.AwayFromZero));
                Console.Write("Всего калорий в тесте: ");
                Console.WriteLine(Math.Round(doughCaloriesInPizza, MidpointRounding.AwayFromZero));
                Console.Write("Всего калорий в томатной пасте: ");
                Console.WriteLine(Math.Round(tomatoCaloriesInPizza, MidpointRounding.AwayFromZero));
                break;
            case 2:
            case 3:
                Console.WriteLine("Система к такому не готовилась (пока)");
                break;
            default:
                Console.WriteLine("Такой пиццы нет :(");
            break;
        }
    }
}