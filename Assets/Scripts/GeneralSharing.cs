using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class GeneralSharing : MonoBehaviour
{
    public static void OnShareSimpleText(){
        GeneralSharingIOSbridge.ShareSimpleText("Hello !!");
    }
}
