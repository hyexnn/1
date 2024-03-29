using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;        //UI 글씨 문자열 추가
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                    //매 프레임마다 호출
    {
        textUI.text = "체력 : " + Hp.ToString();    //UI에 체력 표시

        if(Input.GetMouseButtonDown(0)) //마우스 입력이 들어왔을 때
        {
            Hp -= 10;
            //Debug.Log("체력 :" + Hp);     //체력확인을 위한 deubug.log 함수
            if( Hp <= 0 )    //hp가 0이하로 내려가면 
            {
                textUI.text = "체력 : " + Hp.ToString();
                Destroy(gameObject); //이 오브젝트를 파괴한다는 함수
            }
        }
    }
}
