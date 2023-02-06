using System.Collections;
using System.Collections.Generic;
using TMPro;
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
}
