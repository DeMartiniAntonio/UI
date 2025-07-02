using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject gameMenu;

    public void PlayGame()
    {
        mainMenu.SetActive(false);
        gameMenu.SetActive(true);
    
    }

    public void ReturnToMainMenu()
    {
        mainMenu.SetActive(true);
        gameMenu.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }

}
