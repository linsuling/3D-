using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float score;
    public Vector3 scale;
    // public GameObject cylinder;
    void Start()
    {
        scale = new Vector3(1, 1, 1); // 默认大小比例为1
        score = 1; // 飞碟的初始分值为1
    }

    //Update is called once per frame
    void Update()
    {
        score += 0.001f; //分值逐渐增加
    }
}
