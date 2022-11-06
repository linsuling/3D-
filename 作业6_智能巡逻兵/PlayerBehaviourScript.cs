using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 front = new Vector3(0, 0, 0.05f);
    Vector3 back = new Vector3(0, 0, -0.05f);
    Vector3 left = new Vector3(-0.05f, 0, 0);
    Vector3 right = new Vector3(0.05f, 0, 0);
 
    public static int score;
    public static string score_string;
    public GameObject GameOver;
    public GameObject GameSuccess;

    void Start()
    {
        score = 0;
        score_string = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("idle");
        if(Input.GetKeyDown("s"))
        {
            this.transform.Rotate(0, 180, 0);
        }
        if(Input.GetKeyDown("a"))
        {
            this.transform.Rotate(0, -90, 0);
        }
        if(Input.GetKeyDown("d"))
        {
            this.transform.Rotate(0, 90, 0);
        }
        if(Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*4,Space.Self);
            this.gameObject.GetComponent<Animator>().SetTrigger("run");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //当玩家与侦察兵相撞
        if (other.gameObject.tag == "Patrol")
        {
            Debug.Log("game over!");
            this.gameObject.GetComponent<Animator>().SetTrigger("death");
            GameOver.SetActive(true); // 显示game over字样
            Destroy(this);
        }
        //当玩家到达目的地
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Success!");
            GameSuccess.SetActive(true); // 显示game over字样
            Destroy(this);
        }
    }

    public static void setScore(){
        score ++;
    }
    public static string getScoreString(){
        return score_string;
    }

    void OnGUI(){
        score_string = "Score: " + score.ToString("F0");
        GUI.Box(new Rect(10, 10, 100, 30), score_string);
    }
}

