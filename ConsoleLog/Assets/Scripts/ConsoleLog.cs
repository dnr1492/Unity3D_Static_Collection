using UnityEngine;

public static class ConsoleLog
{
    public static void Show(string text)
    {
        string color = "124896";
        ShowMessage(text, color);
    }

    public static void Show(int text)
    {
        string color = "124896";
        ShowMessage(text.ToString(), color);
    }

    public static void ShowError(string text)
    {
        string color = "962412";
        ShowMessage(text, color);
    }

    private static void ShowMessage(string text, string color)
    {
        color = "6bf0ff";
        Debug.Log($"<color=#108020><b>Unity3D</b></color> : <color=#{color}>{text}</color>");
    }
}