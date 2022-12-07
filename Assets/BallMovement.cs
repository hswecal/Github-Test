using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallMovement : MonoBehaviour
{

    Vector3 dir;
    int player1Goal = 0;
    int player2Goal = 0;
    TextMeshProUGUI scoreText;
    int speed = 5;

    private void ResetBall()
    {
        scoreText.text = player1Goal + " - " + player2Goal;
        transform.position = new Vector3(0, 0, 0);
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
        speed = 5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dir.x *= -1;
            speed += 1;
        }
        else
        {
            dir.y *= -1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();

        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1,2), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (speed >= 13)
        {
            speed = 18;
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
        transform.position += dir.normalized * speed * Time.deltaTime;
        if (transform.position.x > 10)
        {
            player1Goal += 1;
            ResetBall();
        }
        else if (transform.position.x < -10)
        {
            player2Goal += 1;
            ResetBall();
        }
    }
}
