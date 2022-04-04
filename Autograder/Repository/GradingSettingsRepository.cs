using Autograder.Repository;
using Microsoft.Extensions.Configuration;
using System;

namespace Autograder.Models
{
    public class GradingSettingsRepository : IGradingSettingsRepository
    {
        private readonly IConfiguration _configuration;
        public GradingSettingsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int RunningScore => int.Parse(_configuration.GetSection("GradingSettings.RunningScore").Value);

        public int TotalAccuracy => int.Parse(_configuration.GetSection("GradingSettings.TotalAccuracy").Value);

        public int SubmissionScore => int.Parse(_configuration.GetSection("GradingSettings.SubmissionScore").Value);
    }
}
