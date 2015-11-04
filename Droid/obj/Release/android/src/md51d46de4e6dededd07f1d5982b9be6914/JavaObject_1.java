package md51d46de4e6dededd07f1d5982b9be6914;


public class JavaObject_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XLabs.Platform.JavaObject`1, XLabs.Platform.Droid, Version=2.0.5782.12262, Culture=neutral, PublicKeyToken=null", JavaObject_1.class, __md_methods);
	}


	public JavaObject_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == JavaObject_1.class)
			mono.android.TypeManager.Activate ("XLabs.Platform.JavaObject`1, XLabs.Platform.Droid, Version=2.0.5782.12262, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
