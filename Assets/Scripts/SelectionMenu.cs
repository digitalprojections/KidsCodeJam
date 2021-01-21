using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionMenu : MonoBehaviour
{
public void goBackToLoginMenu(){
        SceneManager.LoadScene("LoginMenu");
    }
    public void goToSettings(){
        SceneManager.LoadScene("Settings");
    }
    public void goToFirstChapter(){
        SceneManager.LoadScene("ChapterOne");
    }
}
