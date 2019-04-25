using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilityLibrary
{
    public class Rect
    {
        private Vec2 leftTop;
        private Vec2 rightTop;
        private Vec2 rightBottom;
        private Vec2 leftBottom;
        public Rect(Vec2 left_top, Vec2 right_top, Vec2 right_bottom, Vec2 left_bottom)
        {
            leftTop = left_top;
            rightTop = right_top;
            rightBottom = right_bottom;
            leftBottom = left_bottom;
        }

        //0;0|0;1|1;1|1;0
        public Rect(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                return;
            }
            string[] arr = info.Split('|');
            if (arr.Length != 4)
            {
                return;
            }
            leftTop = new Vec2(arr[0]);
            rightTop = new Vec2(arr[1]);
            rightBottom = new Vec2(arr[2]);
            leftBottom = new Vec2(arr[3]);
        }
        // 计算两个向量的叉乘 p1为两个向量的公共起点 p2为第一个向量终点，p为第二个向量终点
        public float GetCross(Vec2 p1, Vec2 p2, Vec2 p)
        {
            return (p2.x - p1.x) * (p.y - p1.y) - (p.x - p1.x) * (p2.y - p1.y);
        }

        public bool RectCanBeUsed()
        {
            if (leftTop == null || rightTop == null || leftBottom == null || rightBottom == null)
                return false;
            else
                return true;
        }

        public bool IsInSquareRange(Vec2 p)
        {
            return GetCross(leftTop, rightTop, p) * GetCross(rightBottom, leftBottom, p) >= 0 && GetCross(rightTop, rightBottom, p) * GetCross(leftBottom, leftTop, p) >= 0;
        }

        public bool CrossRect(Vec2 start, Vec2 end)
        {
            if (IsIntersect(start, end, leftTop, rightBottom) || IsIntersect(start, end, rightTop, leftBottom))
            {
                return true; 
            }
            return false;
        }

        public bool IsIntersect(Vec2 p1, Vec2 p2, Vec2 q1, Vec2 q2)
        {
            if (Math.Max(p1.x, p2.x) < Math.Min(q1.x, q2.x))
            {
                return false; 
            }
            if (Math.Min(p1.x, p2.x) > Math.Max(q1.x, q2.x))
            {
                return false;
            }
            if (Math.Max(p1.y, p2.y) < Math.Min(q1.y, q2.y))
            {
                return false;
            }
            if (Math.Min(p1.y, p2.y) > Math.Max(q1.y, q2.y))
            {
                return false;
            }
            float crossP1P2Q1 = GetCross(p1, p2, q1);
            float crossP1Q2P2 = GetCross(p1, q2, p2);
            float crossQ1Q2P1 = GetCross(q1, q2, p1);
            float crossQ1P2Q2 = GetCross(q1, p2, q2);
            return crossP1P2Q1 * crossP1Q2P2 >= 0 && crossQ1Q2P1 * crossQ1P2Q2 >= 0;
        }

    }
}
