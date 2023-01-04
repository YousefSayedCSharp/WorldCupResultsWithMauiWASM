using System.Globalization;

namespace WorldCupResultsWithMauiWASM.Converter;

public class DatetiemToEgTime : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return "";

        string strDT = value.ToString();
        string time = "";
        if(!string.IsNullOrEmpty(strDT))
        {
            DateTime dt = DateTime.Parse(strDT);
            //time = dt.ToString("hhh:mm");
            time = TimeOnly.FromDateTime(dt.ToLocalTime())+"";
            time = time.Split(' ')[0];
        }
        return time;
        
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
