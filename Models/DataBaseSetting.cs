namespace JournalVersion.Models
{
    public class DataBaseSetting
    {
        public int ID { get; set; }
        public int SolutionID { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseServer { get; set; }
        public string DataBaseSGBD { get; set; }
        public string DatabaseHost { get; set; }
        public string DatabasePWD { get; set; }
        public string DatabaseComment { get; set; }

        public Solution Solution { get; set; }
    }
}