using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody m_Rigidbody; //������ �ٵ� �Ҹ��� ����ϰ� �޾ƿ´�
    public int Force = 100;    //int ������ ���� 100�� ���� //ui �ؽ�Ʈ ����
    public int point = 0;    //���� ��� �� ���� �߰�
    public float checkTime = 0;    //�ð� ������ ���� ���� (�Ҽ���)
    public Text m_Text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))   //���콺 �Է��� ������ ��
        {
            m_Rigidbody.AddForce(transform.up * Force);   //transform.up(���ʹ���)���� ������ �ٵ� force ����ŭ ������ ���� �ش�
        }

        checkTime += Time.deltaTime; //������ ������ ���ؼ� �ð��� ����
        if(checkTime >= 1.0f)       //���� 1�ʰ� ���������
        {
            point += 1;    //point = point + 1 ��� ( 1���� �����ش� )
            checkTime = 0.0f;      // 1�ʰ� ������� �ʱ�ȭ ( 0�� > 1�� > 0�� > 1��)
        }

        m_Text.text = point.ToString();
    }

    private void OnCollisionEnter(Collision collision)     //�浹�� ���۵Ǿ��� ��
    {
        if(collision != null)                           //���� ��ü�� ���� �� ���   [ != �ٸ���� ]
        {
            point = 0;                                  //�浹�� �Ͼ�� ����Ʈ�� 0���� ����
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            Debug.Log(collision.gameObject.name);   //�ش� ������Ʈ�� �̸��� ����Ѵ�
        }
        
    }
}
