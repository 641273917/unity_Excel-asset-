using System.IO;
using UnityEditor;
using UnityEngine;

public class CreatAssetWithExcel : Editor
{
    [MenuItem("Tools/生成asset文件")]
    private static void CreatExcel()
    {
            ExcelLineManage manager = ScriptableObject.CreateInstance<ExcelLineManage>();
            //赋值
            manager.dataArray = ExcelTool.CreatItemArrayWithExcel(ExcelConfig.excelsFolderPath + "TESTEXCEL.xlsx");
            //确保文件夹存在
            if (!Directory.Exists(ExcelConfig.assetPath))
            {
                Directory.CreateDirectory(ExcelConfig.assetPath);
            }

            //asset文件的路径 要以"Assets/..."开始，否则CreateAsset会报错
            string assetPath = string.Format("{0}{1}.asset", ExcelConfig.assetPath, "TESTEXCEL");
            //生成一个Asset文件
            AssetDatabase.CreateAsset(manager, assetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh(); 
    }
}