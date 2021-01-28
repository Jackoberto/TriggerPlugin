using UnityEngine;

namespace Extensions
{
    public static class Toggles
    {
        public static void Toggle(this Behaviour behaviour) => behaviour.enabled = !behaviour.enabled;
        public static void Toggle(this Renderer renderer) => renderer.enabled = !renderer.enabled;
        public static void Toggle(this Collider collider) => collider.enabled = !collider.enabled;
    }
}