using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.EventSystems;

public class HealthBarScript : MonoBehaviour
{
    public RectTransform rectTransform;
    public RectTransform liftBarRect;
    private float curHitPoint;
    Color color1;
    Color color2;
    Color color3;
    // Start is called before the first frame update
    
    void Start()
    {
        color1 = Color.green;
        color2 = Color.yellow;
        color3 = Color.red;
        curHitPoint = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            curHitPoint += 1/10f * Time.deltaTime * 2;
            if(curHitPoint >= 1){
                curHitPoint = 1;
            }
        }
        if(Input.GetKey(KeyCode.A)){
            curHitPoint -= 1/10f * Time.deltaTime * 2;
            if(curHitPoint <= 0){
                curHitPoint = 0;
            }
        }
        liftBarRect.offsetMax = new Vector2((curHitPoint - 1) * rectTransform.rect.width, liftBarRect.offsetMax.y);
        if(curHitPoint > 0.5){
            liftBarRect.GetComponent<Image>().color = color1;
        }
        if(curHitPoint > 0.2 && curHitPoint <= 0.5){
            liftBarRect.GetComponent<Image>().color = color2;
        }
        if(curHitPoint < 0.2){
            liftBarRect.GetComponent<Image>().color = color3;
        }
    }
}
