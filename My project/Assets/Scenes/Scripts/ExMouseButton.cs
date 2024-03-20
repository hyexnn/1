using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;        //UI �۾� ���ڿ� �߰�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                    //�� �����Ӹ��� ȣ��
    {
        textUI.text = "ü�� : " + Hp.ToString();    //UI�� ü�� ǥ��

        if(Input.GetMouseButtonDown(0)) //���콺 �Է��� ������ ��
        {
            Hp -= 10;
            //Debug.Log("ü�� :" + Hp);     //ü��Ȯ���� ���� deubug.log �Լ�
            if( Hp <= 0 )    //hp�� 0���Ϸ� �������� 
            {
                textUI.text = "ü�� : " + Hp.ToString();
                Destroy(gameObject); //�� ������Ʈ�� �ı��Ѵٴ� �Լ�
            }
        }
    }
}
