using System;
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
        public float IAMax { get; set; }
        [Label("Phase C")]
        public float ICMax { get; set; }
        [Label("Phase B")]
        public float IBMax { get; set; }

        [Label("Ground")]
        public float IRMax { get; set; }

        public float Duration { get; set; }

        public string FaultType { get; set; }
    }
}