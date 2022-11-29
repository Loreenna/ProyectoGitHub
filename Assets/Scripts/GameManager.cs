using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int puntos = 0;

    public Text ContadorEstelar;


    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

    }

    public void LoadLevel(int sceneIndex)
    {

        SceneManager.LoadScene(sceneIndex);

    }
    
    public void RecolectarEstrella(GameObject moneda)
    {
        puntos++;
        ContadorEstelar.text = puntos.ToString();
        Destroy(moneda);
    }
}
