﻿using System;
using dotnet_meets_react.src.contexts.activityTracker.activity.application.CreateActivity;
using dotnet_meets_react.src.contexts.activityTracker.activity.domain;
using Microsoft.EntityFrameworkCore;

namespace dotnet_meets_react.src.contexts.activityTracker.activity.infraestructure
{
    public class DataContext : DbContext
    { 

        public DataContext(DbContextOptions options) : base(options) {}

        public DbSet<ActivityDTO> Activities { get; set; }
    }
}
