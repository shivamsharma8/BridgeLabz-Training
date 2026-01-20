using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.AIResumeScreening
{
    public class ResumeUtility
    {
        public static void AddRole<T>(Resume<T> res, T role)
            where T : JobRole
        {
            res.Add(role);
        }
    }
}
