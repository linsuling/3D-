using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIScript : MonoBehaviour
{
    private int curHitPoint;
    public Texture2D green;
    public Texture2D red;
    public Texture2D orange;
    private int w = Screen.width/2;
    private int h = Screen.height/2;
    private GUIStyle style;

    void Start()
    {
        curHitPoint = 100;
        style = new GUIStyle();
        style.normal.background = green;
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(w+200, h-17, 50, 35),"+")){
            curHitPoint += 5;
            if(curHitPoint >= 100){
                curHitPoint = 100;
            }
        }
        if(GUI.Button(new Rect(w+200, h+27, 50, 35),"-")){
            curHitPoint -= 5;
            if(curHitPoint <= 0){
                curHitPoint = 0;
            }
        }
        if(curHitPoint > 50){
            style.normal.background = green;
        }
        if(curHitPoint > 20 && curHitPoint <= 50){
            style.normal.background = orange;
        }
        if(curHitPoint <= 20){
            style.normal.background = red;
        }
        GUI.Box(new Rect(w-100, h-15, curHitPoint * 2, 30), "", style);
    }
}