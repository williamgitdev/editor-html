using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("============");
            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }
    }
}