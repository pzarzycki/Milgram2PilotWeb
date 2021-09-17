using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Milgram2PilotWeb
{
    public class SurveyDbContext : DbContext
    {
        public DbSet<SurveyResponse> Responses { get; set; }

        public string DbPath { get; private set; }

        public SurveyDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class SurveyResponse
    {
        public int SurveyResponseId { get; set; }
        public DateTime ResponseTime { get; set; }

        public string ResponseJson { get; set; }
    }

}