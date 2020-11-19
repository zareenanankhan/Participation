using System;

namespace ClassesTextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Textbox MyTextbox = new Textbox();
            MyTextbox.Padding = 50;
            MyTextbox.Text = "I NEED SLEEP";
            MyTextbox.BackColor = ConsoleColor.White;
            MyTextbox.ForeColor = ConsoleColor.Black;

            MyTextbox.DisplayText();

            //Console.ReadKey();
        }
    }
}
