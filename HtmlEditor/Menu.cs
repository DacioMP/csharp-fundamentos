using System;

namespace HtmlEditor
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Yellow;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScreen();
      WriteOptions();
      var option = short.Parse(Console.ReadLine());
      HandleMenuOpt(option);
    }

    public static void DrawScreen()
    {
      DrawColumn();
      DrawLine();
      DrawColumn();
    }

    public static void DrawColumn(int columnLength = 30)
    {
      Console.Write("+");
      for (int i = 0; i < columnLength; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");
    }

    public static void DrawLine(int linesLimit = 12, int columnLimit = 30)
    {
      for (int lines = 0; lines < linesLimit; lines++)
      {
        Console.Write("|");

        for (int i = 0; i < columnLimit; i++)
        {
          Console.Write(" ");
        }
        Console.Write("|");
        Console.Write("\n");
      }
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("HTML Editor");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("====================");
      Console.SetCursorPosition(3, 5);
      Console.WriteLine("Select an option");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - New file");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Open");
      Console.SetCursorPosition(3, 8);
      Console.WriteLine("0 - Exit");
      Console.SetCursorPosition(3, 10);
      Console.Write("Option: ");
    }

    public static void HandleMenuOpt(short opt)
    {
      switch (opt)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Console.Write("Closing editor");
            for (int i = 0; i < 3; i++)
            {
              Console.Write(".");
              Thread.Sleep(1000);
            }
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}