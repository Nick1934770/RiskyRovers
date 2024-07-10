using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class DataLogFiles : MonoBehaviour
{
   string path;

   public void OpenExplorer(){
      path = EditorUtility.OpenFilePanel("Users","unouser","Pictures");
   }
}
