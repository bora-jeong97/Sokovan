using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{





    // Update is called once per frame
    void Update()
    {
        /* Time.deltaTime �� ȭ���� �ѹ� �����̴� �ð� = �� �������� �ð�
         * ȭ���� 30�� �����̸� (�ʴ� 30������) 1/30
         * ȭ���� 200�� �����̸� (�ʴ� 200������) 1/200
         */
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime); // ������ transform���� ���� �� �� �ִ� ����     
    }


    // 60 * 60 = 3600

    // �ϵ� �� ���ǵ� - �����ڽ� �ܼ�/PC��
    // 1�� 30������ ������ ��
    // ������ �� ���� ���α׷��� ���������
    // 1�ʿ� 60�� �̻� �����̵��� ����
    // -> ��� ������ �ӵ��� 2���̻� ������

    // 1�ʿ� 1m
    // Update(�ѹ��� 1/30m)
    // 1/30m * 30 -> 1m

    // �����Ӷ��� ���� �ʴ� 30������ -> �ʴ� 60������ 
    // 2�� ������

    //Update �Լ��� ȭ���� �ѹ� �����̸� �����
    // ����� ��ǻ�� �ѹ��� 1m
    // 1�ʿ� 30m
    // ����� ��ǻ�� 1�ʿ� 60��
    // �̷� ������ ��� �ذ��� ���ΰ�?
    // �ð� ������ ����
    // 1m�� �����̴� Ƚ�� (30)����  �ɰ��� 1/30m
    // 1/30m�� 30�� �������� �ݺ��ؼ� �����Ǹ� 1��



}