using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._companyName = "Netflex";
        job1._startDate = "12/05/2020";
        job1._endDate = "11/011/2022";
       

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._companyName = "Google";
        job2._startDate = "21/03/2022";
        job2._endDate = "03/06/2024";
        

        Resume myResume = new Resume();
        myResume._name = "Charles Ironbar";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}