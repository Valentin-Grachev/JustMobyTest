using UnityEngine;
using UnityEngine.UI;

public class OfferController : MonoBehaviour
{
    [SerializeField] private ItemInputController _itemInputController;
    [SerializeField] private Button _displayOfferButton;
    [SerializeField] private Button _hideOfferButton;
    [SerializeField] private OfferView _offerView;
    [SerializeField] private ItemInputView _itemInputView;


    private void Start()
    {
        _displayOfferButton.onClick.AddListener(OnDisplayOfferButtonPressed);
        _hideOfferButton.onClick.AddListener(OnHideOfferButtonPressed);
    }

    private void OnDestroy()
    {
        _displayOfferButton.onClick.RemoveListener(OnDisplayOfferButtonPressed);
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
