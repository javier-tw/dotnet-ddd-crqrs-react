﻿using System;
namespace dotnet_meets_react.src.contexts.activityTracker.activity.domain
{
	public class ActivityDTO
	{
		public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string City { get; set; }
		public string Venue { get; set; }
	}
}

