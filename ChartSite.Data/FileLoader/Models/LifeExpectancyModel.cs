using FileHelpers;

namespace ChartSite.Data.FileLoader.Models
{
    [IgnoreFirst]
    [DelimitedRecord(";")]
    public class LifeExpectancyModel
    {
        public string Country;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year1980;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year1985;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year1990;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2000;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2005;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2006;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2007;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2008;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2009;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2010;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2011;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2012;
        [FieldConverter(ConverterKind.Double, ",")]
        public double? Year2013;

        public double?[] GetYearsArray()
        {
            return new[] { Year1980, Year1985, Year1990, Year2000, Year2005, Year2006, Year2007, Year2008, Year2009, Year2010, Year2011, Year2012, Year2013 };
        }
    }
}