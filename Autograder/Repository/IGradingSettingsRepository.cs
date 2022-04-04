using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autograder.Repository
{
    public interface IGradingSettingsRepository
    {
        public int RunningScore { get; }
        public int TotalAccuracy { get; }
        public int SubmissionScore { get; }
    }
}
