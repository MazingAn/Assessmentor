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
    /// AssessmentResult 评估结果与显示界面的转换
    /// 将评结果态转换为对应的颜色编码,图标类型,文字信息
    /// </summary>
    class AssessmentResultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ConstInfoConvertHelper helper = null;
            switch ((AssessmentResult)value)
            {
                case AssessmentResult.PASS:
                    helper = new ConstInfoConvertHelper("#3ad2b1","Like","已通过");
                    break;
                case AssessmentResult.UNPASS:
                    helper = new ConstInfoConvertHelper("#ec6d51", "DisLike", "未通过");
                    break;
                case AssessmentResult.NOTDONE:
                    helper = new ConstInfoConvertHelper("#49c8fd", "TimerOff", "未完成");
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
