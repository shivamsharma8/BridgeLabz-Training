using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AIResumeScreening
{
    public abstract class JobRole
    {
        protected string name;
        protected int exp;
        public JobRole(string name, int exp)
        {
            this.name = name;
            this.exp = exp;
        }
        public abstract void Check();
    }
}
