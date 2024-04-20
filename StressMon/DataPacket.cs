using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressMon
{
    internal class DataPacket
    {
        public float AccMag;
        public float Bpm;
        public float Temp1;
        public float Temp2;

        public DataPacket(float accMag, float bpm, float temp1, float temp2)
        {
            AccMag = accMag;
            Bpm = bpm;
            Temp1 = temp1;
            Temp2 = temp2;
        }

        public DataPacket(string csv)
        {
            string[] columns = csv.Split(';');

            int i = 0;
            AccMag = float.Parse(columns[i++]);
            Bpm = float.Parse(columns[i++]);
            Temp1 = float.Parse(columns[i++]);
            Temp2 = float.Parse(columns[i++]);
        }
    }
}
