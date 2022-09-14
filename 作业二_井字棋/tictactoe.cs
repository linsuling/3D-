using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tictactoe : MonoBehaviour
{
    private int player = 1; //1为玩家o，-1为玩家x
    private int count = 0;
    private int end = 0;
    private int res = 0; // 标记棋局状态
    private int[,] border = new int[3,3];
    private int w = Screen.width/2;
    private int h = Screen.height/2;

    void Start(){
        reset();
        Debug.Log("game start!");
    }

    void reset(){
        player = 1;
        count = 0;
        end = 0;
        res = 0; // 0为未结束状态，1或-1为一方玩家胜利，2为平局
        for(int i=0; i<3; i++){
            for(int j=0; j<3; j++){
                border[i,j] = 0; // 未下棋状态为0，下棋为1或-1
            }
        }
        Debug.Log("game reset!");
    }

    void printRes(int res){
        string str = "";
        if(res == 1){
            str = "O win!";
        }else if(res == -1){
            str = "X win!";
        }else if(res == 2){
            str = "Draw!";
        }else{
            str = "Playing";
        }
        GUI.Box(new Rect(w-50,h-190,100,35), str);
    }
    
    void OnGUI(){
        GUI.Box(new Rect(w-150, h-220, 300, 400),"井字棋");
        if(GUI.Button(new Rect(w+200, h-17, 100, 35),"Reset")) reset();
        for(int i=0; i<3; i++){
            for(int j=0; j<3; j++){
                // 显示已经下过的棋子
                if(border[i,j] == 1){
                    GUI.Button(new Rect(w-150+i*100, h-150+j*100, 100, 100), "O");
                }
                else if(border[i,j] == -1){
                    GUI.Button(new Rect(w-150+i*100, h-150+j*100, 100, 100), "X");
                }
                // 下新棋子
                else{
                    if(GUI.Button(new Rect(w-150+i*100, h-150+j*100, 100, 100), "")){
                        if(end == 1) break;
                        border[i,j] = player;
                        count++;
                        if(border[0,j]+border[1,j]+border[2,j] == 3*player) res=player;
                        else if(border[i,0]+border[i,1]+border[i,2] == 3*player) res=player;
                        else if(i == j && border[0,0]+border[1,1]+border[2,2] == 3*player) res=player;
                        else if(i+j == 2 && border[0,2]+border[1,1]+border[2,0] == 3*player) res=player;
                        if(count == 9 && res == 0) res = 2; // 平局
                        if(res != 0) end = 1; // 平局或一方获胜，游戏结束
                        player = -player; // 交换下棋方
                    }
                }
            }
        }
        printRes(res); // 输出棋局信息
    }
}
