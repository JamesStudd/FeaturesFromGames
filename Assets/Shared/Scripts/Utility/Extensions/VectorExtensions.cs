using UnityEngine;

namespace Utility.Extensions
{
    public static class VectorExtensions
    {
        public static bool IsCloseToZero(this Vector2 vec, float epsilon = 1E-6f)
        {
            return vec.x.IsCloseToZero(epsilon) && vec.y.IsCloseToZero(epsilon);
        }

        public static bool AreNearlyEqual(this Vector2 vec, Vector2 other)
        {
            return Vector2.Distance(other, vec) <= Mathf.Epsilon;
        }
        
        public static bool AreNearlyEqual(this Vector3 vec, Vector3 other, float distance)
        {
            return Vector3.Distance(other, vec) <= distance;
        }

        public static float RandomBetweenLimits(this Vector2 vector2)
        {
            return UnityEngine.Random.Range(vector2.x, vector2.y);
        }
        
        public static int RandomBetweenLimits(this Vector2Int vector2)
        {
            return UnityEngine.Random.Range(vector2.x, vector2.y);
        }
    }
}