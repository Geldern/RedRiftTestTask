using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlanetData Planet;
    public ScoreData Score;
    public GameObject Ball;
    private bool Touched = false;


    void Start()
    {
        Camera.main.backgroundColor = Planet.SkyColor;
        Physics2D.gravity = new Vector3(0, -Planet.Gravity, 0);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Touched = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Touched = false;
        }

        
    }

    private void FixedUpdate()
    {
        if (Touched)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Ball.GetComponent<Rigidbody2D>().AddForce(new Vector2((mousePos.x - Ball.transform.position.x), 0) * 3);
        }
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
