using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

using System.Collections.Generic;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job = new Job();
        Job test_job2 = new Job();
        
        Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job test_job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        List<string> test_List = new List<string>() { "ID", "Name", "Employer", "Location", "Position Type", "Core Competency" };

        [TestMethod]
        public void TestSettingJobId()
        {
            

            //if (Assert.AreEqual(test_job.Id, test_job2.Id))
            if (test_job.Id.Equals(test_job2.Id)) 
            {
                throw new System.ArgumentException("Same id exists");
            }

            Assert.AreNotEqual(test_job.Id, test_job2.Id, 1);
           
        }
         
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.AreNotEqual("", test_job3.Id);
            Assert.AreNotEqual("", test_job3.Name);
            Assert.AreNotEqual("", test_job3.EmployerName);
            Assert.AreNotEqual("", test_job3.JobType);
            Assert.AreNotEqual("", test_job3.JobCoreCompetency);
            

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(test_job3, test_job4);
        }

        
        [TestMethod]
        
        public void TestToString()
        {
            
            Assert.Equals(test_job3.ToString()[0], test_job3.ToString()[test_job3.ToString().Length - 1]); //#1

            //#2
            bool missing = false; //amount of categories
            foreach(string name in test_List)
            {
                if(!test_job3.ToString().Contains(name)){
                    missing = true;
                }//checking if a tag is missing
            }
            Assert.Equals(false, missing);

            int n_count = 0;
            foreach(char letter in test_job3.ToString())
            {
                if(letter == '\n')
                {
                    n_count++;
                }
            }
            Assert.Equals(6, n_count); //expecting 6 spaces to make each have own line
            

            //#3
            if (test_job3.ToString().Contains("_____"))
            {
                Assert.IsTrue(test_job3.ToString().Contains("Data not available"));
            }
        }
    }
}
