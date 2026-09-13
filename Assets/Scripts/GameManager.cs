using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [Header("Estadísticas")]
    public int score = 0;
    public int lives = 3;
    public float timeRemaining = 60f;
    private int highscore = 0;

    [Header("UI")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI timerText;
    public GameObject resultsPanel; // Arrastra aquí un Panel de UI
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI highscoreText;

    private bool isGameOver = false;

    void Awake() { instance = this; }

    void Start()
    {
        // Cargar el Highscore guardado
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        if (resultsPanel != null) resultsPanel.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateUI();
        }
        else
        {
            EndGame();
        }
    }

    void UpdateUI()
    {
        if (timerText != null) timerText.text = "Tiempo: " + Mathf.Ceil(timeRemaining);
        if (scoreText != null) scoreText.text = "Score: " + score;
        if (livesText != null) livesText.text = "Vidas: " + lives;
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;
        score += amount;
    }

    public void LoseLife()
    {
        if (isGameOver) return;
        lives--;
        if (lives <= 0) EndGame();
    }

    void EndGame()
    {
        isGameOver = true;
        
        // Verificar si hay nuevo Highscore
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }

        ShowResults();
    }

    void ShowResults()
    {
        if (resultsPanel != null)
        {
            resultsPanel.SetActive(true);
            finalScoreText.text = "Puntos: " + score;
            highscoreText.text = "Record: " + highscore;
        }
        // Reinicia después de 5 segundos
        Invoke("RestartLevel", 5f);
    }

    void RestartLevel() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
}