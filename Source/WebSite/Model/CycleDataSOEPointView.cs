using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GSF.Data.Model;

namespace SOETools.Model
{
    [TableName("CycleDataSOEPointView")]
    public class CycleDataSOEPointView
    {
        [PrimaryKey(true)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int MeterID { get; set; }
        public DateTime Timestamp { get; set; }
        public float VX1RMS { get; set; }
        public float VX2RMS { get; set; }
        public float VX3RMS { get; set; }
        public float VY1RMS { get; set; }
        public float VY2RMS { get; set; }
        public float VY3RMS { get; set; }
        public float I1RMS { get; set; }
        public float I2RMS { get; set; }
        public float I3RMS { get; set; }
        public string PointCode { get; set; }
        public string UpState { get; set; }
        public string DownState { get; set; }
        public string Phasing { get; set; }
        public int IncidentID { get; set; }

    }
}