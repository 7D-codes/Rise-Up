using UnityEngine;
using TMPro;
public class GameHandler : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public int Score;
    public CameraSystem cam;

    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        Score =  Mathf.Abs((int)cam.transform.position.y);
        scoreText.text = Score.ToString();
    }

    
}
