using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapItem : MonoBehaviour {
    public string iconName;
    private GameObject MiniMapIconGO;
    private Transform player;
    private Transform iconTrans;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        MiniMapIconGO = MiniMap._instance.AddIcon(iconName);
        iconTrans = MiniMapIconGO.transform;
	}
    void FixedUpdate()
    {
        Vector3 offset = transform.position - player.position;
        iconTrans.localPosition = new Vector3(offset.x, offset.z, 0) * 4;//*4是小地图的长宽约是实景中的4倍（不考虑单位不同）
    }
    void OnDestroy()
    {
        Destroy(this.MiniMapIconGO);
    }
}
