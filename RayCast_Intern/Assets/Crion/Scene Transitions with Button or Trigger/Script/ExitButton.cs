using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void SceneExitButton()
    {
        SceneManager.LoadScene("Scene UI 2");
    }
}
