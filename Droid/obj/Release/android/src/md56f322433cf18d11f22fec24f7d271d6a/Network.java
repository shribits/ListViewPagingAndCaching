package md56f322433cf18d11f22fec24f7d271d6a;


public class Network
	extends md5c1bf5d923ac0cddfc21fa474230ef062.BroadcastMonitor
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceive:(Landroid/content/Context;Landroid/content/Intent;)V:GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("XLabs.Platform.Services.Network, XLabs.Platform.Droid, Version=2.0.5782.12262, Culture=neutral, PublicKeyToken=null", Network.class, __md_methods);
	}


	public Network () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Network.class)
			mono.android.TypeManager.Activate ("XLabs.Platform.Services.Network, XLabs.Platform.Droid, Version=2.0.5782.12262, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onReceive (android.content.Context p0, android.content.Intent p1)
	{
		n_onReceive (p0, p1);
	}

	private native void n_onReceive (android.content.Context p0, android.content.Intent p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
