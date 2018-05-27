using System;
using System.Collections.Generic;
using System.Numerics;

namespace WheelModelLibrary
{
    public class WheelModel
    {
        public Func<double, double> Func { get; set; }
        public double Speed { get; set; }
        public double Height { get; set; }
        public double U { get; set; }
        public double I { get; set; }
        public double R { get; set; }
        public double K { get; set; }
        public double M { get; set; }
        public double G { get; set; }
        public double Omega { get; set; }

        public class Data
        {
            public double S { get; set; }
            public double T { get; set; }
            public double N { get; set; }
            public double Y0 { get; set; }
            public double DeltaY0 { get; set; }
            public double DeltaDeltaY0 { get; set; }
            public double Y { get; set; }
            public double DeltaY { get; set; }
            public double DeltaDeltaY { get; set; }
        }

        public List<Data> Process(double startT, double endT, double dt)
        {
            var datas = new List<Data>();
            var prevY0 = double.NaN;
            var prevDeltaY0 = double.NaN;
            var prevY = double.NaN;
            var prevDeltaY = double.NaN;
            for (var i = startT; i <= endT; i += dt)
            {
                var t = i;
                var s = Speed * t;
                var y0 = Func(s) + Height;
                var dy0 = prevY0.Equals(double.NaN) ? 0.0 : y0 - prevY0;
                prevY0 = y0;
                var ddy0 = prevDeltaY0.Equals(double.NaN) ? 0.0 : dy0 - prevDeltaY0;
                prevDeltaY0 = dy0;

                var f1 = -K * y0 - M * G;
                var f2 = Vector3.Cross(new Vector3(0, 1, 0), new Vector3(0, (float)-f1, 0)).Length();
                var n = U * I * Math.Cos(Omega) * Math.Sqrt(3) * R / (M / 1000.0 + 1.0 + K / 0.1 + G / 9.8 + Math.Sin(t));
                var y = y0 + n;
                var dy = prevY.Equals(double.NaN) ? 0.0 : y - prevY;
                prevY = y;
                var ddy = prevDeltaY.Equals(double.NaN) ? 0.0 : dy - prevDeltaY;
                prevDeltaY = dy;

                datas.Add(new Data
                {
                    T = t,
                    S = s,
                    Y0 = y0,
                    DeltaY0 = dy0,
                    DeltaDeltaY0 = ddy0,
                    N = n,
                    Y = y,
                    DeltaY = dy,
                    DeltaDeltaY = ddy
                });
            }
            return datas;
        }
    }
}
