using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {
    //单例模式
    public static MiniMap _instance;
    public GameObject iconPrefab;
    void Awake()
    {
        _instance = this;
    }
    public GameObject AddIcon(string iconname)
    {
        GameObject go = NGUITools.AddChild(this.gameObject, iconPrefab);
        go.GetComponent<UISprite>().spriteName = iconname;//设置图标的名字，更新图标的显示
        return go;
    }
}
