using DG.Tweening;
using UnityEngine;

public class ScaleDownTween
{
    private const float duration = 0.4f;


    public ScaleDownTween(GameObject gameObject)
    {
        DOTween.Kill(gameObject.transform);

        gameObject.transform.DOScale(0f, duration).SetEase(Ease.OutFlash)
            .onComplete += () => gameObject.SetActive(false);
    }
}
