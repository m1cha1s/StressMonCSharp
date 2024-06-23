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
        public float RR;
        public float HR;
        public float Temp1;
        public float Temp2;
        public float dTemp1;
        public float dTemp2;

        public float Time;

        public DataPacket(float time, float rr, float hr, float temp1, float temp2, float dtemp1, float dtemp2)
        {
            Time = time;
            RR = rr;
            HR = hr;
            Temp1 = temp1;
            Temp2 = temp2;
            dTemp1 = dtemp1;
            dTemp2 = dtemp2;
        }

        public DataPacket(string csv)
        {
            string[] columns = csv.Split(';');
            Debug.WriteLine(columns.ToString());

            int i = 0;
            Time = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            RR = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            HR = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Temp1 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Temp2 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            dTemp2 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            dTemp2 = float.Parse(columns[i++], CultureInfo.InvariantCulture);
            Debug.WriteLine(HR.ToString());
        }

        public float max(bool stressEn, bool temp1En, bool temp2En, bool bpmEn, bool accEn)
        {
            float[] a = {
                temp1En ? Temp1 : float.NegativeInfinity,
                temp2En ? Temp2 : float.NegativeInfinity,
                bpmEn ? HR : float.NegativeInfinity,
                accEn ? RR : float.NegativeInfinity,
                stressEn ? stress() : float.NegativeInfinity
            };
            return a.Max(t => t);
        }

        public float min(bool stressEn, bool temp1En, bool temp2En, bool bpmEn, bool accEn)
        {
            float[] a = {
                temp1En ? Temp1 : float.PositiveInfinity,
                temp2En ? Temp2 : float.PositiveInfinity,
                bpmEn ? HR : float.PositiveInfinity,
                accEn ? RR : float.PositiveInfinity,
                stressEn ? stress() : float.PositiveInfinity
            };
            return a.Min(t => t);
        }

        public float stress()
        {
            const float A = 0.35f;
            const float B = 0.15f;
            const float C = 0.4f;
            const float D = 0.1f;

            float stress = A * dTemp1 / 2 + B * dTemp2 / 0.5f + C * HR / 100 + D * RR / 20;
            stress /= 3;
            return stress; // Make something better here
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0};{1};{2};{3};{4};{5};{6}", Time, RR, HR, Temp1, Temp2, dTemp1, dTemp2);
        }
    }
}
