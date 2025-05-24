using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + ScoreManager.Instance.GetTotalScore();
    }
}