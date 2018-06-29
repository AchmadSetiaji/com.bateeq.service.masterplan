﻿using Com.Bateeq.Service.Masterplan.Lib.ViewModels.Integration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Bateeq.Service.Masterplan.Lib.ViewModels.BlockingPlan
{
    public class BlockingPlanWorkScheduleViewModel
    {
        public bool isConfirmed { get; set; }
        public string RO { get; set; }
        public string Article { get; set; }
        public string Style { get; set; }
        public string Counter { get; set; }
        public int SMV_Sewing { get; set; }
        public UnitViewModel Unit { get; set; }
        public WeeklyPlanViewModel Year { get; set; }
        public WeeklyPlanItemViewModel Week { get; set; }
        public int RemainingEh { get; set; }
        public int? TotalOrder { get; set; }
        public string Remark { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public int Efficiency { get; set; }
        public double EH_Booking { get; set; }
        public double EH_Remaining { get; set; }
    }
}