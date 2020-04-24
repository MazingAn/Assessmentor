using Assessmentor.Templates.Animations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assessmentor.Templates
{
    public class AnimatedPage : Page
    {
        /// <summary>
        /// 页面加载动画
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.AnimationFadeIn;

        /// <summary>
        /// 页面离开动画
        /// </summary>
        public PageAnimation PageUnLoadAnimation { get; set; } = PageAnimation.AnimationFadeOut;

        public float AnimateDuration { get; set; } = 0.8f;

        /// <summary>
        /// 构造函数：加载时执行加载动画
        /// </summary>
        public AnimatedPage()
        {
            Loaded += AnimatedPageLoaded;
        }

        /// <summary>
        /// 页面加载执行进入动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimatedPageLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            AnimateIn();
        }

        public async void AnimateIn()
        {
            switch (PageLoadAnimation)
            {
                case PageAnimation.AnimationFadeIn:
                    await Animator.FadeIn(this, this.AnimateDuration);
                    break;
            }
        }

        public async void AnimateOut()
        {
            switch (PageUnLoadAnimation)
            {
                case PageAnimation.AnimationFadeOut:
                    await Animator.FadeOut(this, this.AnimateDuration);
                    break;
            }
        }
       

    }
}
