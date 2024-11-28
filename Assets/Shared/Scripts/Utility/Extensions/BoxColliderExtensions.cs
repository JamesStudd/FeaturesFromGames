using UnityEngine;

namespace Utility.Extensions
{
    public static class BoxColliderExtensions
    {
        public static Vector3 GetBoxColliderRandomPosition(this BoxCollider boxCollider)
        {
            // Get the BoxCollider's center in world space
            var center = boxCollider.transform.TransformPoint(boxCollider.center);

            // Get the world size by accounting for the parent scale
            var worldScale = boxCollider.transform.lossyScale;
            var worldSize = Vector3.Scale(boxCollider.size, worldScale);

            // Calculate min and max bounds in world space
            var minX = center.x - worldSize.x / 2;
            var maxX = center.x + worldSize.x / 2;

            var minY = center.y - worldSize.y / 2;
            var maxY = center.y + worldSize.y / 2;

            var minZ = center.z - worldSize.z / 2;
            var maxZ = center.z + worldSize.z / 2;

            // Generate a random position inside the box collider in world space
            return new Vector3(
                Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                Random.Range(minZ, maxZ)
            );
        }
    }
}