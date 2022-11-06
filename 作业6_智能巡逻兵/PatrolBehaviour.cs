using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehaviour : MonoBehaviour
{
    private GameObject player; //玩家
    private int sidelength; // 巡逻时同一个方向能走的最长步数
    private bool chase = false; // 是否在追赶player

    // Start is called before the first frame update
    void Start()
    {
        sidelength = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 巡逻
        if(!chase){
            // 走一定的步数就转90度
            if(sidelength >= 500){
                this.transform.Rotate(0, 90, 0);
                sidelength = 0;
            }
            // 朝自己前方移动，步数加一
            else{
                transform.Translate(Vector3.forward*Time.deltaTime*2,Space.Self);
                sidelength++;
            }
        }
        // 追赶player
        else{
            transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, 2 * Time.deltaTime);
            this.transform.LookAt(player.transform.position); // 朝向目标
        }
    }

    //player进入追捕范围，即触发盒状碰撞器
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            chase = true;
            player = collider.gameObject;
        }
    }

    //player离开追捕范围
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("socre ++");
            PlayerBehaviourScript.setScore();
            chase = false;
            player = null;
        }
    }

    
}


