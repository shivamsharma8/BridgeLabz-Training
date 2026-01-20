using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AIResumeScreening
{
    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer(string name, int exp)
            : base(name, exp)
        {
        }

        public override void Check()
        {
            Console.WriteLine($"Software Engineer: {name}, Exp: {exp} yrs");
        }
    }
}
