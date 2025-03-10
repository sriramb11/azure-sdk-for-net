// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The V2 policy schedule for IaaS that supports hourly backups. </summary>
    public partial class SimpleSchedulePolicyV2 : BackupSchedulePolicy
    {
        /// <summary> Initializes a new instance of SimpleSchedulePolicyV2. </summary>
        public SimpleSchedulePolicyV2()
        {
            SchedulePolicyType = "SimpleSchedulePolicyV2";
        }

        /// <summary> Initializes a new instance of SimpleSchedulePolicyV2. </summary>
        /// <param name="schedulePolicyType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="scheduleRunFrequency"> Frequency of the schedule operation of this policy. </param>
        /// <param name="hourlySchedule"> hourly schedule of this policy. </param>
        /// <param name="dailySchedule"> Daily schedule of this policy. </param>
        /// <param name="weeklySchedule"> Weekly schedule of this policy. </param>
        internal SimpleSchedulePolicyV2(string schedulePolicyType, ScheduleRunType? scheduleRunFrequency, BackupHourlySchedule hourlySchedule, BackupDailySchedule dailySchedule, BackupWeeklySchedule weeklySchedule) : base(schedulePolicyType)
        {
            ScheduleRunFrequency = scheduleRunFrequency;
            HourlySchedule = hourlySchedule;
            DailySchedule = dailySchedule;
            WeeklySchedule = weeklySchedule;
            SchedulePolicyType = schedulePolicyType ?? "SimpleSchedulePolicyV2";
        }

        /// <summary> Frequency of the schedule operation of this policy. </summary>
        public ScheduleRunType? ScheduleRunFrequency { get; set; }
        /// <summary> hourly schedule of this policy. </summary>
        public BackupHourlySchedule HourlySchedule { get; set; }
        /// <summary> Daily schedule of this policy. </summary>
        internal BackupDailySchedule DailySchedule { get; set; }
        /// <summary> List of times of day this schedule has to be run. </summary>
        public IList<DateTimeOffset> ScheduleRunTimes
        {
            get
            {
                if (DailySchedule is null)
                    DailySchedule = new BackupDailySchedule();
                return DailySchedule.ScheduleRunTimes;
            }
        }

        /// <summary> Weekly schedule of this policy. </summary>
        public BackupWeeklySchedule WeeklySchedule { get; set; }
    }
}
