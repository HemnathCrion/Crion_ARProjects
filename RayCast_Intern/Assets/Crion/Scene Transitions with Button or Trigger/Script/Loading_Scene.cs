using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading_Scene : MonoBehaviour
{
    public PlayerController playerController;
    private float currentValue = 20f;
    private void Start()
    {
          
    }
    public void SceneManage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        playerController.player.transform.localScale = Vector3.one * 5;
        playerController.speed += currentValue;
       
    }
    //public void ExitButton()
    //{
    //    SceneManager.LoadScene("Scene UI 2");
    //}

}
