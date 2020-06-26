using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anasayfa_RestartController : MonoBehaviour
{
    public void Anasayfa()
    {
        SceneManager.LoadScene("Anasayfa");
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
