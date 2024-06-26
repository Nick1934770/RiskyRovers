using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class FileExplorer : MonoBehaviour
{
    string path;
    public GameObject rover;

    public void OpenExplorer()
    {
        rover = GameObject.Find("Rover");

        string basePath = "C:\\Dumbtiger\\movement-files";
        path = EditorUtility.OpenFilePanel("", basePath, "");
        if (path.Length != 0)
        {
            int startIndex = basePath.Length+1; // Index of the comma
            string modifiedString = path.Substring(startIndex);
            Debug.Log(modifiedString);
            if (modifiedString == "forward-10.txt")
            {
                rover.transform.Translate(2, 0,0);
            }

        }
        else
        {
            Debug.Log("no name");

        }
    }
}
