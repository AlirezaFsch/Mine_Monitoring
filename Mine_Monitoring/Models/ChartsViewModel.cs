namespace Mine_Monitoring.Models
{
    public class ChartsViewModel
    {
        public List<string> Provinces { get; set; }
        public List<int> MineCounts { get; set; }
        public List<string> MineStatus { get; set; }
        public List<int> MineStatusCounts { get; set; }
        public List<string> Years { get; set; }
        public List<int> ProductionOverYears { get; set; }
        public List<MineralProductionData> MineralProduction { get; set; }
    }
    public class MineralProductionData
    {
        public string Name { get; set; }
        public List<int> Production { get; set; }
        public string Color { get; set; }
    }
}
