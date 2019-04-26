using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalVersion.Models
{
    public class Solution
    {
        public int ID { get; set; }
        public string SolutionName { get; set; }

        // Quel framework est utilisé
        public string SolutionType { get; set; }
        public string SolutionComment { get; set; }

        // Quels manips ont été faites dessus
        public string SolutionNote { get; set; }
        public DateTime SolutionDateStart { get; set; }
        public DateTime SolutionDateEnd { get; set; }

        public virtual ICollection<IISSetting> IISSettings { get; set; }
        public virtual ICollection<DataBaseSetting> DataBaseSettings { get; set; }
        public virtual ICollection<UserApplicationTest> UserApplicationTests { get; set; }
    }
}
