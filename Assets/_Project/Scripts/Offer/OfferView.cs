using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OfferView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private Image _mainIcon;
    [SerializeField] private List<ItemStackView> _itemStackViews;

    [SerializeField] private TextMeshProUGUI _priceWithoutDiscountText;

    [SerializeField] private GameObject _noDiscountSector;
    [SerializeField] private GameObject _discountSector;
    [SerializeField] private TextMeshProUGUI _discountMarkText;
    [SerializeField] private TextMeshProUGUI _discountedPriceText;
    [SerializeField] private TextMeshProUGUI _crossountPriceText;


    public void Display(OfferModel model)
    {
        gameObject.SetActive(true);

        _titleText.text = model.title;
        _descriptionText.text = model.description;
        _mainIcon.sprite = Sprites.GetOfferIcon(model.iconId);

        for (int i = 0; i < _itemStackViews.Count; i++)
        {
            var view = _itemStackViews[i];

            bool show = i < model.itemStacks.Length;
            if (show) view.Display(model.itemStacks[i]);
            else view.Hide();
        }

        _noDiscountSector.SetActive(!model.useDiscount);
        _discountSector.SetActive(model.useDiscount);

        if (model.useDiscount)
        {
            _discountedPriceText.text = $"${model.discountedPriceUSD:F2}";
            _crossountPriceText.text = $"${model.priceUSD:F2}";

            int discountPercentage = (int)((1f - model.discountedPriceUSD / model.priceUSD) * 100f);
            _discountMarkText.text = $"-{discountPercentage}%";
        }
        else _priceWithoutDiscountText.text = $"${model.priceUSD:F2}";
    }

    public void Hide() => gameObject.SetActive(false);



}
