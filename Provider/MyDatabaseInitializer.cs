using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entity;

namespace Provider
{
    public class MyDatabaseInitializer : CreateDatabaseIfNotExists<SBContext>
    {
        /// <summary>
        /// Bu metot veritabanı olmadığında ve yeninden oluşturulması gerektiğinde,
        /// oluşturulduktan sonra örnek verinin içine eklenmesini sağlar.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(SBContext context)
        {
            Random rnd = new Random();

            #region Insert Sample Users

            string[] users = new string[3] { "Murat Başeren", "Yavuz Selim Bayram", "Bulut Kırca" };

            foreach (string userName in users)
            {
                SBUser user = new SBUser()
                {
                    Name = userName,
                    Role = (Role)Enum.ToObject(typeof(Role), rnd.Next(0, 2))
                };

                context.Users.Add(user);
            }

            context.SaveChanges();

            #endregion

            #region Insert Sample Categories

            string[] categories = new string[4] { "Todo", "InProgress", "Test", "Done" };

            foreach (string cat in categories)
            {
                SBCategory category = new SBCategory()
                {
                    Name = cat
                };

                context.Categories.Add(category);
            }

            context.SaveChanges();

            #endregion

            #region Insert Sample Sprints

            List<SBCategory> catsForSprints = context.Categories.ToList();

            for (int i = 0; i < 5; i++)
            {
                SBSprint sprint = new SBSprint()
                {
                    Name = "Sprint-" + i.ToString(),
                    Deadline = DateTime.Now.AddDays(rnd.Next(-3, 10)),
                    Category = catsForSprints[rnd.Next(0, catsForSprints.Count-1)]
                };

                context.Sprints.Add(sprint);
            }

            context.SaveChanges();

            #endregion

            #region Insert Sample Tasks

            List<SBSprint> sprintsForTasks = context.Sprints.ToList();
            List<SBUser> usersForTasks = context.Users.ToList();

            for (int i = 0; i < 50; i++)
            {
                SBTask task = new SBTask()
                {
                    Name = FakeData.TextData.GetAlphabetical(rnd.Next(10, 140)),
                    CreateTime = DateTime.Now.AddHours(rnd.Next(1, 10)),
                    Descrp = FakeData.TextData.GetAlphabetical(rnd.Next(50, 200)),
                    User = usersForTasks[rnd.Next(0, usersForTasks.Count - 1)],
                    Sprint = sprintsForTasks[rnd.Next(0, sprintsForTasks.Count - 1)]
                };

                context.Tasks.Add(task);
            }

            context.SaveChanges();

            #endregion
        }
    }
}
