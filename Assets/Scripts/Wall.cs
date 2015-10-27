using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
    float currentScaleY;
    float scaleSpeed = 1.5f;
	// Use this for initialization
	void Start () {
        currentScaleY = this.transform.localScale.y;
    }
	
	// Update is called once per frame
	void Update () {
        //if (WallCollection.counter > 10)
        //{
            moveLeft(2.5f);
        currentScaleY += scaleSpeed;
        if (currentScaleY > WallCollection.maxScaleY || currentScaleY < WallCollection.minScaleY)
        {
            scaleSpeed *= -1;
        }
        this.transform.localScale = new Vector3(this.transform.localScale.x, currentScaleY);

        //}
    }

    void moveLeft(float distance)
    {
        this.transform.position = new Vector2(this.transform.position.x - distance, this.transform.position.y);

        if (this.transform.position.x < Jumper.instance.transform.position.x - 69)
        {
            this.transform.position = new Vector2(WallCollection.lastWallPosX + Random.Range(69, 96),
                this.transform.position.y);
            WallCollection.lastWallPosX = this.transform.position.x;
            //BoxCollider2D bc2d = GetComponent<BoxCollider2D>();
            //bc2d.transform.
        }
    }



}
