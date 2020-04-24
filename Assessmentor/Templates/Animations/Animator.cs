using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Assessmentor.Templates.Animations
{
    class Animator
    {
        /// <summary>
        /// 控件从左往右滑入
        /// </summary>
        /// <param name="control"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static async Task SlideFromLeft(Page page, float duration)
        {
            page.Visibility = Visibility.Collapsed;
            var slideAnimation = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(duration),
                From = new Thickness(-page.Width,0, 0, 0),
                To = new Thickness(0),
            };
            page.BeginAnimation(Page.MarginProperty, slideAnimation);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(duration * 1000));
        }

        /// <summary>
        /// 淡入动画 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static async Task FadeIn(Page page, float duration)
        {
            page.Visibility = Visibility.Collapsed;
            var animation = new DoubleAnimation
            {
                Duration = TimeSpan.FromSeconds(duration),
                From = 0,
                To = 1,
            };
            page.BeginAnimation(Page.OpacityProperty, animation);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(duration * 1000));
        }

        /// <summary>
        /// 淡出动画
        /// </summary>
        /// <param name="page"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static async Task FadeOut(Page page, float duration)
        {
            page.Visibility = Visibility.Collapsed;
            var animation = new DoubleAnimation
            {
                Duration = TimeSpan.FromSeconds(duration),
                From = 1,
                To = 0,
            };
            page.BeginAnimation(Page.OpacityProperty, animation);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(duration * 1000));
        }
    }
}
