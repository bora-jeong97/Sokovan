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
        originalColor = myRenderer.material.color; // 기존 컬러 색 저장
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 트리건인 콜라이더와 충돌할때 자동으로 실행
    // Enter 충돌을 한 그 순간
    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // 충돌에서 벗어난 순간
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
        }
    }

    // Stay 충돌하고 있는 동안
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
            Debug.Log("충돌함");
        }
    */
}
