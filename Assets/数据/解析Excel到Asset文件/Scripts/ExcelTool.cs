/// <summary>
/// 读取excel表格的工具类
/// </summary>
/// 
using System.IO;
using System.Data;
using Excel;
using UnityEngine;
public class ExcelTool  
{
    public static Item[] CreatItemArrayWithExcel(string filePath)
    {
        //行与列
        int columnNum = 0, rowNum = 0;
        DataRowCollection collection = ReadExcel(filePath, ref columnNum, ref rowNum);//获得行与列的值
        //从第三行开始才是有效数据
        Item[] array = new Item[rowNum - 2];
        for (int i = 2; i < rowNum; i++)
        {
            Item item = new Item
            {
                ID = collection[i][0].ToString(),
                ChinaName = collection[i][1].ToString(),
                EnglishName = collection[i][2].ToString(),
                Age = collection[i][3].ToString(),
                height = collection[i][4].ToString(),
                weight = collection[i][5].ToString(),
                address = collection[i][6].ToString(),
                zipcode = collection[i][7].ToString(),
                hobbit = collection[i][8].ToString(),
                Contact = collection[i][9].ToString(),
                emergencycontact = collection[i][10].ToString(),
            };
            array[i - 2] = item;
        }
        return array;
    }
    /// <summary>
    /// 读取excel文件内容
    /// </summary>
    /// <param name="filePath">文件路径</param>
    /// <param name="columnnum">行数</param>
    /// <param name="rownum">列数</param>
    /// <returns></returns>
    static DataRowCollection ReadExcel(string filePath, ref int columnnum, ref int rownum)
    {
        FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
        DataSet result = excelReader.AsDataSet(); 
        //Tables[0] 下标0表示excel文件中第一张表的数据
        columnnum = result.Tables[0].Columns.Count;
        rownum = result.Tables[0].Rows.Count;
        stream.Close();
        return result.Tables[0].Rows; 
    }
}
