using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{





    // Update is called once per frame
    void Update()
    {
        /* Time.deltaTime 은 화면이 한번 깜빡이는 시간 = 한 프레임의 시간
         * 화면을 30번 깜박이면 (초당 30프레임) 1/30
         * 화면을 200번 깜박이면 (초당 200프레임) 1/200
         */
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime); // 본인의 transform으로 접근 할 수 있는 변수     
    }


    // 60 * 60 = 3600

    // 니드 포 스피드 - 엑스박스 콘솔/PC판
    // 1초 30프레임 프레임 락
    // 프레임 락 해제 프로그램을 만들엇더니
    // 1초에 60번 이상 깜박이도록 해제
    // -> 모든 차들의 속도가 2배이상 빨라짐

    // 1초에 1m
    // Update(한번에 1/30m)
    // 1/30m * 30 -> 1m

    // 프레임락을 해제 초당 30프레임 -> 초당 60프레임 
    // 2배 빨라짐

    //Update 함수는 화면이 한번 깜빡이면 실행됨
    // 저사양 컴퓨터 한번에 1m
    // 1초에 30m
    // 고사양 컴퓨터 1초에 60번
    // 이런 간극을 어떻게 해결할 것인가?
    // 시간 간극을 주자
    // 1m를 깜빡이는 횟수 (30)으로  쪼개면 1/30m
    // 1/30m를 30번 깜빡여서 반복해서 누적되면 1ㅡ



}
