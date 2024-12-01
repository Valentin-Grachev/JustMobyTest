using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OfferView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private List<ItemStackView> _itemStackViews;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private GameObject _discountMark;
    [SerializeField] private TextMeshProUGUI _discountText;



    public void Display(OfferModel model)
    {
        gameObject.SetActive(true);

        _titleText.text = model.title;
        _descriptionText.text = model.description;

        for (int i = 0; i < _itemStackViews.Count; i++)
        {
            var view = _itemStackViews[i];

            bool show = i < model.itemStacks.Length;
            if (show) view.Display(model.itemStacks[i]);
            else view.Hide();
        }

        _priceText.text = $"${model.priceUSD:F2}";

        _discountMark.SetActive(model.useDiscount);
        if (model.useDiscount)
            _discountText.text = $"${model.discountedPriceUSD:F2}";

    }

    public void Hide() => gameObject.SetActive(false);



}
