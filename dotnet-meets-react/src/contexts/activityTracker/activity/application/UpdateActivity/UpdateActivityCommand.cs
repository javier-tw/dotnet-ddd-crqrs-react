﻿using System;
using dotnet_meets_react.src.contexts.activityTracker.activity.application.Shared;
using dotnet_meets_react.src.contexts.activityTracker.activity.domain;
using MediatR;

namespace dotnet_meets_react.src.contexts.activityTracker.activity.application.CreateActivity
{
    public class UpdateActivityCommand : IRequest<Result<Unit>>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
