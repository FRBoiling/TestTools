using System;
using System.Collections.Generic;

namespace UtilityLibrary
{
    static public class MATH
    {
        private static Vec2 tmpVec = new Vec2();
        public static float Clamp01(float value)
        {
            if (value < 0) value = 0;
            else if (value > 1.0f) value = 1;
            return value;
        }
        public static float ASin(float value)
        {
            return (float)(Math.Asin(value) * (180 / Math.PI));
        }
        public static float ACos(float value)
        {
            return (float)(Math.Acos(value) * (180 / Math.PI));
        }
        public static float Sin(float ratio, float min, float max)
        {
            return (float)(Math.Sin(Math.PI * 2 * ratio) * 0.5f + 0.5f) * (max - min) + min;
        }

        public static float Cos(float ratio, float min, float max)
        {
            return (float)(Math.Cos(Math.PI * 2 * ratio) * 0.5f + 0.5f) * (max - min) + min;
        }

        public static float GetSlerpRatio(float ratio)
        {
            float newRatio = (float)(1 - Math.Cos(ratio * Math.PI)) * 0.5f;
            return newRatio;
        }
        public static float AngleBetween(Vec2 Vec21, Vec2 Vec22)
        {
            double sin = Vec21.x * Vec22.y - Vec22.x * Vec21.y;
            double cos = Vec21.x * Vec22.x + Vec21.y * Vec22.y;

            return (float)(Math.Atan2(sin, cos) * (180 / Math.PI));
        }
        public static float GetPowRatio(float ratio, bool inverse = false)
        {
            float newRatio = (float)Math.Pow(ratio, 2);
            if (inverse == true)
            {
                if (newRatio > 0)
                    newRatio = (float)Math.Sqrt(ratio);
            }

            newRatio = (1 - (float)Math.Cos(newRatio * Math.PI)) * 0.5f;

            return newRatio;
        }

        public static double GetDistance(Vec2 pos1, Vec2 pos2)
        {
            return Math.Sqrt(Math.Pow(pos1.x - pos2.x, 2) + Math.Pow(pos1.y - pos2.y, 2));
        }

        public static bool IsInRange(Vec2 org, Vec2 target, float range)
        {
            Vec2.OperatorMinus(org, target, tmpVec);
            float dist = tmpVec.magnitudePower;
            if ((float)Math.Pow(range, 2) > dist)
            {
                return true;
            }
            return false;
        }

        public static bool IntersectSegment(Vec2 circle, float radius, Vec2 start, Vec2 end)
        {
            float dx, dy, A, B, C, det, t;

            dx = end.x - start.x;
            dy = end.y - start.y;

            A = dx * dx + dy * dy;
            B = 2 * (dx * (start.x - circle.x) + dy * (start.y - circle.y));
            C = (start.x - circle.x) * (start.x - circle.x) + (start.y - circle.y) * (start.y - circle.y) - radius * radius;

            det = B * B - 4 * A * C;

            if (det == 0)
            {
                t = -B / (2 * A);
                if (t >= 0 && t <= 1)
                    return true;
            }

            if (det > 0)
            {
                t = (float)((-B + Math.Sqrt(det)) / (2 * A));
                if (t >= 0 && t <= 1)
                    return true;
                t = (float)((-B - Math.Sqrt(det)) / (2 * A));
                if (t >= 0 && t <= 1)
                    return true;
            }
            return false;
        }

        public static int FloatToInt1000(float num)
        {
            return (int)(num * 1000);
        }

    };
}