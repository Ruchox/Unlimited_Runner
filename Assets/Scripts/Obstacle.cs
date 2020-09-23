/*
 * Created by: Ruel Coy
 *
 * Purpose: Handles Obstacle behavior 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public Text scoreText;
    private int _totalScore = 0;
    public GameObject player;
    public float speed;

    private void Start()
    {
        player = GameObject.Find("Player");
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(player.gameObject);
        }
        if(collision.gameObject.CompareTag("End"))
        {
            DestroyObstacle();
        }
        if (collision.gameObject.CompareTag("Score"))
        {
            
            _totalScore++;
            Debug.Log(_totalScore);
            scoreText.text = _totalScore.ToString();
        }
    }
  
    private void DestroyObstacle()
    {
        Destroy(this.gameObject);
    }
}
