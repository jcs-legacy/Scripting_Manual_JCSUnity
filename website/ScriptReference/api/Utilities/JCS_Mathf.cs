﻿/**
 * $File: JCS_Mathf.cs $
 * $Date: $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *                   Copyright (c) 2016 by Shen, Jen-Chieh $
 */
using System;
using UnityEngine;
using System.Collections;


namespace JCSUnity
{
    /// <summary>
    /// Store all the useful math function here...
    /// </summary>
    public class JCS_Mathf 
        : MonoBehaviour
    {
        // Radian to Degree.
        public const float Rad2Deg = 180.0f / Mathf.PI;
        // Degree to Radian.
        public const float Deg2Rad = Mathf.PI / 180.0f;


        /// <summary>
        /// Absolute the value. (Integer)
        /// </summary>
        /// <param name="val"> value to absolute </param>
        /// <returns> absolute value </returns>
        public static int AbsoluteValue(int val)
        {
            if (val < 0)
                return -val;
            return val;
        }

        /// <summary>
        /// Absolute the value. (Float)
        /// </summary>
        /// <param name="val"> value to absolute </param>
        /// <returns> absolute value </returns>
        public static float AbsoluteValue(float val)
        {
            if (val < 0)
                return -val;
            return val;
        }

        /// <summary>
        /// Absolute the value. (Vector3)
        /// </summary>
        /// <param name="val"> value to absolute </param>
        /// <returns> absolute value </returns>
        public static Vector3 AbsoluteValue(Vector3 val)
        {
            Vector3 tempVal = val;

            tempVal.x = AbsoluteValue(tempVal.x);
            tempVal.y = AbsoluteValue(tempVal.y);
            tempVal.z = AbsoluteValue(tempVal.z);

            return tempVal;
        }
        ///
        /// <summary>
        /// Set the value to positive (Integer)
        /// </summary>
        /// <param name="val"> value to positive </param>
        /// <returns> positive value </returns>
        public static float ToPositive(int val)
        {
            return AbsoluteValue(val);
        }

        /// <summary>
        /// Set the value to positive (Float)
        /// </summary>
        /// <param name="val"> value to positive </param>
        /// <returns> positive value </returns>
        public static float ToPositive(float val)
        {
            return AbsoluteValue(val);
        }

        /// <summary>
        /// Set the value to positive (Vector3)
        /// </summary>
        /// <param name="vec3"> vector to positive. </param>
        /// <returns> positive vector. </returns>
        public static Vector3 ToPositive(Vector3 vec3)
        {
            Vector3 newVec;
            newVec.x = ToPositive(vec3.x);
            newVec.y = ToPositive(vec3.y);
            newVec.z = ToPositive(vec3.z);

            return newVec;
        }

        /// <summary>
        /// Set the value to negative (Integer)
        /// </summary>
        /// <param name="val"> value to negative </param>
        /// <returns> negative value </returns>
        public static float ToNegative(int val)
        {
            return -(AbsoluteValue(val));
        }

        /// <summary>
        /// Set the value to negative (Float)
        /// </summary>
        /// <param name="val"> value to negative </param>
        /// <returns> negative value </returns>
        public static float ToNegative(float val)
        {
            return -(AbsoluteValue(val));
        }

        /// <summary>
        /// Set the value to negative (Vector3)
        /// </summary>
        /// <param name="vec3"> vector to negative. </param>
        /// <returns> negative vector. </returns>
        public static Vector3 ToNegative(Vector3 vec3)
        {
            Vector3 newVec;
            newVec.x = ToNegative(vec3.x);
            newVec.y = ToNegative(vec3.y);
            newVec.z = ToNegative(vec3.z);

            return newVec;
        }

        /// <summary>
        /// Check if the value is positive (Integer)
        /// </summary>
        /// <param name="val"> value to check </param>
        /// <returns> true: is positive, false: is negative </returns>
        public static bool isPositive(int val)
        {
            return (val > 0 && val != 0) ? true : false;
        }

        /// <summary>
        /// Check if the value is positive (Float)
        /// </summary>
        /// <param name="val"> value to check </param>
        /// <returns> true: is positive, false: is negative </returns>
        public static bool isPositive(float val)
        {
            return (val > 0.0f && val != 0.0f) ? true : false;
        }

        /// <summary>
        /// Check if the value is negative (Integer)
        /// </summary>
        /// <param name="val"> value to check </param>
        /// <returns> true: is negative, false: is positive </returns>
        public static bool isNegative(int val)
        {
            return (val < 0 && val != 0) ? true : false;
        }

        /// <summary>
        /// Check if the value is negative (Float)
        /// </summary>
        /// <param name="val"> value to check </param>
        /// <returns> true: is negative, false: is positive </returns>
        public static bool isNegative(float val)
        {
            return (val < 0.0f && val != 0.0f) ? true : false;
        }

        /// <summary>
        /// To Reverse the value.
        /// </summary>
        /// <param name="val"> value to reverse </param>
        /// <returns> reverse value </returns>
        public static float ToReverse(float val)
        {
            return -val;
        }

        /// <summary>
        /// Reciprocal of the value
        /// </summary>
        /// <param name="val"> value to reciprocal </param>
        /// <returns> reciprocal value </returns>
        public static float Reciprocal(float val)
        {
            return (1 / val);
        }

        /// <summary>
        /// Short hand of sqr of value
        /// </summary>
        /// <param name="val"> value u want to sqr </param>
        /// <returns> sqr value </returns>
        public static float Sqr(float val)
        {
            return (val * val);
        }

        /// <summary>
        /// Framework define vector1's distance.
        /// The same as Unity's API 
        /// "Vector2.distance" and "Vector3.distnace".
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static float DistanceOfUnitVector(float x1, float x2)
        {
            float distance = x2 - x1;
            distance = AbsoluteValue(distance);
            return distance;
        }

        /// <summary>
        /// Return bool to check the number is odd or not.
        /// </summary>
        /// <param name="num"> number to check. </param>
        /// <returns>
        /// true, is odd.
        /// false, is even.
        /// </returns>
        public static bool IsOdd(int index)
        {
            return !IsEven(index);
        }

        /// <summary>
        /// Return bool to check the number is even or not.
        /// </summary>
        /// <param name="num"> number to check. </param>
        /// <returns> 
        /// true, is even.
        /// false, is odd.
        /// </returns>
        public static bool IsEven(int num)
        {
            return ((num % 2) == 0);
        }

        /// <summary>
        /// Center of the array length
        /// </summary>
        /// <param name="length"> length of the array </param>
        /// <returns> center of the array length </returns>
        public static int FindMiddleIndex(int length)
        {
            return (length / 2);
        }

        /// <summary>
        /// Pass in an index that is out of range, 
        /// this function will return the in range index
        /// within the range 0 ~ length with over flow calculation.
        /// </summary>
        /// <param name="targetIndex"> index u pass in </param>
        /// <param name="length"> length of the array. </param>
        /// <returns> over flow calculation index. </returns>
        public static int OverFlowIndex(int targetIndex, int length)
        {
            if (targetIndex < length && targetIndex > 0)
                return targetIndex;

            if (targetIndex < 0)
                return length + (targetIndex % length);

            return (targetIndex % length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentVal"></param>
        /// <param name="targetVal"></param>
        /// <returns></returns>
        public static int ApproachTo(int currentVal, int targetVal)
        {
            if (currentVal == targetVal)
                return currentVal;

            if (currentVal < targetVal)
                return ++currentVal;

            if (targetVal < currentVal)
                return --currentVal;

            JCS_Debug.LogError(
                "Errors with approaching to a value...");

            return 0;
        }

        /// <summary>
        /// 計算旋轉的點 (JCS_VECTOR2F)
        /// </summary>
        /// <param name="point"> 我們要計算的"點" </param>
        /// <param name="cos"> Cos 的角度 "Cos(angle)" </param>
        /// <param name="sin"> Sin 的角度 "Sin(angle)" </param>
        /// <param name="origin"> 以這個"點"為中心旋轉 </param>
        /// <returns></returns>
        public static Vector3 RotatePointZ(
            Vector3 point, float cos, float sin, Vector3 origin)
        {
            return new Vector3(
            origin.x + ((point.x - origin.x) * cos) - ((point.y - origin.y) * sin),
            origin.y + ((point.x - origin.x) * sin) + ((point.y - origin.y) * cos),
            point.z);
        }
        public static Vector3 RotatePointX(
            Vector3 point, float cos, float sin, Vector3 origin)
        {
            return new Vector3(
            point.x,
            origin.z + ((point.z - origin.z) * cos) - ((point.y - origin.y) * sin),
            origin.y + ((point.z - origin.z) * sin) + ((point.y - origin.y) * cos));
        }
        public static Vector3 RotatePointY(
            Vector3 point, float cos, float sin, Vector3 origin)
        {
            return new Vector3(
            origin.x + ((point.x - origin.x) * cos) - ((point.z - origin.z) * sin),
            point.y,
            origin.z + ((point.x - origin.x) * sin) + ((point.z - origin.z) * cos));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="origin"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Vector3 RotatePointY(Vector3 point, Vector3 origin, float angle)
        {
            return new Vector3(
                origin.x + ((Mathf.Cos(angle) * (point.x - origin.x))) - (Mathf.Sin(angle) * (point.z - origin.z)),
                point.y,
                origin.z + ((Mathf.Sin(angle) * (point.x - origin.x))) + (Mathf.Cos(angle) * (point.z - origin.z)));
        }
        public static Vector3 RotatePointX(Vector3 point, Vector3 origin, float angle)
        {
            return new Vector3(
                point.x,
                origin.y + ((Mathf.Cos(angle) * (point.y - origin.y))) - (Mathf.Sin(angle) * (point.z - origin.z)),
                origin.z + ((Mathf.Sin(angle) * (point.y - origin.y))) + (Mathf.Cos(angle) * (point.z - origin.z)));
        }
        public static Vector3 RotatePointZ(Vector3 point, Vector3 origin, float angle)
        {
            return new Vector3(
                origin.x + ((Mathf.Cos(angle) * (point.x - origin.x))) - (Mathf.Sin(angle) * (point.y - origin.y)),
                origin.y + ((Mathf.Sin(angle) * (point.x - origin.x))) + (Mathf.Cos(angle) * (point.y - origin.y)),
                point.z);
        }

        /// <summary>
        /// check if the vector value is infinity
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        public static bool IsInfinity(Vector2 check)
        {
            return (float.IsInfinity(check.x) ||
                float.IsInfinity(check.y));
        }

        /// <summary>
        /// check if the vector value is infinity
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        public static bool IsInfinity(Vector3 check)
        {
            return (float.IsInfinity(check.x) ||
                float.IsInfinity(check.y) ||
                float.IsInfinity(check.z));
        }

        /// <summary>
        /// Return min value compare the two pass
        /// in values.
        /// </summary>
        /// <param name="a"> value a </param>
        /// <param name="b"> value b </param>
        /// <returns> smaller value </returns>
        public static float Min(float a, float b)
        {
            return (a < b) ? a : b;
        }

        /// <summary>
        /// Return max value compare the two pass 
        /// in values.
        /// </summary>
        /// <param name="a"> value a </param>
        /// <param name="b"> value b </param>
        /// <returns> larger value </returns>
        public static float Max(float a, float b)
        {
            return (a > b) ? a : b;
        }

        /// <summary>
        /// Check if the number is valid.
        /// </summary>
        /// <param name="vec"> vector to check </param>
        /// <returns> 
        /// true: is nan
        /// false: valid value
        /// </returns>
        public static bool IsNaN(Vector3 vec)
        {
            return (float.IsNaN(vec.x) || float.IsNaN(vec.y) || float.IsNaN(vec.z));
        }

        /// <summary>
        /// Check if the number is valid.
        /// </summary>
        /// <param name="vec"> vector to check </param>
        /// <returns> 
        /// true: is nan
        /// false: valid value
        /// </returns>
        public static bool IsNaN(Vector2 vec)
        {
            return (float.IsNaN(vec.x) || float.IsNaN(vec.y));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static float LawOfSine()
        {
            // Law of Sine
            // 
            // Formula:
            //      sin(A) / a = sin(B) / b
            //
            // a,b,c是邊
            // A,B,B是角
            // 都是相對應的. 
            // 角A對邊就是邊a.

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static float LawOfCosine()
        {
            // Law of Cosine
            // 
            // Formula:
            //      a^2 = b^2 + c^2 - 2bc[cos(angle A)]
            //
            // a,b,c是邊
            // A,B,B是角
            // 都是相對應的. 
            // 角A對邊就是邊a.

            return 0;
        }

        /// <summary>
        /// Use to check if something possible by percentage.
        /// 0 ~ 100.
        /// </summary>
        /// <returns></returns>
        public static bool IsPossible(float val)
        {
            float possibility = JCS_Random.Range(0, 100);

            return (val > possibility) ? true : false;
        }

        /// <summary>
        /// Traignle Sides List.
        /// </summary>
        public enum TriSides
        {
            hyp,
            opp,
            adj
        }

        /// <summary>
        /// Do Pythagorean Theorem.
        /// </summary>
        /// <param name="s1"> side 1 / hyp </param>
        /// <param name="s2"> side 2 </param>
        /// <param name="type"> target side you want to find. </param>
        /// <returns> result side. </returns>
        public static float PythagoreanTheorem(float s1, float s2, TriSides type)
        {
            switch (type)
            {
                case TriSides.hyp:
                    {
                        // a^2 + b^2 = c^2
                        float a = Mathf.Pow(s1, 2);
                        float b = Mathf.Pow(s1, 2);

                        return Mathf.Sqrt(a + b);
                    }

                case TriSides.opp:
                case TriSides.adj:
                    {
                        // c^2 - b^2 = a^2
                        float c = Mathf.Pow(s1, 2);
                        float b = Mathf.Pow(s2, 2);

                        float sub = c - b;

                        return Mathf.Sqrt(sub);
                    }
            }

            JCS_Debug.LogError("This not suppose to happen here...");

            return 0;
        }

        /// <summary>
        /// Get the digit number from  mutliple digit number.
        /// </summary>
        /// <param name="digit"> digit targeting. </param>
        /// <param name="number"> source number. </param>
        /// <returns> 
        /// single digit, if there are empty digit that are 
        /// zero at the left, it will return -1. 
        /// </returns>
        public static int GetSingleDigit(int digit, int number)
        {
            int totalDigit = number.ToString().Length;
            if (digit > totalDigit)
                return -1;

            int digitCount = (int)Mathf.Pow(10, digit);

            int remainder = number % digitCount;
            int po = digit - 1;
            int divider = (int)Mathf.Pow(10, po);

            return remainder / divider;
        }


        /// <summary>
        /// Count the digit by pass in number you want to count.
        /// 
        /// If the number if 0, the count will return 0.
        /// </summary>
        /// <param name="number"> number you want to count. </param>
        /// <returns> digit count. </returns>
        public static int DigitCount (int number)
        {
            int count = 0;

            while (number != 0)
            {
                number /= 10;
                ++count;
            }
            return count;
        }

        /// <summary>
        /// Count the digit by pass in number you want to count.
        /// 
        /// If the number if 0, the count will return 0.
        /// </summary>
        /// <param name="number"> number you want to count. </param>
        /// <returns> digit count. </returns>
        public static int DigitCountIncludeZero(int number)
        {
            if (number == 0)
                return 1;

            int count = 0;
            while (number != 0)
            {
                number /= 10;
                ++count;
            }
            return count;
        }

        /// <summary>
        /// Cross multiply a group of number.
        /// 
        /// x : y = a : b
        /// </summary>
        /// <returns> Return b. </returns>
        public static float CrossMultiply(float x, float y, float a)
        {
            // b = (a * y) / x
            return (a * y / x);
        }


        /// <summary>
        /// Convert degree to radian.
        /// </summary>
        /// <param name="deg"> degree you want to convert. </param>
        /// <returns> result in radian. </returns>
        public static float DegreeToRadian(float deg)
        {
            return deg * Mathf.PI / 180.0f;
        }

        /// <summary>
        /// Convert radian to degree.
        /// </summary>
        /// <param name="rad"> radian you want to convert. </param>
        /// <returns> result in degree. </returns>
        public static float RadianToDegree(float rad)
        {
            return rad * 180.0f / Mathf.PI;
        }

        /// <summary>
        /// Cosine in degree.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static float Cos(float deg)
        {
            return Mathf.Cos(DegreeToRadian(deg));
        }

        /// <summary>
        /// Sine in degree.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static float Sin(float deg)
        {
            return Mathf.Sin(DegreeToRadian(deg));
        }

        /// <summary>
        /// Tangent in degree.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static float Tan(float deg)
        {
            return Mathf.Tan(DegreeToRadian(deg));
        }

        /// <returns></returns>
        /// <summary>
        /// Find the point on the circle line base on the degree. (x-axis)
        /// </summary>
        /// <param name="objPos"> Current effect object's position. </param>
        /// <param name="origin"> origin point. </param>
        /// <param name="deg"> degree </param>
        /// <param name="radius"> radius from the origin. </param>
        /// <returns> Vector3 : point on the circle. </returns>
        public static Vector3 CirclePositionX(Vector3 origin, float deg, float radius, Vector3 objPos)
        {
            return CirclePosition(origin, deg, radius, objPos, JCS_Axis.AXIS_X);
        }

        /// <summary>
        /// Find the point on the circle line base on the degree. (y-axis)
        /// </summary>
        /// <param name="objPos"> Current effect object's position. </param>
        /// <param name="origin"> origin point. </param>
        /// <param name="deg"> degree </param>
        /// <param name="radius"> radius from the origin. </param>
        /// <returns> Vector3 : point on the circle. </returns>
        public static Vector3 CirclePositionY(Vector3 origin, float deg, float radius, Vector3 objPos)
        {
            return CirclePosition(origin, deg, radius, objPos, JCS_Axis.AXIS_Y);
        }

        /// <summary>
        /// Find the point on the circle line base on the degree. (z-axis)
        /// </summary>
        /// <param name="objPos"> Current effect object's position. </param>
        /// <param name="origin"> origin point. </param>
        /// <param name="deg"> degree </param>
        /// <param name="radius"> radius from the origin. </param>
        /// <returns> Vector3 : point on the circle. </returns>
        public static Vector3 CirclePositionZ(Vector3 origin, float deg, float radius, Vector3 objPos)
        {
            return CirclePosition(origin, deg, radius, objPos, JCS_Axis.AXIS_Z);
        }

        /// <summary>
        /// Find the point on the circle line base on the degree.
        /// </summary>
        /// <param name="objPos"> Current effect object's position. </param>
        /// <param name="origin"> origin point. </param>
        /// <param name="deg"> degree </param>
        /// <param name="radius"> radius from the origin. </param>
        /// <param name="axis"> Around which axis? </param>
        /// <returns> Vector3 : point on the circle. </returns>
        public static Vector3 CirclePosition(Vector3 origin, float deg, float radius, Vector3 objPos, JCS_Axis axis)
        {
            deg = deg % 360.0f;

            float rad = DegreeToRadian(deg);

            Vector3 circlePos = origin;

            // add offset to current distance (hyp)
            float hyp = radius;
            float opp = Mathf.Sin(rad) * hyp;
            float adj = Mathf.Cos(rad) * hyp;

            switch (axis)
            {
                case JCS_Axis.AXIS_X:
                    circlePos.x = objPos.x;
                    circlePos.y += adj;
                    circlePos.z += opp;
                    break;
                case JCS_Axis.AXIS_Y:
                    circlePos.x += adj;
                    circlePos.y = objPos.y;
                    circlePos.z += opp;
                    break;
                case JCS_Axis.AXIS_Z:
                    circlePos.x += adj;
                    circlePos.y += opp;
                    circlePos.z = objPos.z;
                    break;
            }

            return circlePos;
        }

        /// <summary>
        /// Truncate float number.
        /// 
        /// If 'digits'=2 and 'value'=1.345698F:
        ///   1.345698F => 1.34
        /// 
        /// If 'digits'=2 and 'value'=1.300000F:
        ///   1.300000F => 1.30
        /// 
        /// SOURCE(jenchieh): https://social.msdn.microsoft.com/Forums/vstudio/en-US/a8092fd2-1080-416c-8ae1-2bad8c013a21/how-to-round-off-a-float-to-2-decimal-places?forum=csharpgeneral
        /// </summary>
        /// <param name="val"> Value to do truncate. </param>
        /// <param name="digits"> Target shown digit. </param>
        /// <returns> Result value. </returns>
        public static float Truncate(float val, int digits)
        {
            double mult = Math.Pow(10.0, digits);
            double result = Math.Truncate(mult * val) / mult;
            return (float)result;
        }

        /// <summary>
        /// Find the greatest common factor.
        /// 最大公因數.
        /// 
        /// SOURCE: https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
        /// AUTHOR: Drew Noakes
        /// </summary>
        /// <param name="a"> number a. </param>
        /// <param name="b"> number b. </param>
        /// <returns>
        /// greatest common factor for 'a' nd 'b'.
        /// </returns>
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return (a == 0) ? b : a;
        }
    }
}
