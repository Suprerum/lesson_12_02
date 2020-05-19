using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Text;

namespace lesson_12_02
{
    public class Model
    {
        string leftop = ""; 
        string operation = ""; 
        string rightop = "";

        public void CreateTextBlock(object sender, RoutedEventArgs e, MainWindow mainWindow)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            mainWindow.textBlock.Text += s;
            int num;
            bool result = Int32.TryParse(s, out num);
            if (result == true)
            {
                if (operation == "")
                {
                    leftop += s;
                }
                else
                {
                    rightop += s;
                }
            }
            else
            {
                if (s == "=")
                {
                    Update_RightOp();
                    mainWindow.textBlock.Text += rightop;
                    operation = "";
                }
                else if (s == "CLEAR")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    mainWindow.textBlock.Text = "";
                }
                else
                {
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                }
            }
        }
        private void Update_RightOp()
        {
            int num1 = Int32.Parse(leftop);
            int num2 = Int32.Parse(rightop);
            switch (operation)
            {
                case "+":
                    rightop = (num1 + num2).ToString();
                    break;
                case "-":
                    rightop = (num1 - num2).ToString();
                    break;
                case "*":
                    rightop = (num1 * num2).ToString();
                    break;
                case "/":
                    rightop = (num1 / num2).ToString();
                    break;
            }
        }
    }
}
