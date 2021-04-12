using System;
using System.Globalization;
using System.Windows.Data;
using ToyMvvm.Model;

namespace ToyMvvm.Converters
{
    public class FormulaPrettyViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Formula formula)
            {
                return $"{formula.A}X^2 + {formula.B}X + {formula.C}";
            }

            return "???";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
