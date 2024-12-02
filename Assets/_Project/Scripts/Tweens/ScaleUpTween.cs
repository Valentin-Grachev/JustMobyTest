using DG.Tweening;
using UnityEngine;

public class ScaleUpTween
{
    private const float duration = 0.4f;


    public ScaleUpTween(GameObject gameObject)
    {
        DOTween.Kill(gameObject.transform);

        gameObject.SetActive(true);
        gameObject.transform.localScale = Vector3.zero;
        gameObject.transform.DOScale(1f, duration).SetEase(Ease.OutFlash);
    }


}
