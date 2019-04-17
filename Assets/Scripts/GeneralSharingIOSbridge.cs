using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class GeneralSharingIOSbridge
{
    [DllImport("_Internal")]
    private static extern void _TAG_ShareSimpleText(string message);
    public static void ShareSimpleText(string message){
        _TAG_ShareSimpleText(message);
    }
}
