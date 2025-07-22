using TMPro;
using UnityEngine;

public class InfoPanel_UI : MonoBehaviour
{
    public TextMeshProUGUI assetNameText;
    public TextMeshProUGUI descriptionNameText;

    public void OnDicidAsset(AssetData asset)
    {
        assetNameText.text = asset.assetName;
        descriptionNameText.text = asset.description;
    }
}
