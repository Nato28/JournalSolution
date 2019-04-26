namespace JournalVersion.Models
{
    public class UserApplicationTest
    {
        public int ID { get; set; }
        public int SolutionID { get; set; }
        public string UserTestLogin { get; set; }
        public string UserTestEmail { get; set; }
        public string UserTestPWD { get; set; }
        public string UserTestComment { get; set; }

        public Solution Solution { get; set; }
    }
}