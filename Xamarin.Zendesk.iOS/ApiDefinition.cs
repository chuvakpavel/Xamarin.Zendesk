using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using UIKit;


namespace Xamarin.Zendesk.iOS
{

	// @interface ZendeskFramework : NSObject
	[BaseType(typeof(NSObject))]
	interface ZendeskFramework
	{
		// -(void)initZendeskWithAppId:(NSString * _Nonnull)appId clientId:(NSString * _Nonnull)clientId zendeskUrl:(NSString * _Nonnull)zendeskUrl __attribute__((objc_method_family("none")));
		[Export("initZendeskWithAppId:clientId:zendeskUrl:")]
		void InitZendeskWithAppId(string appId, string clientId, string zendeskUrl);

		// -(void)setAnonymousIdentity;
		[Export("setAnonymousIdentity")]
		void SetAnonymousIdentity();

		// -(void)setIdentityWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email;
		[Export("setIdentityWithName:email:")]
		void SetIdentityWithName(string name, string email);

		// -(void)setUniqueIdentityWithToken:(NSString * _Nonnull)token;
		[Export("setUniqueIdentityWithToken:")]
		void SetUniqueIdentityWithToken(string token);

		// -(void)showTicketScreenWithAnimated:(BOOL)animated sender:(UIViewController * _Nonnull)sender;
		[Export("showTicketScreenWithAnimated:sender:")]
		void ShowTicketScreenWithAnimated(bool animated, UIViewController sender);

		// -(void)showWithViewController:(UIViewController * _Nonnull)viewController sender:(UIViewController * _Nonnull)sender;
		[Export("showWithViewController:sender:")]
		void ShowWithViewController(UIViewController viewController, UIViewController sender);
	}

}