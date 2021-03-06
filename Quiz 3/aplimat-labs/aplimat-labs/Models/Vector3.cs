﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public Vector3(double _x, double _y, double _z)
        {
            x = (float)_x;
            y = (float)_y;
            z = (float)_z;
        }

        public static Vector3 operator +(Vector3 rhs, Vector3 lhs) //rhs = right hand side 
        {
            return new Vector3(rhs.x + lhs.x,
                rhs.y + lhs.y,
                rhs.z + lhs.z);
        }

        public static Vector3 operator -(Vector3 rhs, Vector3 lhs) //rhs = right hand side 
        {
            return new Vector3(rhs.x - lhs.x,
                rhs.y - lhs.y,
                rhs.z - lhs.z);
        }

        public static Vector3 operator *(Vector3 rhs, float scalar)
        {
            return new Vector3(rhs.x * scalar,
                rhs.y * scalar,
                rhs.z * scalar);
        }

        public static Vector3 operator /(Vector3 left, float scalar)
        {
            return new Vector3(left.x * scalar,
                left.y * scalar,
                left.z * scalar);
        }

        public float GetMagnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public Vector3 Normalize()
        {
            float length = GetMagnitude();
            this.x /= length;
            this.y /= length;
            this.z /= length;

            return new Vector3(x, y, z);
        }
        //public void Clamp(Vector3 limit)
        //{
        //    if (this.x >= limit.x) this.x = limit.x;
        //    if (this.y >= limit.y) this.y = limit.y;
        //    if (this.z >= limit.z) this.z = limit.z;
        //}
        public void Clamp(float limit)
        {
            if (this.x >= limit) this.x = limit;
            if (this.y >= limit) this.y = limit;
            if (this.z >= limit) this.z = limit;
        }
    }
}