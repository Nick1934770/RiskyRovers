using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class FileManagerScript1 : MonoBehaviour
{
    string path;
    //public RawImage image;

    public void OpenExplorerer()
    {
        path = EditorUtility.OpenFilePanel("Overwrite with png","","png");
   //     GetImage();
    }

   // void GetImage()
   // {
   //     if(path != null)
  //      {
    //        UpdateImage();
   //     }

  //  }
  //  void UpdateImage()
  //  {
      //  WWW www = new WWW("file://" + path);
   //     image.texture = www.texture;
   // }
}
