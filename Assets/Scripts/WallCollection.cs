using UnityEngine;
using System.Collections;

public class WallCollection : MonoBehaviour {

    public GameObject Wall;
    public static float lastWallPosX=200;
    ArrayList wallListUpper = new ArrayList();
    ArrayList wallListLower = new ArrayList();

    public static float maxScaleY = 300;
    public static float minScaleY = 100;

    public static WallCollection instance;

    void Start()
    {
        instance = this;
        float tmp=0;
        for (int i = 0; i <7; i++)
        {
            tmp += Random.Range(60, 90);

            GameObject upperWall = Instantiate(Wall);
            upperWall.transform.position = new Vector2(i * 55 + tmp, 2);
            upperWall.transform.localScale = new Vector3(upperWall.transform.localScale.x, Random.Range(minScaleY, maxScaleY));
            wallListUpper.Add(upperWall);

            GameObject lowerWall = Instantiate(Wall);
            lowerWall.transform.position = new Vector2(i * 55 + tmp, 110);
            lowerWall.transform.localScale = new Vector3(upperWall.transform.localScale.x, Random.Range(minScaleY, maxScaleY));
            wallListLower.Add(lowerWall);

        }
    }

    // Update is called once per frame
    void Update () {
        //if (counter++ > 10)
        //    counter = 0;

        if (Jumper.instance.losing)
        {
            //Debug.Log("abd");
            foreach (GameObject wall in wallListUpper)
            {
                wall.SetActive(false);
            }

            foreach (GameObject wall in wallListLower)
            {
                wall.SetActive(false);
            }
        }
	}

    public void reInit()
    {
        float tmp = 0;
        int i = 0;
        foreach (GameObject wall in wallListUpper)
        {
            wall.transform.position = new Vector2(i * 55 + tmp, 2);
            wall.transform.localScale = new Vector3(wall.transform.localScale.x, Random.Range(minScaleY, maxScaleY));
            tmp += Random.Range(60, 90);
            i++;
            wall.SetActive(true);
        }

        tmp = i= 0;
        foreach (GameObject wall in wallListLower)
        {
            wall.transform.position = new Vector2(i * 55 + tmp, 110);
            wall.transform.localScale = new Vector3(wall.transform.localScale.x, Random.Range(minScaleY, maxScaleY));
            tmp += Random.Range(60, 90);
            i++;
            wall.SetActive(true);
        }
    }
}
