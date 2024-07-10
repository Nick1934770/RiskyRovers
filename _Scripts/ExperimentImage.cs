using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ExperimentImage : MonoBehaviour
{
    public Sprite rock4;
    public Sprite rock5;
    public Sprite defaultImage;
    public Image dataImage;

    public void ChangeImage(int num) {
        switch(num) {
            case 4:
                
                dataImage.GetComponent<Image>().sprite = rock4;
            break;

            case 5:
                dataImage.GetComponent<Image>().sprite = rock5;
            break;

            default:
           
                dataImage.GetComponent<Image>().sprite = defaultImage;
            break;

        }
    }
}
