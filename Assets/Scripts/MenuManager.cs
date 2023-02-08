using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject planetCountInput;

    public void StartGame()
    {
        MainManager.Instance.planetCount = int.Parse(planetCountInput.GetComponent<TMP_InputField>().text);
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }
}
