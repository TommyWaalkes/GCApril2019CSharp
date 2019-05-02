using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MockAssessment2
{
    public class MockAssessmentTests
    {
        [Fact]
        public void Test1_Tasks()
        {
            //The whole project relies on tasks being here
            List<string> tasks = new List<string>() { "get a haircut", "walk the trash", "clean up the dog", "cheat on my taxes", "put down Spartacus' slave rebellion with swift and extreme prejudice"};
            Program.tasks.Clear();
            Program.tasks = tasks;

            Assert.Equal(tasks, Program.tasks);
        }

        [Fact]
        public void Test2_AddTasks()
        {
            Program.tasks.Clear();
            List<string> tasks = new List<string>() { "get a haircut", "walk the trash", "clean up the dog", "cheat on my taxes", "put down Spartacus' slave rebellion with swift and extreme prejudice" };

             

            Program.AddTask("sketchy stuff");
            tasks.Add("sketchy stuff");
            Assert.Equal(tasks.Count, Program.tasks.Count);
            for (int i = 0; i < Program.tasks.Count; i++)
            {
                Assert.Equal(tasks[i], Program.tasks[i]);
            }
        }
    }
}
