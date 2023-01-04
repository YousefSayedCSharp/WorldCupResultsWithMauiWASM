using System.Globalization;

namespace WorldCupResultsWithMauiWASM.Converter;

public class StringToString : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return "";

        string group = value.ToString().Replace("_", " ");
        return group.Replace("GROUP","مجموعة"); ;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
