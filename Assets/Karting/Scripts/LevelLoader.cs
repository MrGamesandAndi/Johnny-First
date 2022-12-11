using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] List<GameObject> tracks;

    int currentLevelIndex = 0;

    private void Awake()
    {
        currentLevelIndex = PlayerPrefs.GetInt("PlayerIndex");
        tracks[currentLevelIndex].SetActive(true);
    }
}
