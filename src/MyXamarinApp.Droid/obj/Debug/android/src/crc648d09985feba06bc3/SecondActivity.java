package crc648d09985feba06bc3;


public class SecondActivity
	extends crc642a2dbee71ee4dc3f.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyXamarinApp.Droid.Views.Main.SecondActivity, MyXamarinApp.Droid", SecondActivity.class, __md_methods);
	}


	public SecondActivity ()
	{
		super ();
		if (getClass () == SecondActivity.class) {
			mono.android.TypeManager.Activate ("MyXamarinApp.Droid.Views.Main.SecondActivity, MyXamarinApp.Droid", "", this, new java.lang.Object[] {  });
		}
	}


	public SecondActivity (int p0)
	{
		super (p0);
		if (getClass () == SecondActivity.class) {
			mono.android.TypeManager.Activate ("MyXamarinApp.Droid.Views.Main.SecondActivity, MyXamarinApp.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}

	private java.util.ArrayList refList;
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
