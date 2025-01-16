using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
     Rigidbody2D rg;

    public float speed;

    public GameObject gameOverObj;

    private void Start()
    {
        Time.timeScale = 1; 
        rg = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Flap();
            //rg.AddForce(Vector2.up * speed);   
        }
    }
    
    private void Flap()
    {
        rg.velocity = Vector2.zero;
        rg.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
    }

    public void resetGame()
    {
        SceneManager.LoadScene(0); 
    }

    void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0 ;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

}
