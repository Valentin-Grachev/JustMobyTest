using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemStackView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _amountText;


    public void Display(ItemStackModel model)
    {
        gameObject.SetActive(true);
        _image.sprite = Sprites.GetItemIcon(model.itemId);

        if (model.amount == 0) 
            _amountText.gameObject.SetActive(false);

        else
        {
            _amountText.gameObject.SetActive(true);
            _amountText.text = model.amount.ToString();
        }
        
    }

    public void Hide() => gameObject.SetActive(false);


}
