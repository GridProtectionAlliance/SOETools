using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GSF.Data.Model;

namespace SOETools.Model
{
    [System.Web.DynamicData.TableName("IncidentEventCycleDataView")]
    public class IncidentEventCycleDataView
    {
        [PrimaryKey(true)]
        public int ID { get; set; }
        public string Device { get; set; }

        [Label("Date/Time")]
        public DateTime StartTime { get; set; }

        [Label("Phase A")]
        public float PhaseA { get; set; }
        [Label("Phase C")]
        public float PhaseC { get; set; }
        [Label("Phase B")]
        public float PhaseB { get; set; }

        public float Ground { get; set; }

        public float Duration { get; set; }

        public string FaultType { get; set; }
    }
}