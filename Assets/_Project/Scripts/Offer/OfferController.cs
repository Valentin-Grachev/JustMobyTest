using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class OfferController : MonoBehaviour
{
    [SerializeField] private ItemInputController _itemInputController;
    
    [SerializeField] private Button _displayOfferButton;
    [SerializeField] private Button _hideOfferButton;
    [SerializeField] private Button _purchaseOfferButton;

    [SerializeField] private OfferView _offerView;
    [SerializeField] private ItemInputView _itemInputView;
    [SerializeField] private SuccessPurchaseView _successPurchaseView;


    private void Start()
    {
        _displayOfferButton.onClick.AddListener(OnDisplayOfferButtonPressed);
        _hideOfferButton.onClick.AddListener(OnHideOfferButtonPressed);
        _purchaseOfferButton.onClick.AddListener(OnPurchaseOfferButtonPressed);
    }

    private void OnDestroy()
    {
        _displayOfferButton.onClick.RemoveListener(OnDisplayOfferButtonPressed);
        _hideOfferButton.onClick.RemoveListener(OnHideOfferButtonPressed);
        _purchaseOfferButton.onClick.RemoveListener(OnPurchaseOfferButtonPressed);
    }


    private void OnPurchaseOfferButtonPressed()
    {
        _offerView.Hide();
        _successPurchaseView.Display(_itemInputController.SelectedOfferModel);
        _itemInputView.Display(_itemInputController.SelectedOfferModel);
    }

    private void OnDisplayOfferButtonPressed()
    {
        _offerView.Display(_itemInputController.SelectedOfferModel);
        _itemInputView.Hide();
    }

    private void OnHideOfferButtonPressed()
    {
        _itemInputView.Display(_itemInputController.SelectedOfferModel);
        _offerView.Hide();
    }


}
