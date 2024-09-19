using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardScript : MonoBehaviour
{
    public Camera Camera;
    private Vector3 origPos;

    void Start()
    {
        origPos = transform.localPosition;
    }

    private void OnMouseEnter()
    {
        transform.DOLocalMove(new Vector3(origPos.x, origPos.y, origPos.z - 2), 0.5f).SetEase(Ease.InOutBack);
        transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.5f).SetEase(Ease.InOutBack);
    }

    private void OnMouseExit()
    {
        transform.DOLocalMove(origPos, 0.5f).SetEase(Ease.InOutBack);
        transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.InOutBack);        
    }

    private void OnMouseDown()
    {
        transform.DORotate(new Vector3(0, 0, 360f), 0.5f).SetEase(Ease.InOutBack);
        Camera.transform.DOShakePosition(0.5f, 0.5f, 10, 90).SetEase(Ease.InOutBack);
    } 
}
