using UnityEngine;

namespace Kogane
{
    public static class CameraExtensionMethods
    {
        public static Vector2 ScreenToWorldPoint2D
        (
            this Camera self,
            Vector3     position
        )
        {
            return self.ScreenToWorldPoint( position );
        }

        public static Vector2 ScreenToWorldPoint2D
        (
            this Camera                  self,
            Vector3                      position,
            Camera.MonoOrStereoscopicEye eye
        )
        {
            return self.ScreenToWorldPoint( position, eye );
        }
    }
}