namespace Zendesk.Support.Requestlist
{
	public partial class RequestInfo : global::Java.Lang.Object
	{
		public partial class LastUpdatedComparator : global::Java.Lang.Object, global::Java.Util.IComparator
		{
			public int Compare(Java.Lang.Object o1, Java.Lang.Object o2)
			{
				var p1 = o1 as RequestInfo;
				var p2 = o2 as RequestInfo;
				return Compare(p1, p2);
			}
		}
	}
}