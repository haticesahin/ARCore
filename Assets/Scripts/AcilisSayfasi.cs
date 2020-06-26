using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcilisSayfasi : MonoBehaviour
{
   public void Basla()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
