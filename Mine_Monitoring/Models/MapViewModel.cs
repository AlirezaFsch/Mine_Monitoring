namespace Mine_Monitoring.Models
{
    public class MapViewModel
    {
        public List<ProvinceViewModel> Provinces { get; set; }
    }

    public class ProvinceViewModel
    {
        public string Name { get; set; }
        public int MineCount { get; set; }
        //public List<List<double>> Coordinates { get; set; }
    }

}
