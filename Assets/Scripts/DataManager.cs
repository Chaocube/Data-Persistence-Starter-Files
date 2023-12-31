using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string PlayerName ;
    public int Score ;

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
    
}
