using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyitem : MonoBehaviour
{
    private GameObject unitychan;

    void Start()
    {
        //シーン中のunitychanオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }
    void Update()
    {
        //unitychanがアイテムを通り越した場合
        if (this.transform.position.z < this.unitychan.transform.position.z)
        {
            //スクリプトがついているオブジェクトを削除
            Destroy(gameObject);

        }
    }
}
