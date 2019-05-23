package md532156ac1f28a8cecd5b9bbe7ea2d55d5;


public class ShipAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("shipmenttracking.ShipAdapterViewHolder, shipmenttracking", ShipAdapterViewHolder.class, __md_methods);
	}


	public ShipAdapterViewHolder ()
	{
		super ();
		if (getClass () == ShipAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("shipmenttracking.ShipAdapterViewHolder, shipmenttracking", "", this, new java.lang.Object[] {  });
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
