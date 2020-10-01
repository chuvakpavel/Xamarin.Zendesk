using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using UIKit;


namespace ZendeskFramework.iOS
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

		// -(void)showTicketsViewControllerWithAnimated:(BOOL)animated sender:(UIViewController * _Nonnull)sender;
		[Export("showTicketsViewControllerWithAnimated:sender:")]
		void ShowTicketsViewControllerWithAnimated(bool animated, UIViewController sender);

		// -(UIViewController * _Nonnull)getTicketsViewControllerWithAnimated:(BOOL)animated sender:(UIViewController * _Nonnull)sender __attribute__((warn_unused_result("")));
		[Export("getTicketsViewControllerWithAnimated:sender:")]
		UIViewController GetTicketsViewControllerWithAnimated(bool animated, UIViewController sender);

		// -(void)showTicketViewControllerWithAnimated:(BOOL)animated sender:(UIViewController * _Nonnull)sender;
		[Export("showTicketViewControllerWithAnimated:sender:")]
		void ShowTicketViewControllerWithAnimated(bool animated, UIViewController sender);

		// -(UIViewController * _Nonnull)getTicketViewControllerWithAnimated:(BOOL)animated sender:(UIViewController * _Nonnull)sender __attribute__((warn_unused_result("")));
		[Export("getTicketViewControllerWithAnimated:sender:")]
		UIViewController GetTicketViewControllerWithAnimated(bool animated, UIViewController sender);

		// -(void)showViewControllerWithViewController:(UIViewController * _Nonnull)viewController sender:(UIViewController * _Nonnull)sender;
		[Export("showViewControllerWithViewController:sender:")]
		void ShowViewControllerWithViewController(UIViewController viewController, UIViewController sender);
	}
}