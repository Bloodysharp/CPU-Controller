using CPU_Controller.Pages;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Xml.Linq;

namespace CPU_Controller.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 780;
                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }

        private void ButtonCPU_Click(object sender, RoutedEventArgs e)
        {
            FrameoutputInfo.Navigate(new CPUPage());
        }

        private void ButtonGPU_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonRAM_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonROM_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonBIOS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("shutdown", "/r /fw /t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ButtonRegistryOP_Click(object sender, RoutedEventArgs e)
        {
            //foreach (string subKeyName in key.GetSubKeyNames())
            //{
            //    using (RegistryKey subKey = key.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\"))
            //    {
            //        if (subKey == null)
            //        {
            //            continue; // Пропускаем ключ, если у нас нет доступа к нему
            //        }

            //        Paragraph keyParagraph = parentRange.Paragraphs.Add();
            //        keyParagraph.Range.Text = $"Ключ: {subKeyName}";
            //        keyParagraph.Range.InsertParagraphAfter();

            //        foreach (string valueName in subKey.GetValueNames())
            //        {
            //            object value = subKey.GetValue(valueName);
            //            Paragraph valueParagraph = parentRange.Paragraphs.Add();
            //            valueParagraph.Range.Text = $"\t{valueName}: {value}";
            //            valueParagraph.Range.InsertParagraphAfter();
            //        }

            //        TraverseRegistry(subKey, parentRange); // Рекурсивный обход подключей
            //    }
            //}
        }
        private void ButtonALL_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonContact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
