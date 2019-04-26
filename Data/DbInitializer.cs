using JournalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalVersion.Data
{
    public class DbInitializer
    {
        public static void Initialize(JournalContext context)
        {
            context.Database.EnsureCreated();

            if (context.Solutions.Any())
            {
                return;
            }

            var solutions = new Solution[]
            {
                new Solution{SolutionName="CmsU",SolutionType="ASP.NET Framework 4.5 vide",SolutionNote="Umbraco 8 implementation",SolutionComment="Package de connexion AD ne fonctionne pas dessus",SolutionDateStart=DateTime.Parse("2019-03-01"),SolutionDateEnd=DateTime.Parse("2019-03-02")},
                new Solution{SolutionName="CmsU76",SolutionType="ASP.NET Framework 4.5 vide",SolutionNote="Umbraco 7.6 implementation",SolutionComment="Package de connexion AD ne fonctionne pas dessus",SolutionDateStart=DateTime.Parse("2019-03-02"),SolutionDateEnd=DateTime.Parse("2019-03-05")}
            };
            foreach (Solution s in solutions)
            {
                context.Solutions.Add(s);
            }
            context.SaveChanges();

            var iisSettings = new IISSetting[]
            {
                new IISSetting{SolutionID=1,IISHostName="Cms.umbraco.host",Port="8095",IISComment="No comment"},
                new IISSetting{SolutionID=2,IISHostName="Cms.umbraco76.host",Port="8096",IISComment="No comment"},
            };
            foreach (IISSetting i in iisSettings)
            {
                context.IisSettings.Add(i);
            }
            context.SaveChanges();

            var dataBaseSettings = new DataBaseSetting[]
            {
                new DataBaseSetting{SolutionID=1,DatabaseName="UmbracoCms_DB",DatabaseServer="ROWS1135/SQLEXPRESS",DataBaseSGBD="SQLSERVER",DatabaseHost="sa",DatabasePWD="TestSQL1144" },
                new DataBaseSetting{SolutionID=2,DatabaseName="UmbracoCms772_DB",DatabaseServer="ROWS1135/SQLEXPRESS",DataBaseSGBD="ROWS1135/SQLEXPRESS",DatabaseHost="sa",DatabasePWD="TestSQL1144" }
            };
            foreach (DataBaseSetting d in dataBaseSettings)
            {
                context.DataBaseSettings.Add(d);
            }
            context.SaveChanges();

            var userApplicationTests = new UserApplicationTest[]
            {
                new UserApplicationTest{SolutionID=1,UserTestLogin="Toublanc Nathalie",UserTestEmail="nathalietoublanc@cerp-rouen.fr",UserTestPWD="TestUmbraco1144",UserTestComment="Administrateur" },
                new UserApplicationTest{SolutionID=1,UserTestLogin="Natoub",UserTestEmail="nathalie.toublanc@viacesi.fr",UserTestPWD="TestUmbraco2255",UserTestComment="TestRedacteur" },
                new UserApplicationTest{SolutionID=2,UserTestLogin="Toublanc Nathalie",UserTestEmail="nathalietoublanc@cerp-rouen.fr",UserTestPWD="TestUmbraco1144",UserTestComment="Administrateur" }
            };
            foreach (UserApplicationTest u in userApplicationTests)
            {
                context.UserApplicationTests.Add(u);
            }
            context.SaveChanges();
        }
    }
}
