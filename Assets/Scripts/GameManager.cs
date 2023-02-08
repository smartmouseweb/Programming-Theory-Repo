using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject planetPrefab;
    public GameObject starPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject star = Instantiate(starPrefab, starPrefab.transform.position, starPrefab.transform.rotation);

        
        for (int i = 1; i <= (MainManager.Instance ? MainManager.Instance.planetCount : 8); i++)
        {
            GameObject planet = Instantiate(planetPrefab, new Vector3(0, 0, 6+(4*i)), planetPrefab.transform.rotation);
            planet.GetComponent<Planet>().centerObject = star;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
