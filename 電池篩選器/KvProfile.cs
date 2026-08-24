using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 電池篩選器
{
    public class KvProfile
    {
        //馬達組別
        public int Kv { get; set; }
        //放電時間
        public double TimeWeight { get; set; }
        //放電容量
        public double CapacityWeight { get; set; }
        //內組值
        public double ResistanceWeight { get; set; }
    }
}
