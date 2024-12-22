using System;
using System.Text;

namespace HtmlEditor
{
  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkGray;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("EDIT MODE");
      Console.WriteLine("---------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("---------");
      Console.WriteLine("Save file?");
      Viewer.Show(file.ToString());
    }
  }
}