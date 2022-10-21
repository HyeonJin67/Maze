using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveQuizObjectHandle : MonoBehaviour
{
    [Tooltip ("퀘스트별 퀴즈시작때 <QuizTouchHandle>스크립트가 들어있는 활성화가 필요한 오브젝트들만 다 넣어주세요")]
    [SerializeField]
    GameObject[] quizObjects; //퀘스트별 퀴즈시작시 활성화해줘야 할 오브젝트
    [Tooltip("<QuizTouchHandle>스크립트가 들어있고 퀘스트별 퀴즈시작때 떨어뜨려줘야 할 오브젝트들만 다 넣어주세요")]
    [SerializeField]
    Rigidbody[] drops; //퀘스트별 퀴즈시작시 떨어뜨려줘야 할 오브젝트


    private void OnTriggerEnter(Collider other)
    {
        if(quizObjects != null)
        {
            for (int i = 0; i < quizObjects.Length; i++)
            {
                quizObjects[i].SetActive(true);
            }
        }
        if(drops != null)
        {
            for(int j =0; j < drops.Length; j++)
            {
                drops[j].useGravity = true;
            }
        }
      
    }
}
