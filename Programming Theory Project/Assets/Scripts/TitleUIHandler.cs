using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIHandler : MonoBehaviour
{

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
