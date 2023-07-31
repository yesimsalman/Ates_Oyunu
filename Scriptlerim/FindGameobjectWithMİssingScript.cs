using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

public class FindGameobjectWithMİssingScript : MonoBehaviour
{
  [MenuItem("Component/ Find gameObjects with missing scripts")]
  public static void FindGameObjects()
    {
        string[] prefabPaths = AssetDatabase.GetAllAssetPaths().Where(path => path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();

        GameObject parent = null;
        foreach (string path in prefabPaths)
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            Component[] components = prefab.GetComponents<Component>();

            foreach(Component component in components)
            {
                if (component == null)
                {
                    if (parent == null)
                    {
                        parent = new GameObject("Missing Component Objects");

                    }
                    GameObject instance = Instantiate(prefab, parent.transform);
                    break;
                }
            }
        }


    }
    
}


