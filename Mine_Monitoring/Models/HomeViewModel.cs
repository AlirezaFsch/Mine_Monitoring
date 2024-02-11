using System.Collections.Generic;

namespace Mine_Monitoring.Models
{
    public class HomeViewModel
    {
        public List<string> Years { get; set; }
        public List<double> MiningIndustryData { get; set; }
        public List<double> GDPData { get; set; }
        public List<double> MiningShareOfGDPData { get; set; }
        public List<CountryComparisonData> OtherCountriesComparisonData { get; set; }
    }

    public class CountryComparisonData
    {
        public string CountryName { get; set; }
        public double GDP { get; set; }
        public double MiningIndustryValue { get; set; }
    }
}
