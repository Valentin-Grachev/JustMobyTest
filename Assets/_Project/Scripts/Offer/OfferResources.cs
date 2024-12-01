using UnityEngine;

public static partial class Sprites
{

    public static Sprite GetOfferIcon(OfferIconId id) =>
        Resources.Load<Sprite>($"Sprites/Offer/{id}");

}
