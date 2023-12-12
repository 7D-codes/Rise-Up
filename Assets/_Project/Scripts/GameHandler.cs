using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    private GameObject Counter;
    private TextMeshProUGUI scoreText;
    private int Score;
    public float Speed = 1;

    void Start()
    {
        Speed = 1;
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();

        Counter = new GameObject("NewCounter");
        Counter.transform.position = Vector3.zero;
    }

    void Update()
    {
        Counter.transform.Translate(0, -Speed * Time.deltaTime, 0);
        Score = Mathf.Abs((int)Counter.transform.position.y);
        scoreText.text = Score.ToString();

        IncreaseSpeed();
    }

    void IncreaseSpeed()
    {
        if (Speed <= 15)
            Speed += 0.00025f;
        else
            Speed = 15;
    }
}
