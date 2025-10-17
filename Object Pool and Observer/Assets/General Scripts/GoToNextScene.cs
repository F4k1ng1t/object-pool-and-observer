using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
    public void NextScene()
    {
        int x = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(x == 0 ? 1 : 0);
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 160, 10, 150, 50), "Next Scene"))
        {
            NextScene();
        }
    }
}
