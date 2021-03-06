﻿using System;
using System.Collections.Generic;

namespace Meetings.Domain
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset EndDateTime { get; set; }
        public Room Room { get; set; }
        public User Chair { get; set; }
        public ICollection<User> Invitees { get; set; }
    }
}