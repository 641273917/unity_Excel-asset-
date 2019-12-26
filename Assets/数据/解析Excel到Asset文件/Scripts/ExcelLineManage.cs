/// <summary>
/// 读取excel的每行数据
/// </summary>
using UnityEngine;
public class ExcelLineManage:ScriptableObject  
{
    public Item[] dataArray;
}
//excel表格中的每列数据名称
[System.Serializable]
public class Item
{
    public string ID;
    public string ChinaName;
    public string EnglishName;
    public string Age;
    public string height;
    public string weight;
    public string address;
    public string zipcode;
    public string hobbit;
    public string Contact;
    public string emergencycontact;
}
