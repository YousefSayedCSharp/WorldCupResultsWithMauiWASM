using System.Globalization;

namespace WorldCupResultsWithMauiWASM.Converter;

public class ConvertCountryToArabic : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return "";

        string country = value+"";
        string ToArabicCountry = country;

        // G1 1
        if (country == "NED" || country == "Netherlands")
            ToArabicCountry = "هولندا ";
        // G1 2
        else if (country == "SEN" || country == "Senegal")
            ToArabicCountry = "السنغال ";
        // G1 3
        else if (country == "ECU" || country == "Ecuador")
            ToArabicCountry = "الإكوادور";
        // G1 4
        else if (country == "QAT" || country == "Qatar")
            ToArabicCountry = "قطر ";
        // G2 1
        else if (country == "ENG" || country == "England")
            ToArabicCountry = "إنجلترا ";
        // G2 2
        else if (country == "USA" || country == "United States")
            ToArabicCountry = "أمريكا";
        // G2 3
        else if (country == "IRN" || country == "Iran")
            ToArabicCountry = "إيران ";
        // G2 4
        else if (country == "WAL" || country == "Wales")
            ToArabicCountry = "ويلز ";
        // G3 1
        else if (country == "ARG" || country == "Argentina")
            ToArabicCountry = "الأرجنتين ";
        // G3 2
        else if (country == "POL" || country == "Poland")
            ToArabicCountry = "بولندا ";
        // G3 3
        else if (country == "MEX" || country == "Mexico")
            ToArabicCountry = "المكسيك ";
        // G3 4
        else if (country == "KSA" || country == "Saudi Arabia")
            ToArabicCountry = "السعوديا";
        // G4 1
        else if (country == "FRA" || country == "France")
            ToArabicCountry = "فرنسا ";
        // G4 2
        else if (country == "AUS" || country == "Australia")
            ToArabicCountry = "أستراليا ";
        // G4 3
        else if (country == "TUN" || country == "Tunisia")
            ToArabicCountry = "تونس ";
        // G4 4
        else if (country == "DEN" || country == "Denmark")
            ToArabicCountry = "الدنمارك";
        // G5 1
        else if (country == "JPN" || country == "Japan")
            ToArabicCountry = "اليابان";
        // G5 2
        else if (country == "ESP" || country == "Spain")
            ToArabicCountry = "إسبانيا";
        // G5 3
        else if (country == "GER" || country == "Germany")
            ToArabicCountry = "ألمانيا";
        // G5 4
        else if (country == "CRC" || country == "Costa Rica")
            ToArabicCountry = "كوستاريكا";
        // G6 1
        else if (country == "MAR" || country == "Morocco")
            ToArabicCountry = "المغرب";
        // G6 2
        else if (country == "CRO" || country == "Croatia")
            ToArabicCountry = "كرواتيا";
        // G6 3
        else if (country == "BEL" || country == "Belgium")
            ToArabicCountry = "بلجيكا";
        // G6 4
        else if (country == "CAN" || country == "Canada")
            ToArabicCountry = "كندا";
        // G7 1
        else if (country == "BRA" || country == "Brazil")
            ToArabicCountry = "البرازيل";
        // G7 2
        else if (country == "SUI" || country == "Switzerland")
            ToArabicCountry = "سويسرا";
        // G7 3
        else if (country == "CMR" || country == "Cameroon")
            ToArabicCountry = "الكاميرون";
        // G7 4
        else if (country == "SRB" || country == "Serbia")
            ToArabicCountry = "صربيا";
        // G8 1
        else if (country == "POR" || country == "Portugal")
            ToArabicCountry = "البرتغال";
        // G8 2
        else if (country == "GHA" || country == "Ghana")
            ToArabicCountry = "غانا";
        // G8 3
        else if (country == "KOR" || country == "South Korea")
            ToArabicCountry = "كوريا الجنوبية";
        // G8 4
        else if (country == "URU" || country == "Uruguay")
            ToArabicCountry = "أوروغواي";

        return ToArabicCountry;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}
