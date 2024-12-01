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
        _image.sprite = Sprites.GetItemIcon(model.itemId);

        string text = model.amount == 0 ? string.Empty : model.amount.ToString();
        _inputField.SetTextWithoutNotify(text);
    }

    public void Hide() => gameObject.SetActive(false);
}
