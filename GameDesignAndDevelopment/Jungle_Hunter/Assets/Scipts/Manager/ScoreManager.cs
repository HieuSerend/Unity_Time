using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;
    public float timeScore = 0.0f;
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        timeScore += Time.deltaTime;
    }

    public int GetTotalScore()
    {
        return score + Mathf.FloorToInt(timeScore);
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}