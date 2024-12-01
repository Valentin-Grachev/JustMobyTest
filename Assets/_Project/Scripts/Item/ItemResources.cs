using UnityEngine;

public static partial class Sprites
{

    public static Sprite GetItemIcon(ItemId id) =>
        Resources.Load<Sprite>($"Sprites/Items/{id}");

}
