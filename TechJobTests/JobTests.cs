using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job = new Job();
        Job test_job2 = new Job();
        
        Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job test_job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
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
        //string test_toString = test_job3.ToString();
        public void TestToString()
        {
             
        }
    }
}
