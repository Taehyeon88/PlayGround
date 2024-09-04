using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTween1 : MonoBehaviour
{
    Sequence sequence;
    //.Append : Ʈ�� �������� �߰�
    //.Insert : ���� �ð��� ����
    //.join : �տ� �߰��� Ʈ���� ���� ����
    //.Prepend : �� ó���� �߰�

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
        //autoKillMode : �ѹ� ����� DOTween�� �ٽ� ��������� ������.
        //useSafeMode : �ణ�� �������� ����Ǵ� ����, ���� ����� �ڵ����� �ı��Ǵ� �Ͱ� ���� ����ó���� �ڵ����� ó������.
        //LogBehaviour : ���� �޼��� ����� ������.
        //SetCapacity(Tweener ����, Squence ����) : Tweener�� Squence�� ����� ������ ������.

        //DOTween.Init() �� �ܿ��� ������ Tweener���� ���� ������ �� �� ����.

        //������ ���� ����ڵ�
        //DOTween.To(() => myValue, x => myValue = x, 100, 1); -->�˾ƾ� �� �� : ����ƽ����, ���ٽ�, �͸�޼ҵ�, ��������Ʈ

        //--------------------------------------------------------------------------------------------------------------------------------
        //transform.DOMove(targetPos, 5f);
        //transform.DOShakePosition(15f, 1, 10, 90);
        //transform.DOScale(3f, 3f).SetLoops(5, LoopType.Incremental);

        //DO ����� ��ȭ�� ��������
        //Set �߰� ����
        //On ���ٸ� �̿��� �ݹ��Լ� ����

        /*transform.DOScale(3f, 3f).
            SetEase(Ease.InBounce).
            OnComplete(() => transform.DOMove(targetPos, 2f).
            SetLoops(3, LoopType.Restart));
        //SetEase�� ����ǥ�� ����Ʈ�� ����

        DOTween.Init(true, true, LogBehaviour.Verbose);
        Tweener tw = transform.DOScale(3f, 3f).SetEase(Ease.InBounce); //�� Ʈ���� ������ �� ����.
        tw.Play(); //����

        //autoKillMode �� false �̴��� ������ �� ����
        Tweener tw1 = transform.DOScale(3f, 3f).SetEase(Ease.InBounce).SetAutoKill(false);

        tw.Kill(); //�����Ͱ� ���⿡ �� ��������*/
        //------------------------------------------------------------------------------------------------------------------------------------

    }
    void Update()
    {
        
    }
}
