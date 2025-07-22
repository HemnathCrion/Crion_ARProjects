using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AssetDatum
{
    public string assetName;
    public string description;

}

public class Asset : MonoBehaviour
{
    public AssetDatum assetDatum;

    public void Init(AssetDatum _datum)
    {
        assetDatum = _datum;
    }
}


