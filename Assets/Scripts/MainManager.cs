using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    public int m_planetCount = 8;
    public int planetCount
    {
        get { return m_planetCount; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative planet count!");
            }
            else
            {
                m_planetCount = value; // original setter now in if/else statement
            }
        }
    }

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
