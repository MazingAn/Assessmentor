using Assessmentor.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Assessmentor.Converters
{
    /// <summary>
    /// AssessmentStatus 评估状态与显示界面的转换
    /// 将评估状态转换为对应的颜色编码,图标类型,文字信息
    /// </summary>
    class AssessmentStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ConstInfoConvertHelper helper = null;
            switch ((AssessmentStatus)value)
            {
                case AssessmentStatus.DOING:
                    helper = new ConstInfoConvertHelper("#3ad2b1","Run","进行中");
                    break;
                case AssessmentStatus.DONE:
                    helper = new ConstInfoConvertHelper("#49c8fd", "Done", "已完成");
                    break;
                case AssessmentStatus.UNDO:
                    helper = new ConstInfoConvertHelper("#ec6d51", "TimerOff", "未完成");
                    break;
                default:
                    helper = new ConstInfoConvertHelper("gray", "Unknow", "未知");
                    break;
            }
            return helper;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
