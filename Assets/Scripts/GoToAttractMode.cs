using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToAttractMode : MonoBehaviour {
    public Text timeText;
    public Text secondsText;
    public string attractModeSceneName;
    public int waitTime;
    private float lastInteractionTime;
    private float lastTextChangeTime;
    private void Start()
    {
        lastInteractionTime = Time.time;
        lastTextChangeTime = Time.time;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            lastInteractionTime = Time.time;
            UpdateUIText();
        }
        if(Time.time - lastInteractionTime > waitTime)
        {
            SceneManager.LoadScene(attractModeSceneName);
        }
        else
        {
            if(Time.time - lastTextChangeTime > 1)
            {
                UpdateUIText();
                lastTextChangeTime = Time.time;
            }
        }
    }

    private void UpdateUIText()
    {
        int secondsLeft = waitTime - Mathf.RoundToInt(Time.time - lastInteractionTime);
        timeText.text = secondsLeft.ToString();
        secondsText.text = secondsLeft == 1 ? "Second" : "Seconds";
    }
}
