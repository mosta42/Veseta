﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veseta.Core.entites
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public string Time { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
