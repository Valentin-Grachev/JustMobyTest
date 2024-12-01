using System;

[System.Serializable]
public struct OfferModel
{
    public string title;
    public string description;
    public OfferIconId iconId;

    public ItemStackModel[] itemStacks;

    public float priceUSD;
    public bool useDiscount;
    public float discountedPriceUSD;

    public OfferModel GetCopy()
    {
        var copy = new OfferModel
        {
            title = title,
            description = description,
            iconId = iconId,
            itemStacks = new ItemStackModel[itemStacks.Length],
            priceUSD = priceUSD,
            useDiscount = useDiscount,
            discountedPriceUSD = discountedPriceUSD
        };

        Array.Copy(itemStacks, copy.itemStacks, copy.itemStacks.Length);
        return copy;
    }

}
