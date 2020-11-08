using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency): this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

            
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string theString = "";

            theString += "ID:" + Id.ToString();
            theString += "Name:" + Name;

            //leftover categories
            List<string> categories = new List<String>() { "Employer:", "Location", "Position Type", "Core Competency" };
            List<object> objects = new List<object>() {EmployerName, EmployerLocation, JobType, JobCoreCompetency };
            
            int length = categories.Count;
            int count = 0;

            while(count < length )
            {
                theString += categories[count] + ":";
                if (objects[count].ToString() != null)
                {
                    theString += objects[count].ToString();
                }
                else
                {
                    theString += "_____";
                }
                count++;
            }

            

            theString += ""; 
            
            return theString;
        }
    }
}
