using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Create : MonoBehaviour {
    public GameObject plane;
    public GameObject plane3;
    public GameObject boomplane;

    private float alltime;
    private float nowtiome;

    public Text time;
    public Text win;
    public Text lose;

 //   private Rigidbody2D rbplane;
 //   private Rigidbody2D rbplane3;
 //   private Rigidbody2D rbboomplane;


	// Use this for initialization
	void Start () {
        alltime = 40 + Time.time;
        InvokeRepeating("createplane", 0f, 1f);
        InvokeRepeating("createplane3", 0f, 3f);
        InvokeRepeating("createboomplane", 0f, 3f);
        win.text = "";
        lose.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        nowtiome = alltime - Time.time;
        time.text = "Time: " + nowtiome;
        if (nowtiome <= 0)
        {
            win.text = "WIN";
            lose.text = "LOSE"; 
            //game over
        }

	}
    void createplane()
    {
        GameObject goplane = Instantiate(plane, new Vector2(Random.Range(-6f,6f), 7f), Quaternion.identity) as GameObject;
     //   rbplane = goplane.GetComponent<Rigidbody2D>();
     //   rbplane.AddForce(new Vector2(0f,0f), ForceMode2D.Impulse);
    }
    void createplane3()
    {
        GameObject goplane3 = Instantiate(plane3, new Vector2(Random.Range(-6f, 6f), 7f), Quaternion.identity) as GameObject;
      //  rbplane3 = goplane3.GetComponent<Rigidbody2D>();
      //  rbplane3.AddForce(transform.forward);
    }
    void createboomplane()
    {
        GameObject goboomplane = Instantiate(boomplane, new Vector2(Random.Range(-6f, 6f), 7f), Quaternion.identity) as GameObject;
      //  rbboomplane = goboomplane.GetComponent<Rigidbody2D>();
      //  rbboomplane.AddForce(new Vector2(0f, 0.05f), ForceMode2D.Impulse);
    }
}
