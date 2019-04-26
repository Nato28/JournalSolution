namespace JournalVersion.Models
{
    public class IISSetting
    {
        public int ID { get; set; }
        public int SolutionID { get; set; }
        public string IISHostName { get; set; }
        public string Port { get; set; }
        public string IISComment { get; set; }

        public Solution Solution { get; set; }
    }
}