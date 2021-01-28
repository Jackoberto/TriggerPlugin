using UnityEngine;

namespace Extensions
{
    public static class CloningExt
    {
        public static GameObject CloneGameObject(this Component component, Transform parent,
            bool staysInWorldPosition = false) =>
            Object.Instantiate(component.gameObject, parent, staysInWorldPosition);

        public static GameObject CloneGameObject(this Component component) => Object.Instantiate(component.gameObject);

        public static GameObject CloneGameObject(this Component component, Vector3 position, Quaternion quaternion) =>
            Object.Instantiate(component.gameObject, position, quaternion);

        public static GameObject CloneGameObject(this Component component, Vector3 position, Quaternion quaternion,
            Transform parent) => Object.Instantiate(component.gameObject, position, quaternion, parent);
    }
}
