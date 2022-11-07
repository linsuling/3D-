using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickBehaviourScript : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject GameSuccess;
    public GameObject target_red;
    public GameObject target_yellow;
    public GameObject target_green;

    public static int score; // 当前分数
    public static int target_score; // 目标分数
    
    private bool met_red; // 是否已经碰撞过
    private bool met_yellow;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        score = 0;
        target_score = 2;
        met_red = false;
        met_yellow = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 读取键盘输入来前进
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*15,Space.Self);
        }
        if(Input.GetKey("s"))
        {
            transform.Translate(Vector3.back*Time.deltaTime*15,Space.Self);
        }
        if(Input.GetKey("a"))
        {
            transform.Translate(Vector3.left*Time.deltaTime*15,Space.Self);
        }
        if(Input.GetKey("d"))
        {
            transform.Translate(Vector3.right*Time.deltaTime*15,Space.Self);
        }

        // 鼠标点击智能前进
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                if(hit.transform.tag == "Ground"){
                    Vector3 point = hit.point;
                    agent.SetDestination(point);
                }
            }
        }

        // 各物体的范围
        var size = this.transform.GetComponent<Renderer>().bounds.size;
        var size_red = target_red.transform.GetComponent<Renderer>().bounds.size;
        var size_yellow = target_yellow.transform.GetComponent<Renderer>().bounds.size;
        var size_green = target_green.transform.GetComponent<Renderer>().bounds.size;
        // 有效碰撞只记一次，需要检查有没有碰过
        // 将两物体的距离and半径之和作比较
        if((this.transform.position - target_red.transform.position).magnitude <= size.x + size_red.x + 1 && !met_red){
            score ++;
            met_red = true;
        }
        if((this.transform.position - target_yellow.transform.position).magnitude <= size.x + size_yellow.x + 1 && !met_yellow){
            score ++;
            met_yellow = true;
        }

        // 当玩家到达目标
        // 如果分数足够则游戏结束
        if((this.transform.position - target_green.transform.position).magnitude <= size.x + size_green.x + 1 && score >= target_score){
            Debug.Log("Success!");
            IMGUIScript.setGameover(); // 让IMGUI显示success字样
            Destroy(this);
        }
    }

    // 给GUI返回当前分数
    public static int getScore(){ 
        return score;
    }

}
