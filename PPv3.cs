using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PPv3_System
{
   
   public class PPv3System
   {

   }

    public class PPv3PatternAnalyzer
    {
        public List<int> Jumps;
        public List<int> Streams;
        public List<int> Burst;
        public List<int> SingleTap;
        public List<int> FingerControlAlternateLowBpm;
        public List<int> UnkownPatterNoPattern;

        public PPv3PatternAnalyzer()
        {
            Jumps = new List<Int32>();
            Streams = new List<Int32>();
            Burst = new List<Int32>();
            FingerControlAlternateLowBpm = new List<Int32>();   
            UnkownPatterNoPattern = new List<Int32>();
            SingleTap = new List<Int32>();      
        }


        public void GetPatternOverview(List<int> CircleY, List<int> CircleX, List<int> CircleTime)
        {
         
        }
    }


   
}
