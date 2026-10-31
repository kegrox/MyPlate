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
        int bolgarianPepperCalories = 20;

        double doughRatio = 0.5;
        double cheeseRatio = 0.3;
        double tomatoRatio = 0.2;
        double pepperoniRatio = 0.2;
        double bolgarianPepperRatio = 0.2;

        double pizzaDoughGram;
        double pizzaCheeseGram;
        double pizzaTomatoGram;
        double pizzaPepperoniGram;
        double pizzaBolgarianPepperGram;
        double cheeseCaloriesInPizza;
        double doughCaloriesInPizza;
        double tomatoCaloriesInPizza;
        double pepperoniCaloriesInPizza;
        double bolgarianPepperCaloriesInPizza;
        double pizzaCalories;
        int pizzaMass;
        string goodbyeMessage = "До встречи! Обращайтесь)";

        while (true)
        {
            Console.WriteLine("Выберите пиццу: ");
            Console.WriteLine("1 — Маргарита");
            Console.WriteLine("2 — Пепперони");
            Console.WriteLine("3 — Овощная");
            Console.WriteLine("––––––––––––");
            Console.WriteLine("-1 — Отмена");

            int pizzaType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес пиццы: ");
            Console.WriteLine("––––––––––––");
            Console.WriteLine("-1 — Отмена");
            if (pizzaType == -1)
            {
                Console.WriteLine(goodbyeMessage);
                break;
            }

            pizzaMass = Convert.ToInt32(Console.ReadLine());
            if (pizzaMass == -1)
            {
                Console.WriteLine(goodbyeMessage);
                break;
            }

            while (pizzaMass < 10)
            {
                Console.WriteLine("Введите массу не меньше 10г.");
                pizzaMass = Convert.ToInt32(Console.ReadLine());
            }

            switch (pizzaType)
            {
                case 1:
                    pizzaDoughGram = pizzaMass * doughRatio;
                    pizzaCheeseGram = pizzaMass * cheeseRatio;
                    pizzaTomatoGram = pizzaMass * tomatoRatio;
                    cheeseCaloriesInPizza = (pizzaCheeseGram / 100 * cheeseCalories);
                    doughCaloriesInPizza = (pizzaDoughGram / 100 * doughCalories);
                    tomatoCaloriesInPizza = (pizzaTomatoGram / 100 * tomatoCalories);
                    pizzaCalories = cheeseCaloriesInPizza + doughCaloriesInPizza + tomatoCaloriesInPizza;
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
                    pizzaDoughGram = pizzaMass * doughRatio;
                    pizzaCheeseGram = pizzaMass * cheeseRatio;
                    pizzaPepperoniGram = pizzaMass * pepperoniRatio;
                    cheeseCaloriesInPizza = (pizzaCheeseGram / 100 * cheeseCalories);
                    doughCaloriesInPizza = (pizzaDoughGram / 100 * doughCalories);
                    pepperoniCaloriesInPizza = (pizzaPepperoniGram / 100 * pepperoniCalories);
                    pizzaCalories = cheeseCaloriesInPizza + doughCaloriesInPizza + pepperoniCaloriesInPizza;
                    Console.Write("Всего калорий в пицце: ");
                    Console.WriteLine(Math.Round(pizzaCalories, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в сыре: ");
                    Console.WriteLine(Math.Round(cheeseCaloriesInPizza, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в тесте: ");
                    Console.WriteLine(Math.Round(doughCaloriesInPizza, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в пепперони: ");
                    Console.WriteLine(Math.Round(pepperoniCaloriesInPizza, MidpointRounding.AwayFromZero));
                    break;
                case 3:
                    pizzaDoughGram = pizzaMass * doughRatio;
                    pizzaCheeseGram = pizzaMass * cheeseRatio;
                    pizzaBolgarianPepperGram = pizzaMass * bolgarianPepperRatio;
                    cheeseCaloriesInPizza = (pizzaCheeseGram / 100 * cheeseCalories);
                    doughCaloriesInPizza = (pizzaDoughGram / 100 * doughCalories);
                    bolgarianPepperCaloriesInPizza = (pizzaBolgarianPepperGram / 100 * bolgarianPepperCalories);
                    pizzaCalories = cheeseCaloriesInPizza + doughCaloriesInPizza + bolgarianPepperCaloriesInPizza;
                    Console.Write("Всего калорий в пицце: ");
                    Console.WriteLine(Math.Round(pizzaCalories, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в сыре: ");
                    Console.WriteLine(Math.Round(cheeseCaloriesInPizza, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в тесте: ");
                    Console.WriteLine(Math.Round(doughCaloriesInPizza, MidpointRounding.AwayFromZero));
                    Console.Write("Всего калорий в болгарском перце: ");
                    Console.WriteLine(Math.Round(bolgarianPepperCaloriesInPizza, MidpointRounding.AwayFromZero));
                    break;
                default:
                    Console.WriteLine("Такой пиццы нет :(");
                    break;
            }

            Console.WriteLine();
        }
    }
}