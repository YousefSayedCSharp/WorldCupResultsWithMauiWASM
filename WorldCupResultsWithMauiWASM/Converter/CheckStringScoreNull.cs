using System.Globalization;

namespace WorldCupResultsWithMauiWASM.Converter;

public class CheckStringScoreNull : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return "-";

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
