using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電池篩選器
{
    public class Battery
    {
        //電池編號
        public string BatteryId { get; set; }
        //電池開封日
        public DateTime OpenDate { get; set; }
        //電池放電時間
        public double DischargeMinutes { get; set; }
        //電池容量
        public double CapacityMah { get; set; }
        //電池內阻
        public double InternalResistance { get; set; }
    }
}