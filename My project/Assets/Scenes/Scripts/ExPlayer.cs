using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody m_Rigidbody; //리지드 바디를 소르로 사용하게 받아온다
    public int Force = 100;    //int 정수로 힘을 100을 설정 //ui 텍스트 접근
    public int point = 0;    //점수 사용 할 변수 추가
    public float checkTime = 0;    //시간 측정을 위한 변수 (소수점)
    public Text m_Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))   //마우스 입력이 들어왔을 때
        {
            m_Rigidbody.AddForce(transform.up * Force);   //transform.up(위쪽방향)으로 리지드 바디에 force 힘만큼 물리의 힘을 준다
        }

        checkTime += Time.deltaTime; //프레임 시작을 더해서 시간을 측정
        if(checkTime >= 1.0f)       //만약 1초가 지났을경우
        {
            point += 1;    //point = point + 1 축약 ( 1점씩 더해준다 )
            checkTime = 0.0f;      // 1초가 지날경우 초기화 ( 0초 > 1초 > 0초 > 1초)
        }

        m_Text.text = point.ToString();
    }

    private void OnCollisionEnter(Collision collision)     //충돌이 시작되었을 때
    {
        if(collision != null)                           //층덜 믈체가 존재 할 경우   [ != 다를경우 ]
        {
            point = 0;                                  //충돌이 일어나면 포인트를 0으로 만듦
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            Debug.Log(collision.gameObject.name);   //해당 오브젝트의 이름을 출려한다
        }
        
    }
}
