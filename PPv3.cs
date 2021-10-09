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
        public List<double> Jumps;
        public List<double> Streams;
        public List<double> Burst;
        public List<double> SingleTapNoPattern;
        public List<double> FingerControl;
        public List<double> Alternate;
        public List<double> LowBpm;
        public List<double> UnkownPatter;

        public List<double> DistanceGap;
        public List<double> TimeGap;

        public double LastObjectTime;

        public PPv3PatternAnalyzer()
        {
            Jumps = new List<double>();
            Streams = new List<double>();
            Burst = new List<double>();
            FingerControl = new List<double>();
            Alternate = new List<double>();
            LowBpm = new List<double>();   
            UnkownPatter = new List<double>();
            SingleTapNoPattern = new List<double>();

            DistanceGap = new List<double>();
            TimeGap = new List<double>();
        }


        public void GetPatternOverview(List<int> CircleY, List<int> CircleX, List<int> CircleTime)
        {
          
            int index = 0;
            double distance,timeDifference;
          //  distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            while (true)
            {
                // Calcule Distance/time between current and next object and measure pattern of these data

                if (CircleTime.Count < 2)
                {
                    // At least 2 Hitcircles need to be avaible
                    break;
                }


                if (index+1 >= CircleTime.Count)
                {
                    break;
                }
                else if (index+1 < CircleTime.Count)
                {
                    distance = Math.Sqrt(Math.Pow((CircleX[index] - CircleX[index + 1]), 2) + Math.Pow((CircleY[index] - CircleY[index + 1]), 2));
                    timeDifference = CircleTime[index + 1] - CircleTime[index];

                    DistanceGap.Add(distance);
                    TimeGap.Add(timeDifference);
                }
                index++;
            }

            LastObjectTime = CircleTime[CircleTime.Count + 1];

        }
    }


   
}
