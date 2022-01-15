using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AASharp;
using VPKSoft.StarCatalogs;

namespace StarMap2D.Calculations.Helpers.Math
{
    public class Epochs
    {
        public static PointDouble ChangeEpoch(int epochFrom, int epochTo, double raHms, double declination)
        {
            var hh = 0.0;
            var mm = 0.0;
            var ss = 0.0;

            if (epochFrom == epochTo)
            {
                return new PointDouble { X = raHms, Y = declination };
            }

            var ra = raHms * 15;
            var dec = declination;

            var ra_ = 3.3 * ((double)epochTo - epochFrom) * (MathDegrees.Cos(23.5) +
                                                     MathDegrees.Sin(23.5) * MathDegrees.Sin(ra) *
                                                     MathDegrees.Tan(dec));

            mm = System.Math.Floor(ra_ / 60);
            ss = ra_ - mm * 60;
            ra_ = mm / 100 + ss / 10000;
            ra_ = AASCoordinateTransformation.DMSToDegrees(ra_ * 15, 0, 0);
            ra = ra + ra_;

            var dec_ = 50 * (epochTo - epochFrom) * MathDegrees.Sin(23.5) * MathDegrees.Cos(ra);

            mm = System.Math.Floor(dec_ / 60);
            ss = dec_ - mm * 60;
            dec_ = mm / 100 + ss / 10000;
            dec_ = AASCoordinateTransformation.DMSToDegrees(dec_, 0, 0);

            dec = dec + dec_;

            ra = ra / 15;
            ra_ = ra_ / 15;

            return new PointDouble { X = ra, Y = dec };
        }
    }
}
