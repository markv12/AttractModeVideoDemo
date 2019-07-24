using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMainMenu : MonoBehaviour {

    public string mainMenuSceneName;

    public Text demoText;

    private const float FLASHES_PER_SECOND = 1.5f;
    private static readonly Color FLASH_COLOR = new Color(1, 1, 1, 0.75f);
    void Update () {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
        demoText.color = (Mathf.RoundToInt(Time.time * FLASHES_PER_SECOND) % 2 == 0) ? FLASH_COLOR : Color.clear;
    }
}
