using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 카멜명명법 
 * 클래스 이름은 무조건 대문자로 시작함
 * 단어와 단어사이는 대문자 
 * 변수는 첫글자는 소문자
 * 함수는 대문자로 시작
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


    /* 모바일 1초 30프레임 PC 1초 60프레임
     * 몇 번 실행되는지는 정해져 있지는 않다.
     * 화면이 한 번 깜빡일 때 한 번 실행됨
     */
    void Update()


    {
        // 발사 기능 "Fire" > 마우스 왼쪽 버튼
        // if(입력("Fire"))
        // 총알을 발사 
        // 앉는 기능 "Crunch" - 키보드 C
        // A <-        -> D
        // -1.0    0   +1.0
        // 조이스틱을 왼쪽으로 살짝 밀면
        // -1.0  -0.5  0  +0.5  +1.0
        // 숫자로 받는 이유는 조이스틱을 살살 미는 정도를 알기 위해
        float InputX = Input.GetAxis("Horizontal"); // 키보드 수평방향에 대응되는 키가 맵핑되있음

        float inputZ = Input.GetAxis("Vertical");   // 수직 대응

        float fallSpeed = playerRigidbody.velocity.y;

        // 힘을 주는 것 관성이 잇음
        //playerRigidbody.AddForce(InputX * speed, 0, inputZ * speed); 

        // 관성이 없음
        Vector3 velocity = new Vector3(InputX, 0, inputZ);  // y값을 0으로만 두면 떨어질 때 값이 갱신된다. 잘 안떨어지게됨

        // (InputX * speed, 0 * speed, inputZ * speed)
        velocity = velocity * speed;

        velocity.y = fallSpeed; // 떨어지는 속도 정상화

        playerRigidbody.velocity = velocity; 

    }
}
