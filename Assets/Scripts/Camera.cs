using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("asd");
        //Vector3 pos = new Vector3(Jumper.instance.transform.position.x,
        //    Jumper.instance.transform.position.y, Jumper.instance.transform.position.z);
        //transform.position = Jumper.instance.transform.position;
        //Debug.Log(pos);
        //Camera camera = GetComponent<Camera>();
        //Vector3 point = camera.(target.position);
        //Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
        //Vector3 destination = transform.position + delta;
        //transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}
