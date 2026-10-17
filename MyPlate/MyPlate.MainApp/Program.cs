namespace MyPlate.MainApp;

class Program
{
    static void Main(string[] args)
    {
        // моцарелла, 100г
        int cheeseCalories = 250;
        int doughCalories = 270;
        int pizzaDoughGramm = Convert.ToInt32(Console.ReadLine());
        int pizzaCheeseGramm = Convert.ToInt32(Console.ReadLine());
        int cheeseCaloriesInPizza = (pizzaCheeseGramm / 100 * cheeseCalories);
        int doughCaloriesInPizza = (pizzaDoughGramm / 100 * doughCalories);
        Console.Write("Всего калорий в пицце: ");
        Console.WriteLine(cheeseCaloriesInPizza + doughCaloriesInPizza);
        Console.Write("Всего калорий в сыре: ");
        Console.WriteLine(cheeseCaloriesInPizza);
        Console.Write("Всего калорий в тесте: ");
        Console.WriteLine(doughCaloriesInPizza);

    }
}