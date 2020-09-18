using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace NativeLibrary
{
	// @interface ZendeskFramework : NSObject
	[BaseType(typeof(NSObject))]
	interface ZendeskFramework
	{
		// -(void)initZendeskWithAppId:(NSString * _Nonnull)appId clientId:(NSString * _Nonnull)clientId zendeskUrl:(NSString * _Nonnull)zendeskUrl __attribute__((objc_method_family("none")));
		[Export("initZendeskWithAppId:clientId:zendeskUrl:")]
		void InitZendeskWithAppId(string appId, string clientId, string zendeskUrl);
	}
}