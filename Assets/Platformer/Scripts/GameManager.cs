using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int score = 0;
    

    // Update is called once per frame
    void Update()
    {
        int intTime = 400 - (int)Time.realtimeSinceStartup;
        string timeStr = $"MARIO                      WORLD               Time: \n000000           x{score}         1-1                     {intTime}";
        timerText.text = timeStr;
    }
}
