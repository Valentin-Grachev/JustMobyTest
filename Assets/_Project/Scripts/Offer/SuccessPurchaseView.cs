using TMPro;
using UnityEngine;

public class SuccessPurchaseView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    public void Display(OfferModel model)
    {
        new ScaleUpDownTween(gameObject);
        _text.text = $"Успешная покупка: {model.title}";
    }

}
