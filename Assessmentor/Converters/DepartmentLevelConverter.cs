using Assessmentor.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

/// <summary>
/// 
/// </summary>
namespace Assessmentor.Converters
{
    class DepartmentLevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ConstInfoConvertHelper helper = null;
            switch ((DepartmentLevel)value)
            {
                case DepartmentLevel.ARMY:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "空军");
                    break;
                case DepartmentLevel.DIVISION:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "师");
                    break;
                case DepartmentLevel.BRIGADE:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "旅");
                    break;
                case DepartmentLevel.REGIMENT:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "团");
                    break;
                case DepartmentLevel.BATTALIONS:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "营");
                    break;
                case DepartmentLevel.COMPANY:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "连");
                    break;
                case DepartmentLevel.PLANTOON:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "排");
                    break;
                case DepartmentLevel.CLASS:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "班");
                    break;
                default:
                    helper = new ConstInfoConvertHelper("#3ad2b1", "", "未知");
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
