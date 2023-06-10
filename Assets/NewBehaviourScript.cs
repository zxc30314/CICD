using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class MyClass
{
    // See https://aka.ms/new-console-template for more information
    
    
    [DllImport("user32.dll")]
    static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int width, int height, uint flags);
    
    [DllImport("user32.dll")]
    static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

    public MyClass()
    {
        GetSize();
        SetSize();
    }
    
    static void GetSize()
    {
        // 指定目標應用程式的進程名稱
        string processName = "Client";
    
        Process[] processes = Process.GetProcessesByName(processName);
        foreach (var process in processes)
        {
            // 取得第一個符合進程名稱的進程
    
            IntPtr windowHandle = process.MainWindowHandle;
    
            if (windowHandle != IntPtr.Zero)
            {
                RECT windowRect;
                GetWindowRect(windowHandle, out windowRect);
    
                int windowWidth = windowRect.Right - windowRect.Left;
                int windowHeight = windowRect.Bottom - windowRect.Top;
    
                Console.WriteLine("視窗寬度: " + windowWidth);
                Console.WriteLine("視窗高度: " + windowHeight);
            }
            else
            {
                Console.WriteLine("找不到應用程式的視窗。");
            }
        }
    }
    
    static void SetSize()
    {
        // 指定目標應用程式的進程名稱
        string processName = "Client";
    
        Process[] processes = Process.GetProcessesByName(processName);
        foreach (var process in processes)
        {
            IntPtr windowHandle = process.MainWindowHandle;
    
            if (windowHandle != IntPtr.Zero)
            {
                // 設定新的視窗大小和位置
                SetWindowPos(windowHandle, IntPtr.Zero, 0, 0, 2560, 1377, 0x0040);
    
                Console.WriteLine("視窗大小已修改。");
            }
            else
            {
                Console.WriteLine("找不到應用程式的視窗。");
            }
        }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
}