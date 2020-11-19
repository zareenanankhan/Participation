using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesTextBox
{
    class Textbox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public Textbox()
        {
            Padding = 50;
            BackColor = ConsoleColor.White;
            ForeColor = ConsoleColor.Black;
            Text = "";

        }

        public void DisplayText()
        {
            //int pad = 50;
            //Text = "insert random text here";
            Text = Text.PadLeft(Text.Length+Padding, ' ');
            Text = Text.PadRight(Text.Length+Padding, ' ');

            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            Console.WriteLine(Text);

        }
    }

}
