using UnityEngine;

namespace Extensions
{
    public static class DestroyExt
    {
        public static void DestroyGameObject(this Component component, float time = 0) =>
            Object.Destroy(component.gameObject, time);

        public static void DestroySelf(this Component component, float time = 0) => Object.Destroy(component, time);
    }
}