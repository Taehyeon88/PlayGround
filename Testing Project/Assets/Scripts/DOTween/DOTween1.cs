using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTween1 : MonoBehaviour
{
    Sequence sequence;
    //.Append : 트윈 마지막에 추가
    //.Insert : 일정 시간에 시작
    //.join : 앞에 추가된 트윈과 동시 시작
    //.Prepend : 맨 처음에 추가

    private Vector3 targetPos = new Vector3(0, 5, 0);
    void Start()
    {
        sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(new Vector3(0f, 5f, 0f), 2f))
            .Join(transform.DORotate(new Vector3(0f, -180f, 0f), 2.0f))
            .Append(transform.DORotate(new Vector3(0f, 360f, 0f), 2f))
            .Insert(4f, transform.DOScale(1.5f, 1.0f))
            .Prepend(transform.DOScale(0.5f, 2f));


        //----------------------------------------------------------------------------------------------------------------------------------------
        //DOTween.Init(false, true, LogBehaviour.Verbose).SetCapacity(200, 5);
        //autoKillMode : 한번 사용한 DOTween을 다시 사용할지를 결정함.
        //useSafeMode : 약간은 느리지만 실행되는 동안, 실행 대상이 자동으로 파괴되는 것과 같이 예외처리를 자동으로 처리해줌.
        //LogBehaviour : 오류 메세지 기록을 설정함.
        //SetCapacity(Tweener 개수, Squence 개수) : Tweener과 Squence의 사용할 개수를 설정함.

        //DOTween.Init() 이 외에도 각각의 Tweener들을 따로 설정해 줄 수 있음.

        //두투윈 공식 사용코드
        //DOTween.To(() => myValue, x => myValue = x, 100, 1); -->알아야 할 것 : 스테틱개념, 람다식, 익명메소드, 델리게이트

        //--------------------------------------------------------------------------------------------------------------------------------
        //transform.DOMove(targetPos, 5f);
        //transform.DOShakePosition(15f, 1, 10, 90);
        //transform.DOScale(3f, 3f).SetLoops(5, LoopType.Incremental);

        //DO 대상의 변화를 직접지시
        //Set 추가 설정
        //On 람다를 이용한 콜백함수 실행

        /*transform.DOScale(3f, 3f).
            SetEase(Ease.InBounce).
            OnComplete(() => transform.DOMove(targetPos, 2f).
            SetLoops(3, LoopType.Restart));
        //SetEase의 종류표가 사이트가 있음

        DOTween.Init(true, true, LogBehaviour.Verbose);
        Tweener tw = transform.DOScale(3f, 3f).SetEase(Ease.InBounce); //이 트윈을 재사용할 수 있음.
        tw.Play(); //재사용

        //autoKillMode 가 false 이더라도 재사용할 수 있음
        Tweener tw1 = transform.DOScale(3f, 3f).SetEase(Ease.InBounce).SetAutoKill(false);

        tw.Kill(); //데이터가 남기에 또 지워야함*/
        //------------------------------------------------------------------------------------------------------------------------------------

    }
    void Update()
    {
        
    }
}
