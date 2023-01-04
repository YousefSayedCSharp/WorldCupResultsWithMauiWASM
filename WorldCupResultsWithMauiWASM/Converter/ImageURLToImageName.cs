using System.Globalization;

namespace WorldCupResultsWithMauiWASM.Converter;

public class ImageURLToImageName : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return "";

        if (value.ToString() == "https://crests.football-data.org/8601.svg")
            return "ned";
        else if (value.ToString() == "https://crests.football-data.org/791.svg")
            return "ecu";
        else if (value.ToString() == "https://crests.football-data.org/senegal.svg")
            return "sen";
        else if (value.ToString() == "https://crests.football-data.org/8030.svg")
            return "qat";
        else if (value.ToString() == "https://crests.football-data.org/770.svg")
            return "eng";
        else if (value.ToString() == "https://crests.football-data.org/iran.svg")
            return "irn";
        else if (value.ToString() == "https://crests.football-data.org/833.svg")
            return "wal";
        else if (value.ToString() == "https://crests.football-data.org/usa.svg")
            return value.ToString();
        else if (value.ToString() == "https://crests.football-data.org/794.svg")
            return "pol";
        else if (value.ToString() == "https://crests.football-data.org/saudi_arabia.svg")
            return "ksa";
        else if (value.ToString() == "https://crests.football-data.org/769.svg")
            return "mex";
        else if (value.ToString() == "https://crests.football-data.org/773.svg")
            return "fra";
        else if (value.ToString() == "https://crests.football-data.org/779.svg")
            return "aus";
        else if (value.ToString() == "https://crests.football-data.org/782.svg")
            return "den";
        else if (value.ToString() == "https://crests.football-data.org/tunisia.svg")
            return "tun";
        else if (value.ToString() == "https://crests.football-data.org/760.svg")
            return "esp";
        else if (value.ToString() == "https://crests.football-data.org/766.svg")
            return "gpn";
        else if (value.ToString() == "https://crests.football-data.org/759.svg")
            return "jer";
        else if (value.ToString() == "https://crests.football-data.org/costa_rica.svg")
            return "crc";
        else
            return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}

