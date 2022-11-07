using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUIScript : MonoBehaviour
{
    public static bool game_over;
    public string show_score;

    private int w = Screen.width/2;
    private int h = Screen.height/2;
    GUIStyle myStyle1;
    GUIStyle myStyle2;

    // Start is called before the first frame update
    void Start()
    {
        show_score = "Score: 0";
        game_over = false;
        myStyle1 = new GUIStyle();
        myStyle1.fontSize = 68;
        myStyle2 = new GUIStyle();
        myStyle2.fontSize = 35;
    }

    // Update is called once per frame
    void OnGUI()
    {
        show_score = "Score: " + ClickBehaviourScript.getScore().ToString("F0");
        GUI.Box(new Rect(30, 20, 100, 30), show_score, myStyle2);
        if(game_over){
            GUI.Label(new Rect(w-150, h-90, 300, 300), "Success!", myStyle1);
        }
    }

    public static void setGameover(){ // 让玩家判断游戏是否结束
        game_over = true;
    }
}
