using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour
{
    public float trambolineBouncePower;
    public float horizontalSpeed;
    private float horizontal;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lastScoreText;
    public GameObject restartPanel;
    private int score = 0;
    void Update()
    {
        scoreText.text = "Score : " + score.ToString();
        horizontal = Input.GetAxis("Horizontal") * horizontalSpeed;
        transform.Translate(horizontal * Time.deltaTime, 0f, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Time.timeScale = 0.0f;
            restartPanel.SetActive(true);
            lastScoreText.text = "Your Score : " + score.ToString();
            
        }
        if(collision.gameObject.tag == "Platform")
        {
            score += (int)transform.position.y * 10;
        }
        if(collision.gameObject.tag == "Tramboline")
        {
            Vector2 bounce = gameObject.GetComponent<Rigidbody2D>().velocity;
            bounce.y = trambolineBouncePower;
            gameObject.GetComponent<Rigidbody2D>().velocity = bounce;
        }
    }
}
