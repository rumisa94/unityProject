using UnityEngine;
using System.Collections;

public class example : MonoBehaviour {
    public Color start=Color.red;
    public Color end= Color.green;
    public Renderer ballR;
    public float duration = 1.0F;
    // Use this for initialization
    void Start () {
        Debug.Log("Hi developer");
        Debug.Log("trying the reposotry");
        ballR = GetComponent<Renderer>();
        
}
	
	// Update is called once per frame
	void Update () {
        float lerp = Mathf.PingPong(Time.time, duration) / duration; ;
        ballR.material.color = Color.Lerp(start, end, lerp);

	
	}
}
