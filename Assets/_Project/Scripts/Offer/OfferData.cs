using UnityEngine;

[CreateAssetMenu(menuName = "Project/OfferData", fileName = "OfferData")]
public class OfferData : ScriptableObject
{
    [SerializeField] private OfferModel _model;

    public OfferModel Model => _model.GetCopy();

}

public static partial class Data
{
    public static OfferData[] AllOffers =>
        Resources.LoadAll<OfferData>("OfferData");
}
