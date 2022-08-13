class Program
{
    static void Main(string[] args)
    {
        //Task1

        Console.WriteLine("Enter any number and press ENTER");

        string input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal number))
        {
            if(number > 7)
            {
            Console.WriteLine($"Hello, your number {number} more than 7");
            }
            else
            {
                Console.WriteLine($"Your number {number} not more than 7");
            }
        }

        else
            Console.WriteLine("Вам же сказали: ввести ЧИСЛО!");

        //Task2

        Console.WriteLine("Введите ваше имя");
        string ourName = "Вячеслав";
        string name = Console.ReadLine();

        if (ourName != name)
            Console.WriteLine("Нет такого имени");
        else
            Console.WriteLine("Привет, Вячеслав");

        //Task3

        int[] array = new int[10];
        int i = 0;
        string value;

        Console.WriteLine("Введите 10 чисел через Enter");

        do
        {
            try
            {
                value = Console.ReadLine();

                {
                    array[i] = Convert.ToInt32(value);
                    i++;
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("Только числа!");
            }
          
        }while(i < array.Length);

        Console.WriteLine("Из списка ваших чисел кратны 3 --> ");
        for(int j = 0; j < array.Length; j++)
        {
            if(array[j] % 3 == 0)
            {
                Console.WriteLine(array[j]);
            }
        }

        //Task4

        Console.WriteLine("[((())()(())]] является неверной, не хватает закрывающей ')' перед ']' и вначале '[' ");
        Console.ReadLine();

    }
}




