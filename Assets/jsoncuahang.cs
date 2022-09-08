
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class jsoncuahang : MonoBehaviour
{

    public static jsoncuahang inten;
    public InputField sungdo;
    public InputField giatien;
    public InputField satthuong;

    public void _Sungdo1()
    {
        json data = new json();

        data.SUNGDO = sungdo.text;
        data.GIATIEN = giatien.text;
        data.SATTHUONG = satthuong.text;

        string jsonn = JsonUtility.ToJson(data,true);
        File.WriteAllText(Application.dataPath + "/Fromjson.json", jsonn);
    }
    public void _hienthi()
    {
       string jsonnn = File.ReadAllText(Application.dataPath + "/Fromjson.json");
        json data = JsonUtility.FromJson<json>(jsonnn);
        sungdo.text = data.SUNGDO;
        giatien.text = data.GIATIEN;
        satthuong.text = data.SATTHUONG;
    }
}
