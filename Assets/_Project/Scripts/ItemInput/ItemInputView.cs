using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemInputView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _offerTitleText;
    [SerializeField] private List<ItemStackInputView> _itemStackInputViews;


    public void Display(OfferModel model)
    {
        print("begin print");
        foreach (var itemStack in model.itemStacks)
        {
            print(itemStack.amount);
        }


        gameObject.SetActive(true);
        _offerTitleText.text = model.title;
        
        for (int i = 0; i < _itemStackInputViews.Count; i++)
        {
            var view = _itemStackInputViews[i];

            bool show = i < model.itemStacks.Length;

            if (show)
            {
                print(model.itemStacks[i].amount);
                view.Display(model.itemStacks[i]);
            }
            else view.Hide();
        }
        

    }

    public void Hide() => gameObject.SetActive(false);


}
