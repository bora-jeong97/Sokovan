using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ī����� 
 * Ŭ���� �̸��� ������ �빮�ڷ� ������
 * �ܾ�� �ܾ���̴� �빮�� 
 * ������ ù���ڴ� �ҹ���
 * �Լ��� �빮�ڷ� ����
 */
public class Player : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody playerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //playerRigidbody.AddForce(0, 500, 0);
    }


    /* ����� 1�� 30������ PC 1�� 60������
     * �� �� ����Ǵ����� ������ ������ �ʴ�.
     * ȭ���� �� �� ������ �� �� �� �����
     */
    void Update()


    {
        // �߻� ��� "Fire" > ���콺 ���� ��ư
        // if(�Է�("Fire"))
        // �Ѿ��� �߻� 
        // �ɴ� ��� "Crunch" - Ű���� C
        // A <-        -> D
        // -1.0    0   +1.0
        // ���̽�ƽ�� �������� ��¦ �и�
        // -1.0  -0.5  0  +0.5  +1.0
        // ���ڷ� �޴� ������ ���̽�ƽ�� ��� �̴� ������ �˱� ����
        float InputX = Input.GetAxis("Horizontal"); // Ű���� ������⿡ �����Ǵ� Ű�� ���ε�����

        float inputZ = Input.GetAxis("Vertical");   // ���� ����

        float fallSpeed = playerRigidbody.velocity.y;

        // ���� �ִ� �� ������ ����
        //playerRigidbody.AddForce(InputX * speed, 0, inputZ * speed); 

        // ������ ����
        Vector3 velocity = new Vector3(InputX, 0, inputZ);  // y���� 0���θ� �θ� ������ �� ���� ���ŵȴ�. �� �ȶ������Ե�

        // (InputX * speed, 0 * speed, inputZ * speed)
        velocity = velocity * speed;

        velocity.y = fallSpeed; // �������� �ӵ� ����ȭ

        playerRigidbody.velocity = velocity; 

    }
}
