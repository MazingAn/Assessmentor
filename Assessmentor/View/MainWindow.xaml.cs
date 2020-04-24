using Assessmentor.Config;
using Assessmentor.Templates;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            ListBoxMainMenu.ItemsSource = MainMenuConfiguration.MainMenuItems;
            ListBoxMainMenu.SelectedIndex = MainMenuConfiguration.DefaultSelectedMenuIndex;
            ListBoxMainMenu.SelectionChanged += ListBoxMainMenuSelectionChanged;
        }

        private void ListBoxMainMenuSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var menuListBox = sender as ListBox;
            var selectedItem = menuListBox.SelectedItem as MainMenuItem;
            MainPageView.Source = new Uri(selectedItem.PagePath, UriKind.Relative);
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

        /// <summary>
        /// 鼠标拖拽移动窗体
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

    }
}
