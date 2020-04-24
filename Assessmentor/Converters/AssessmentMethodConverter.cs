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
    /// DepartmentLevel 单位级别与显示界面的转换
    /// 将单位级别转换为对应的颜色编码,图标类型,文字信息
    /// </summary>
    class AssessmentMethodConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ConstInfoConvertHelper helper = null;
            switch ((AssessmentMethod)value)
            {
                case AssessmentMethod.ALONY_AND_ONECE:
                    helper = new ConstInfoConvertHelper("#49c8fd", "Walk", "单独组织一次性评估");
                    break;
                case AssessmentMethod.BASED_AND_JOINED:
                    helper = new ConstInfoConvertHelper("#49c8fd", "Walk", "依托基地融入式评估");
                    break;
                case AssessmentMethod.LAYERED_AND_SPLITED:
                    helper = new ConstInfoConvertHelper("#49c8fd", "Walk", "区分层次分阶段评估");
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
