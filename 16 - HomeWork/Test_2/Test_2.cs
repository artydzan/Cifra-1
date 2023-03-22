namespace Test_2
{
    internal class Test_2
    {
        static void Main(string[] args)
        {
            // Написать программу по определению категории числа.
            // То есть вводим чмсло, а программа отвечает
            // 15 - целое число
            // 123фыв - Неудалось определить число
            // -12 - Целое отрицательно число
            // 123.45 - Вещественное число

            // Требования к коду:
            // * Задача должна быть решена на сложных if ветвлениях
            // То есть в одном условии должен получиться полностью ответ.
            // if (условие_1) && (условие_2) то вывести "Целое положительное число.
            // * Все вычесления должны быть выполнены в функцияхd

            byte _counter = 0;
            Console.Write("Введите число: ");
            string _line = Console.ReadLine();
            _line = boolNumber();



            bool boolNumber()
            {
                byte result;
                int resultInt;
                float resultFloat;

                bool booltInt = Int32.TryParse(_line, out resultInt);
                bool boolFloat = Single.TryParse(_line, out resultFloat);

                if (booltInt != false && resultInt >= 0)
                {
                    return result = 1;
                }
                else if (booltInt != false && resultInt < 0)
                {
                    return result = 2;
                }
                else if (boolFloat != false && resultFloat > 0)
                {
                    return result = 3;
                }
                else if (boolFloat != false && resultFloat < 0)
                {
                    return result = 4;
                }

                return result = 0;
            }
            string boolResult()
            {
                if (_counter == 1)
                {
                    _line = _line + " - Целое положительное число.";
                }
                else if (_counter == 2)
                {
                    _line = _line + " - Целое отрицательное число.";
                }
                else if (_counter == 3)
                {
                    _line = _line + "- Вещественное положительное число.";
                }
                else if (_counter == 4)
                {
                    _line = _line + " - Вещественное отрицательное число.";
                }
            }
            void badExit()
            {
                Console.WriteLine("Не удалось определить число! \n\nНажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}