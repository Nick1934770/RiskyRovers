using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class FileExplorerDataLog : MonoBehaviour
{
    string path;
  
   public void OpenExplorer(){
     string basepath = "C:\\Pictures";
    path = EditorUtility.OpenFilePanel("Pictures","Pictures","");
   }
}
