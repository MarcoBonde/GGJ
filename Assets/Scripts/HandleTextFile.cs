using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class HandleTextFile:MonoBehaviour
{
    static string path;
    static private GameObject nomeUtente;
    static private GameObject nomeCanale;
    static private GameObject authString;
    private static string fileContent;
    public static string userNameString;
    public static string userChannelString;
    public static string userAuthString;

    private void Awake() {
        path = "Assets/Resources/setting.txt";
        nomeUtente = GameObject.Find("InUser");
        nomeCanale = GameObject.Find("InChannel");
        authString = GameObject.Find("InStringa");
        ReadString();
        UpdateValue();
        writeOnTextbox();
    }
    private static void UpdateValue()
    {
        string[] content = fileContent.Split(',');
        userNameString = content[0];
        userChannelString = content[1];
        userAuthString = content[2];
    }
    [MenuItem("Tools/Write file")]
    static void WriteString(string whatToWrite)
    {

        //Write some text to the test.txt file
        var stream = new FileStream(path, FileMode.Truncate);
        StreamWriter writer = new StreamWriter(stream);

        writer.Write(whatToWrite);
        writer.Close();
    }

    [MenuItem("Tools/Read file")]
    static void ReadString()
    {

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        fileContent = reader.ReadToEnd();

        reader.Close();
    }
    private static void writeOnTextbox() {
        string[] content = fileContent.Split(',');

        nomeUtente.GetComponent<InputField>().text = content[0];
        nomeCanale.GetComponent<InputField>().text = content[1];
        authString.GetComponent<InputField>().text = content[2];
    }
    public static void writeSetting() {
        string nome = nomeUtente.GetComponent<InputField>().text;
        string canale = nomeCanale.GetComponent<InputField>().text;
        string stringAuth = authString.GetComponent<InputField>().text;
        var stringToWrite = nome+","+canale+","+stringAuth;
        WriteString(stringToWrite);
    }
}