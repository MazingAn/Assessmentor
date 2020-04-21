using Assessmentor.Config;
using System.Windows;

namespace Assessmentor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainMenu_Bind();
        }

        /// <summary>
        /// 菜单的绑定
        /// </summary>
        private void MainMenu_Bind()
        {
            ListBoxMainMenu.ItemsSource = MainMenuConfiguration.MAIN_MENU_ITEMS;
        }

        /// <summary>
        /// 最小化程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinWindowClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 最大或最小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMaxWindowClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseWindowClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
