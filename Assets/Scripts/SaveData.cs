using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static SaveData Instance;

    public InputField inputPlayerName;
    public string PlayerName;
    public string BestPlayer;
    public int bestScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GetPlayerName()
    {
        if (inputPlayerName.text != null)
        {
            PlayerName = inputPlayerName.text;
        }
    }
}
