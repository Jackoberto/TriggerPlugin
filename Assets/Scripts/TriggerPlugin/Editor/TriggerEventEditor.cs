using UnityEditor;

namespace TriggerPlugin.Editor
{
    [CustomEditor(typeof(TriggerEvent))]
    [CanEditMultipleObjects]
    public class TriggerEventEditor : UnityEditor.Editor
    {
        private SerializedProperty _tagToCompare, _twoD, _isTrigger;
        private void OnEnable()
        {
            _tagToCompare = serializedObject.FindProperty("tagToCompare");
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            serializedObject.Update();
            serializedObject.ApplyModifiedProperties();
        }
    }
}