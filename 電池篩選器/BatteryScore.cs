using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電池篩選器
{
    public class BatteryScore
    {
        public double type { get; set; }
        //電池物件
        public Battery Battery { get; set; }
        //分數
        public double Score { get; set; }
    }
}
