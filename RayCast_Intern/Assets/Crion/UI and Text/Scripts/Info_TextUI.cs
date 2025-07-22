using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info_TextUI : MonoBehaviour
{
    public TextMeshProUGUI assetNameText;
    public TextMeshProUGUI descriptionText;
    public void OnDisplayAssetInfo(AssetDatum asset)
    {
        
        assetNameText.text = asset.assetName;
        descriptionText.text = asset.description;
    }
}
