using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;



public class NativeShare : MonoBehaviour {
    private bool isProcessing = false;

    public void Share()
    {
        #if UNITY_IOS
        if(!isProcessing)
            ShareIOS("test", "test", "", new string[]{"/var/mobile/Containers/Data/Application/F3C0CCD3-9458-4194-A612-330CF63A3613/Documents/ARFarm_Result.pdf"});
        #else
        Debug.Log("No sharing set up for this platform.");
        #endif
    }
    #if UNITY_IOS
	public struct ConfigStruct
	{
		public string title;
		public string message;
	}

	[DllImport ("__Internal")] private static extern void showAlertMessage(ref ConfigStruct conf);

	public struct SocialSharingStruct
	{
		public string text;
		public string subject;
		public string filePaths;
	}

	[DllImport ("__Internal")] private static extern void showSocialSharing(ref SocialSharingStruct conf);

	public static void ShareIOS(string title, string message)
	{
		ConfigStruct conf = new ConfigStruct();
		conf.title  = title;
		conf.message = message;
		showAlertMessage(ref conf);
	}
    public static void ShareIOS(string body, string subject, string url, string[] filePaths)
	{
		SocialSharingStruct conf = new SocialSharingStruct();
		conf.text = body;
		string paths = string.Join(";", filePaths);
		if (string.IsNullOrEmpty(paths))
			paths = url;
		else if (!string.IsNullOrEmpty(url))
			paths += ";" + url;
		conf.filePaths = paths;
		conf.subject = subject;

		showSocialSharing(ref conf);
	}
#endif
}