using System.Windows;
using System.Windows.Input;

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
    }
}
