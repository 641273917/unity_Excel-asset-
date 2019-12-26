using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadAsset : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        ExcelLineManage LineManage = Resources.Load<ExcelLineManage>("Release/TESTEXCEL");
        foreach (var item in LineManage.dataArray)
        {
            Debug.Log(item.ID + "---" + item.ChinaName + "---" + item.EnglishName + "---" + item.Age + "---" + item.height + "---" + item.weight + "---" + item.address + "---" + item.zipcode + "---" + item.hobbit + "---" + item.Contact + "---" + item.emergencycontact);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
