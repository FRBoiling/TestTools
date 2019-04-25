using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilityLibrary
{
    public class Vec2
    {
        public static Vec2 zero = new Vec2(0, 0);
        public static Vec2 up = new Vec2(0, 1);
        public static Vec2 right = new Vec2(1, 0);
        public static Vec2 one = new Vec2(1, 1);
        // 不要将tmpVec作为函数的返回值
        public static Vec2 tmpVec = new Vec2();

        public float x = 0, y = 0;

        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }

        public Vec2() { }

        public Vec2(int px, int py)
        {
            x = px;
            y = py;
        }

        public Vec2(float px, float py)
        {
            x = px;
            y = py;
        }

        public Vec2(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                x = 0;
                y = 0;
                return;
            }
            string[] arr = info.Split(';');
            if (arr.Length != 2)
            {
                x = 0;
                y = 0;
                return;
            }
            float.TryParse(arr[0], out x);
            float.TryParse(arr[1], out y);
        }

        public Vec2(Vec2 src)
        {
            if (src == null)
            {
                x = 0;
                y = 0;
            }
            else
            {
                x = src.x;
                y = src.y;
            }
        }

        public Vec2 Clone()
        {
            var clone = new Vec2();
            clone.x = x;
            clone.y = y;

            return clone;
        }
        public static void Lerp(Vec2 cur, Vec2 target, float amount)
        {
            cur.x = cur.x * (1 - amount) + target.x * amount;
            cur.y = cur.y * (1 - amount) + target.y * amount;
        }
        public static void OperatorAdd(Vec2 target, Vec2 source, Vec2 result)
        {
            if (target == null || source == null)
            {
                return;
            }
            if (result == null)
            {
                result = new Vec2();
            }
            result.x = target.x + source.x;
            result.y = target.y + source.y;
        }
        // 运算符+重载函数应使用OperatorAdd替代
        public static Vec2 operator +(Vec2 target, Vec2 source)
        {
            return new Vec2(target.x + source.x, target.y + source.y);
        }

        public static void OperatorMinus(Vec2 target, Vec2 source, Vec2 result)
        {
            if (target == null || source == null)
            {
                return;
            }
            if (result == null)
            {
                result = new Vec2();
            }
            result.x = target.x - source.x;
            result.y = target.y - source.y;
        }
        //运算符-重载函数应使用OperatorMinus
        public static Vec2 operator -(Vec2 target, Vec2 source)
        {
            return new Vec2(target.x - source.x, target.y - source.y);
        }

        public static void OperatorMultiply(Vec2 target, float source, Vec2 result)
        {
            if (target == null)
            {
                return;
            }
            if (result == null)
            {
                result = new Vec2();
            }
            result.x = target.x * source;
            result.y = target.y * source;
        }
        public static Vec2 operator *(Vec2 target, float source)
        {
            return new Vec2(target.x * source, target.y * source);
        }

        public static bool operator ==(Vec2 target, Vec2 source)
        {
            if ((object)target == null && (object)source == null) return true;
            if ((object)target == null && (object)source != null) return false;
            if ((object)source == null && (object)target != null) return false;
            bool a = false;
            bool b = false;
            try
            {
                float x = target.X;
            }
            catch (NullReferenceException)
            {
                a = true;
            }
            try
            {
                float y = source.Y;
            }
            catch (NullReferenceException)
            {
                b = true;
            }
            if (a == b && a == true)
            {
                return true;
            }
            if (a == true && a != b)
            {
                return false;
            }
            if (b == true && a != b)
            {
                return false;
            }
            return target.x == source.x && target.y == source.y;
        }

        public static bool operator !=(Vec2 target, Vec2 source)
        {
            if ((object)source == null && (object)target == null) return false;
            if ((object)source == null && (object)target != null) return true;
            if ((object)source != null && (object)target == null) return true;

            return target.x != source.x || target.y != source.y;
        }

        //获取向量的长度
        public double GetLength()
        {
            double Length = Math.Sqrt(x * x + y * y);
            return Length;
        }
        //获取相反向量
        public Vec2 GetReverseVec2()
        {
            Vec2 reVec2 = new Vec2(-x, -y);
            return reVec2;
        }
        //获取顺时针旋转90的正交向量
        public Vec2 GetClockwiseOrthogonalVec2s()
        {
            Vec2 orVec2 = new Vec2(y, -x);
            return orVec2;
        }
        //获取逆时针旋转90的正交向量
        public Vec2 GetCounterclockwiseOrthogonalVec2s()
        {
            Vec2 orVec2 = new Vec2(-y, x);
            return orVec2;
        }

        //向量改变大小
        public Vec2 Change(double i)
        {
            Vec2 nVec2 = new Vec2((float)(i * x), (float)(i * y));
            return nVec2;
        }
        public static double GetRange(Vec2 from, Vec2 to)
        {
            double radian = Math.Sqrt(Math.Pow((to.X - from.X), 2) + Math.Pow((to.Y - from.Y), 2));
            return radian;
        }
        public static double GetRange(float fromX, float fromY, Vec2 to)
        {
            double radian = Math.Sqrt(Math.Pow((to.X - fromX), 2) + Math.Pow((to.Y - fromY), 2));
            return radian;
        }

        public static double GetRangePower(Vec2 from, Vec2 to)
        {
            double radian = Math.Pow((to.X - from.X), 2) + Math.Pow((to.Y - from.Y), 2);
            return radian;
        }

        /// <summary>
        /// 求Dis
        /// </summary>
        /// <param name="toX"></param>
        /// <param name="toY"></param>
        /// <returns>float是个平方值</returns>
        public float Dis(float toX, float toY)
        {
            float dis = (toX - x) * (toX - x) + (toY - y) * (toY - y);
            return dis;
        }

        public float Dis(Vec2 toVec)
        {
            float dis = (toVec.X - x) * (toVec.X - x) + (toVec.Y - y) * (toVec.Y - y);
            return dis;
        }

        public static float Dis(float fromX, float fromY, float toX, float toY)
        {
            float dis = (toX - fromX) * (toX - fromX) + (toY - fromY) * (toY - fromY);
            return dis;
        }

        public static float Dis(float fromX, float fromY, Vec2 to)
        {
            float dis = (to.X - fromX) * (to.X - fromX) + (to.Y - fromY) * (to.Y - fromY);
            return dis;
        }

        public static float Dis(Vec2 from, Vec2 to)
        {
            float dis = (to.X - from.X) * (to.X - from.X) + (to.Y - from.Y) * (to.Y - from.Y);
            return dis;
        }

        public static double GetRadian(Vec2 from, Vec2 to)
        {
            double radian = Math.Atan2(to.y, to.x) - Math.Atan2(from.y, from.x);
            return radian;
        }
        //向量方向
        public Vec2 GetAngle(float tX, float tY)
        {
            Vec2 angle = new Vec2(tX, tY);
            Vec2.OperatorMinus(angle , this, angle);
            //Vec2 angle = (new Vec2(tX, tY)) - this;
            return angle;
        }
        public override bool Equals(object obj)
        {
            Vec2 target = (Vec2)obj;
            return x == target.x && y == target.y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public float magnitude
        {
            get { return (float)Math.Sqrt((float)(Math.Pow(x, 2) + Math.Pow(y, 2))); }
        }

        public float magnitudePower
        { get { return (float)(Math.Pow(x, 2) + Math.Pow(y, 2)); } }

        public void Normalize()
        {
            float length = magnitude;
            if (length == 0)
            {
                return;
            }
            x = x / length;
            y = y / length;
        }
        public Vec2 Rotate(float degree)
        {
            double radian = degree * (Math.PI / 180);
            return Rotate(radian);
        }
        public Vec2 Rotate(double radian)
        {
            double sin = Math.Sin(radian);
            double cos = Math.Cos(radian);

            return Rotate(sin, cos);
        }

        public Vec2 Rotate(double sin, double cos)
        {
            Vec2 ret = new Vec2();
            ret.x = (float)(cos * x + sin * y);
            ret.y = (float)(-sin * x + cos * y);
            return ret;
        }

        public Vec2 Rotate_new(double radian, float range)
        {
            double sin = Math.Sin(radian);
            double cos = Math.Cos(radian);

            return Rotate_new(sin, cos, range);
        }

        public Vec2 Rotate_new(double sin, double cos, float range)
        {
            Vec2 ret = new Vec2();

            ret.x = (float)(x + sin * range);
            ret.y = (float)(y - cos * range);
            return ret;
        }

        // 以zero为基础在高y宽x的矩形范围内是否存在
        public bool IsIntersectSqure(float width, float top, float radius = 0f)
        {
            return (y >= -radius && y <= top + radius) && (Math.Abs(x) <= width * 0.5f + radius);
        }

        //public static bool IsInSquareRange(Vec2 a,Vec2 b,double width,double high)
        //{
        //    return true;
        //}

        /// <summary>
        /// 参数点是不是在以调用点为中心点的矩形范围内
        /// </summary>
        /// <param name="b">参数点</param>
        /// <param name="width">矩形宽度</param>
        /// <param name="high">矩形高度</param>
        /// <returns>bool</returns>
        public bool IsInSquareRange(Vec2 b, double width, double high)
        {
            Vec2.OperatorMinus(this , b,tmpVec);
            if (Math.Abs(tmpVec.x) > width)
            {
                return false;
            }

            if (Math.Abs(tmpVec.y) > high)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return "X:" + this.x + "--Y:" + this.y + ";";
        }

        public static bool IsSameDirection(Vec2 src, Vec2 dst)
        {
            if (src == null || dst == null)
            {
                return false;
            }
            if(src.X * dst.X <=0 || src.Y * dst.Y <= 0)
            {
                return false;
            }
            if (((int)(100 * src.X / src.Y)) == ((int)(100 * dst.X / dst.Y)))
            {
                return true;
            }
            return false;
        }

        public static float Dot(Vec2 v1, Vec2 v2)
        {
            return (v1.x * v2.x + v1.y * v2.y);
        }

        public static Vec2 Project(Vec2 vector, Vec2 onNormal)
        {
            Vec2 vector2;
            float num = Dot(onNormal, onNormal);
            if (num >= Math.E)
            {
                vector2 = onNormal * Dot(vector, onNormal);
                vector2.x /= num;
                vector2.y /= num;
            }
            else
            {
                vector2 = zero;
            }
            return vector2;
        }


        public static double Angle(Vec2 v1, Vec2 v2)
        {
            Vec2 tempV1 = new Vec2 (v1.x,v1.y);
            tempV1.Normalize();
            Vec2 tempV2 = new Vec2(v2.x,v2.y);
            tempV2.Normalize();
            return Math.Acos((double)Dot(tempV1, tempV2));
        }

        public static bool IsPointInPolygon(Vec2 point, List<Vec2> polygon)
        {
            int polygonLength = polygon.Count, i = 0;
            bool inside = false;

            float pointX = point.x, pointY = point.y;

            float startX, startY, endX, endY;
            Vec2 endPoint = polygon[polygonLength - 1];
            endX = endPoint.x;
            endY = endPoint.y;
            while (i < polygonLength)
            {
                startX = endX; startY = endY;
                endPoint = polygon[i++];
                endX = endPoint.x;
                endY = endPoint.y;
                inside ^= (endY > pointY ^ startY > pointY) && ((pointX - endX) < (pointY - endY) * (startX - endX) / (startY - endY));
            }
            return inside;
        }

        public static bool RandomPos(Vec2 pos, float distance)
        {
            if (pos == null)
            {
                return false;
            }

            float x = 0.0001f,y=0.0001f;
            Random randx = new Random(RAND.GetRandomSeed());
            int ratioX = randx.Next(0, 10000)-5000;
            Random randy = new Random(RAND.GetRandomSeed());
            int ratioY = randy.Next(0, 10000)-5000;
            x = x * distance * (float)ratioX;
            y = y * distance * (float)ratioY;
            pos.X += x;
            pos.Y += y;
            return true;
        }
    }
}
