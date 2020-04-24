using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentor.Templates.Animations
{
    /// <summary>
    /// 页面动画类型定义
    /// </summary>
    public enum PageAnimation
    {
        None,
        AnimationSlideInFromLeft,//左侧滑入
        AnimationSlideOutToLeft,//左侧滑出
        AnimationSlideInFromRight,//右侧滑入
        AnimationSlideOutToRight,//右侧滑出
        AnimationFadeIn,//淡入
        AnimationFadeOut//淡出
    }
}
