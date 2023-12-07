using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject winUI;
    public ItemBox[] itemBoxes;
    public bool isGameOver;


    void Start()
    {
        isGameOver = false;    
    }

    // Update is called once per frame
    void Update()
    {

        // Ű������ Ű�� ��������
        if (Input.GetKeyDown(KeyCode.Space))
        {   // scene�� scene�� �ѳ���� �ϴ� ��
            //SceneManager.LoadScene("Main"); // �ش� ������ ��
            SceneManager.LoadScene(0); // bulid setting�� ������ �־��
        }

        if (isGameOver)
        {
            return;
        }

        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if(itemBoxes[i].isOveraped == true)
            {
                count++;
            }
        }
        if(count >= 3)
        {
            isGameOver = true;
            Debug.Log("���� �¸�");
            winUI.SetActive(true);
        }
    }
}
