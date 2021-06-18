using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaPreguntas : MonoBehaviour
{
    public GameObject Preg;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void preguntacion()
    {

        Preg.SetActive(true);
        Time.timeScale = 1;

    }

    public void Pausar()
    {

        Preg.SetActive(false);

        
    }

    
}
