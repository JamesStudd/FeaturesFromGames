using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Utility
{
    public static class SearchUtility
    {
#if UNITY_EDITOR
        public static List<T> FindScriptableObjects<T>() where T : ScriptableObject
        {
            var guids = AssetDatabase.FindAssets("t:" + typeof(T).Name);
            var scriptableObjects = new List<T>();

            foreach (var guid in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                var scriptableObject = AssetDatabase.LoadAssetAtPath<T>(path);

                if (scriptableObject != null)
                {
                    scriptableObjects.Add(scriptableObject);
                }
            }

            return scriptableObjects;
        }

        public static T FindScriptableObject<T>() where T : ScriptableObject
        {
            var guids = AssetDatabase.FindAssets("t:" + typeof(T).Name);
            var scriptableObjects = new List<T>();

            foreach (var guid in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                var scriptableObject = AssetDatabase.LoadAssetAtPath<T>(path);

                if (scriptableObject != null)
                {
                    scriptableObjects.Add(scriptableObject);
                }
            }

            if (scriptableObjects.Count > 1)
            {
                Debug.LogWarning($"Found multiple {typeof(T).Name}, returning first.");
            }

            return scriptableObjects[0];
        }
#endif
    }
}