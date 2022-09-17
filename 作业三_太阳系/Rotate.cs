using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform sun;
    public float x;
    public float y;
    public float z;
    void Start(){
        Vector3 pos = transform.position;
        x = pos.x;
        y = pos.y;
        z = pos.z; // 获取坐标
    }
    void Update()
    {
        Vector3 axis = new Vector3(y, x, z); // 围绕旋转的轴
        transform.RotateAround(sun.position, axis, Time.deltaTime*200/x); // 速度与远近成反比
    }
}