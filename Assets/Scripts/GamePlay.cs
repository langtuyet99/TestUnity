using UnityEngine;
using System.Collections;

public class GamePlay : MonoBehaviour {

   public long counter;
    public static GamePlay Instance;
   
    // Use this for initialization
    void Start() {
        Instance = this;

    }

    // Update is called once per frame
    void Update() {

        if (counter++ == 100)
        {
           

        }

    }

    public void DestroyObj()
    {
       // Destroy(gameObject);
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.collider.name);
    }
}
