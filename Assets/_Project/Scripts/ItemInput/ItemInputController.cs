using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInputController : MonoBehaviour
{
    public OfferModel SelectedOfferModel { get; private set; }

    [SerializeField] private ItemInputView _itemInputView;
    [SerializeField] private Button _nextOfferButton;
    [SerializeField] private Button _previousOfferButton;
    [SerializeField] private List<TMP_InputField> _itemStackInputFields;

    private int _offerIndex;


    private void Start()
    {
        _nextOfferButton.onClick.AddListener(OnNextOfferButtonPressed);
        _previousOfferButton.onClick.AddListener(OnPreviousOfferButtonPressed);
        foreach (var inputField in _itemStackInputFields)
            inputField.onValueChanged.AddListener(OnItemStackInputFieldChanged);

        SetOfferIndex(0);
    }

    private void OnDestroy()
    {
        _nextOfferButton.onClick.RemoveListener(OnNextOfferButtonPressed);
        _previousOfferButton.onClick.RemoveListener(OnPreviousOfferButtonPressed);
        foreach (var inputField in _itemStackInputFields)
            inputField.onValueChanged.RemoveListener(OnItemStackInputFieldChanged);
    }

    private void SetOfferIndex(int index)
    {
        _offerIndex = index;
        SelectedOfferModel = Data.AllOffers[_offerIndex].Model;
        _itemInputView.Display(SelectedOfferModel);
    }


    private void OnPreviousOfferButtonPressed() =>
        SetOfferIndex(Mathf.Abs((_offerIndex - 1) % Data.AllOffers.Length));

    private void OnNextOfferButtonPressed() =>
        SetOfferIndex(Mathf.Abs((_offerIndex + 1) % Data.AllOffers.Length));


    private void OnItemStackInputFieldChanged(string value)
    {
        for (int i = 0; i < SelectedOfferModel.itemStacks.Length; i++)
        {
            if (int.TryParse(_itemStackInputFields[i].text, out int amount))
                SelectedOfferModel.itemStacks[i].amount = amount;
        }
        
    }





}
