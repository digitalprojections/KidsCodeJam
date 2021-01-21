using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public void goToSelectionMenu(){
        SceneManager.LoadScene("SelectionMenu");
    }
}
