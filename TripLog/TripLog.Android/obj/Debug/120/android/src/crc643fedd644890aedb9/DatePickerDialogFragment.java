package crc643fedd644890aedb9;


public class DatePickerDialogFragment
	extends android.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TripLog.Droid.Renderers.DatePickerDialogFragment, TripLog.Android", DatePickerDialogFragment.class, __md_methods);
	}


	public DatePickerDialogFragment ()
	{
		super ();
		if (getClass () == DatePickerDialogFragment.class) {
			mono.android.TypeManager.Activate ("TripLog.Droid.Renderers.DatePickerDialogFragment, TripLog.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);

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
