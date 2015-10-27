using UnityEngine;
using System.Collections;

public class Jumper : MonoBehaviour
{
    const string PLAYER_HIGHEST_SCORE_KEY = "highestScore";

    const float defaultPositionX = -40f;
    const float defaultPositionY = 50f;

    public static Jumper instance;
    long score, counter, highestScore;
    public bool losing;
    Rigidbody2D rigid2d; 

    void Start () {
        instance = this;
        losing = false;
        counter = score;
        string playerHighestScore = PlayerPrefs.GetString(PLAYER_HIGHEST_SCORE_KEY);
        if (playerHighestScore == "")
        {
            playerHighestScore = "0";
            PlayerPrefs.SetString(PLAYER_HIGHEST_SCORE_KEY, playerHighestScore);
            highestScore = 0;
        }
        else
        {
            highestScore = long.Parse(playerHighestScore);
        }

        rigid2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        if (losing)
        {
            if (Input.GetMouseButtonDown(0)) {
                this.reInit();
                WallCollection.instance.reInit();
            }

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
                jump();

            if (counter++ > 10)
            {
                score += counter;
                counter = 0;

            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //switch (col.collider.name)
        //{
        //    case "ground":
        //    case "Wall": losing = true; break;
        //}
        losing = true;
        //Debug.Log(col.collider.name);
    }
    
    void OnGUI()
    {
        if (losing)
        {
            string message = "You lost! \n" +
                "Current Score: " + score +
                "\nHighest Score: " + highestScore
                + "\n\nClick anywhere to restart!";
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 100f), message);
            highestScore = score > highestScore ? score : highestScore;
            saveUserInfo();
        }
        else
        {
            string message = "Score: " + score;
            GUI.Label(new Rect(Screen.width/6, Screen.height/30 , 150f, 100f), message);
        }
        
    }

    void jump()
    {
        rigid2d.velocity = new Vector2(rigid2d.velocity.x, 96);
    }
    
    void reInit()
    {
        losing = false;
        score = 0;
        this.transform.position = new Vector3(defaultPositionX, defaultPositionY);
    }

    void saveUserInfo()
    {
        PlayerPrefs.SetString(PLAYER_HIGHEST_SCORE_KEY, highestScore.ToString());
    }
}
