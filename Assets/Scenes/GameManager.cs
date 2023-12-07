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

        // 키보드의 키를 누른순간
        if (Input.GetKeyDown(KeyCode.Space))
        {   // scene과 scene을 넘나들게 하는 것
            //SceneManager.LoadScene("Main"); // 해당 씬으로 감
            SceneManager.LoadScene(0); // bulid setting의 순번을 넣어도됨
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
            Debug.Log("게임 승리");
            winUI.SetActive(true);
        }
    }
}
