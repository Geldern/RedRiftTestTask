using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GM.Score.CurrentScore ++;
        if (collision.gameObject.tag == "Platform")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }
    }
}
