namespace TurSys.Web.UI.Extension;

public static class StringExtensions
{
    public static DateTime ConvertTextToDate(this string text, char seperator = '-')
    {
        if (string.IsNullOrEmpty(text))
            return DateTime.MinValue;

        var dateList = text.Split(seperator, StringSplitOptions.RemoveEmptyEntries)?
            .Select(x => Convert.ToInt16(x))?
            .ToList();

        if (dateList?.Count != 3)
            return DateTime.MinValue;

        return new DateTime(dateList[0], dateList[1], dateList[2]);
    }
}
