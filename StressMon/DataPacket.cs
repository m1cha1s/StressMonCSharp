using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

        public float Time;

        public DataPacket(float time, float accMag, float bpm, float temp1, float temp2)
        {
            Time = time;
            AccMag = accMag;
            Bpm = bpm;
            Temp1 = temp1;
            Temp2 = temp2;
        }

        public DataPacket(string csv)
        {
            string[] columns = csv.Split(';');
            Debug.WriteLine(columns.ToString());

            int i = 0;
            Time = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            AccMag = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Bpm = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Temp1 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Temp2 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Debug.WriteLine(Bpm.ToString());
        }

        public float max(bool stressEn, bool temp1En, bool temp2En, bool bpmEn, bool accEn)
        {
            float[] a = {
                temp1En ? Temp1 : float.NegativeInfinity,
                temp2En ? Temp2 : float.NegativeInfinity,
                bpmEn ? Bpm : float.NegativeInfinity,
                accEn ? AccMag : float.NegativeInfinity,
                stressEn ? stress() : float.NegativeInfinity
            };
            return a.Max(t => t);
        }

        public float min(bool stressEn, bool temp1En, bool temp2En, bool bpmEn, bool accEn)
        {
            float[] a = {
                temp1En ? Temp1 : float.PositiveInfinity,
                temp2En ? Temp2 : float.PositiveInfinity,
                bpmEn ? Bpm : float.PositiveInfinity,
                accEn ? AccMag : float.PositiveInfinity,
                stressEn ? stress() : float.PositiveInfinity
            };
            return a.Min(t => t);
        }

        public float stress()
        {
            const float A = 0.5f;
            const float B = 0.1f;
            const float C = 0.4f;

            float stress = A * (Temp2 - Temp2) / 5 + B * AccMag / 21 + C * Bpm / 100;
            stress /= 3;
            return stress; // Make something better here
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0};{1};{2};{3};{4}", Time, AccMag, Bpm, Temp1, Temp2);
        }
    }
}
