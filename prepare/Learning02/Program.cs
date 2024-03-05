using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._company = "Wildhorn";
       job1._endYear = 2024;
       job1._jobTitle = "Data Analyst";
       job1._startYear = 2019;
       

       Job job2 = new Job();
       job2._company = "SouthWorks";
       job2._endYear = 2022;
       job2._jobTitle = "Architect";
       job2._startYear = 2000;
      

       Resume resume1 = new Resume();
       resume1._name = "Virginia Haedo";
       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);
      
      resume1.DisplayResumeDetails();
      
    }
}