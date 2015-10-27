using System.Collections;
using UnityEngine;

public class Gachs : MonoBehaviour {

    long counter = 0;
    public GameObject gach;
    // Use this for initialization
    void Start() {
        //for (int i = 0; i < 50; i++)
        //{
        //    GameObject go = (GameObject)Instantiate(gach);
        //    go.transform.position=new Vector2(i * 10, i * 5);

        //}

	}

    // Update is called once per frame
    void Update() {

        if (counter++ == 200)
        {
            Debug.Log(counter);
            GameObject obj = GameObject.Find("gach");
            if (obj!=null)
                Destroy(obj);
            else
                Debug.Log("fsdfsd");

        }


 
    }
}
