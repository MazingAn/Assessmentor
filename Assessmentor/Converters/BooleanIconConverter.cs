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
    /// Boolean类型在前端显示的转换
    /// </summary>
    class BooleanIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return new ConstInfoConvertHelper("#3ad2b1", "Check", "是");
            }
            else
            {
                return new ConstInfoConvertHelper("#ec6d51", "Clear", "否");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
