using DG.Tweening;
using UnityEngine;

public class ScaleUpDownTween
{
    private const float scaleUpDuration = 0.4f;
    private const float duration = 2f;
    private const float scaleDownDuration = 0.4f;


    public ScaleUpDownTween(GameObject gameObject)
    {
        DOTween.Kill(gameObject.transform);

        gameObject.SetActive(true);
        gameObject.transform.localScale = Vector3.zero;

        DOTween.Sequence(gameObject.transform)
            .Append(gameObject.transform.DOScale(1f, scaleUpDuration).SetEase(Ease.OutFlash))
            .AppendInterval(duration)
            .Append(gameObject.transform.DOScale(0f, scaleDownDuration).SetEase(Ease.OutFlash))
            .onComplete += () => gameObject.SetActive(false);
    }


}
