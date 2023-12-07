using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{

    public bool isOveraped = false;

    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color; // ���� �÷� �� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Ʈ������ �ݶ��̴��� �浹�Ҷ� �ڵ����� ����
    // Enter �浹�� �� �� ����
    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // �浹���� ��� ����
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    // Stay �浹�ϰ� �ִ� ����
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    /*    private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("�浹��");
        }
    */
}
