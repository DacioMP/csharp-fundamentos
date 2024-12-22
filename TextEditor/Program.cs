using System;
using Microsoft.VisualBasic;

namespace TextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      MyTextEditor();
    }

    static void MyTextEditor()
    {
      Console.Clear();
      Console.WriteLine("What would you like to do ?");
      Console.WriteLine("1 - Open file");
      Console.WriteLine("2 - Create file");
      Console.WriteLine("0 - Exit");
      short opt = short.Parse(Console.ReadLine());

      switch (opt)
      {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Create(); break;
        default: MyTextEditor(); break;
      }
    }

    static void Open()
    {
      Console.Clear();
      Console.WriteLine("Type the file path");
      string path = Console.ReadLine();

      using (var file = new StreamReader(path))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
      }

      Console.WriteLine();
      Console.ReadLine();
      MyTextEditor();
    }

    static void Create()
    {
      Console.Clear();
      Console.WriteLine("Enter your text below (ESC to exit)");
      Console.WriteLine("-------------------------");
      string text = "";
      ConsoleKeyInfo cki;
      string newStr = "";

      do
      {
        text += newStr + Console.ReadLine();
        text += Environment.NewLine;
        cki = Console.ReadKey();
        newStr = cki.Key.ToString();
      }
      while (cki.Key != ConsoleKey.Escape);

      Save(text);
    }

    static void Save(string text)
    {
      Console.Clear();
      Console.WriteLine("Type the file path");
      var path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"File {path} saved successfully");
      Console.ReadLine();
      MyTextEditor();
    }
  }
}
