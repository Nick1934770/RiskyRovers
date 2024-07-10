using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject [] characterPrefabs;
    //public Sprite[] characterPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;

    void Start() {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        //Sprite prefab = characterPrefabs[selectedCharacter];
        GameObject prefab = characterPrefabs [selectedCharacter];
        //Sprite clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        label.text = prefab.name;
        //this.GetComponent<SpriteRenderer>().sprite = prefab;
    }
}
