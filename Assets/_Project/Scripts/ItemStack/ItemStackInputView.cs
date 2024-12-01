using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemStackInputView : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_InputField _inputField;

    public void Display(ItemStackModel model)
    {
        
        gameObject.SetActive(true);
        _image.sprite = Sprites.GetItemIcon(model.itemType);

        if (model.amount == 0) _inputField.text = string.Empty;
        else _inputField.text = model.amount.ToString();

        print($"{name} display: {model.amount}");
    }

    public void Hide() => gameObject.SetActive(false);
}
