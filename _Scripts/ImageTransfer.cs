using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class ImageTransfer : MonoBehaviour
{
    public Button transferButton; // Assign the button from the Inspector
    public Texture2D texture2D; // Assign the Texture2D from the Inspector

    public string customFolderPath = "C:/Data"; // Define your custom folder path here

    void Start()
    {
        transferButton.onClick.AddListener(TransferImage);
    }

    void TransferImage()
    {
      
            if (texture2D == null)
        {
            Debug.LogError("Texture2D is not assigned.");
            return;
        }

        // Convert Texture2D to PNG
        byte[] bytes = texture2D.EncodeToPNG();

        // Define the path to save the image
         string picturesFolderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
        string path = Path.Combine(picturesFolderPath, "MontDiener.png");
     

        // Write the bytes to a file
        File.WriteAllBytes(path, bytes);

        // Log the path for debugging purposes
        Debug.Log("Image saved to: " + path);
    }

 
}
