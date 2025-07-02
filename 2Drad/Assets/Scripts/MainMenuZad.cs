using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuZad : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Slider slider;
    [SerializeField] private Toggle toggle;

    private void Start()
    {
        slider.maxValue = 100;
        slider.wholeNumbers = true;
    }
    private void Update()
    {
        text.text = slider.value.ToString() + "%";

    }

    public void ToggleSlideBar() {
        if (toggle.isOn == true)
        {
            slider.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
        }
        else
        {
            slider.gameObject.SetActive(false);

            text.gameObject.SetActive(false);
        }
    }

    public void OpenOptionsGame()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);

    }

    public void ReturnToMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

}
