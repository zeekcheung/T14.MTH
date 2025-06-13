using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace T14.MTH.DataGenerator.Desktop.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开 Github 仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenGithub_OnClick(object? sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/zeekcheung/T14.MTH")
                {
                    // 使用默认浏览器打开
                    UseShellExecute = true
                });
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// 切换窗口全屏状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ButtonFullScreenWindow_OnClick(object? sender, RoutedEventArgs e)
        {
            ToggleWindowFullScreen(sender, e);
        }

        /// <summary>
        /// 最小化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimizeWindow_OnClick(object? sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 最大化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMaximizeWindow_OnClick(object? sender, RoutedEventArgs e)
        {
            ToggleWindowMaximized(sender, e);
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseWindow_OnClick(object? sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 双击标题栏切换窗口最大化状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar_OnDoubleTapped(object? sender, TappedEventArgs e)
        {
            ToggleWindowMaximized(sender, e);
        }

        /// <summary>
        /// 窗口拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            BeginMoveDrag(e);
        }

        /// <summary>
        /// 切换窗口全屏状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleWindowFullScreen(object? sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Normal ?  WindowState.FullScreen : WindowState.Normal;
        }

        /// <summary>
        /// 切换窗口最大化状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleWindowMaximized(object? sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
    }
}