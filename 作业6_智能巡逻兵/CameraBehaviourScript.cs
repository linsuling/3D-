using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject c1;
    Vector3 up_dir;
    Vector3 rot;
    Vector3 new_pos;

    void Start()
    {
        // 摄像机与人物的相对位置
        up_dir = new Vector3(0, 8f, 0);
        rot = new Vector3(30f, 0, 0);
        transform.position = - c1.GetComponent<Transform>().forward * 12 + up_dir;
        transform.localEulerAngles = rot;
    }

    // Update is called once per frame
    void Update()
    {
        // 保持摄像机在人物背后相对位置不变
        transform.position = c1.GetComponent<Transform>().position - c1.GetComponent<Transform>().forward * 12 + up_dir;
        gameObject.GetComponent<Transform>().localEulerAngles = c1.GetComponent<Transform>().localEulerAngles + rot;
    }
}
