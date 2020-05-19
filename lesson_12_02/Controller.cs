using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Text;

namespace lesson_12_02
{
    public class Controller
    {
        Model model = null;
        MainWindow mainWindow = null;
        public Controller(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += MainWindow_MyEvent;
        }

        private void MainWindow_MyEvent(object sender, RoutedEventArgs e)
        {
            model.CreateTextBlock(sender, e, mainWindow);
        }
    }
}
