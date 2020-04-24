using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentor.Converters
{
    /// <summary>
    /// 把一个常用的表示状态的类型转换为界面元素是经常用到的三个样式的集合
    /// </summary>
    class ConstInfoConvertHelper
    {

        public string Color { get; set; }
        public string Icon { get; set; }
        public string Word { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="color">颜色</param>
        /// <param name="icon">materialDesign图标Kind</param>
        /// <param name="word">更贴切的文字描述信息</param>
        public ConstInfoConvertHelper(string color, string icon, string word)
        {
            Color = color;
            Icon = icon;
            Word = word;
        }
    }
}
