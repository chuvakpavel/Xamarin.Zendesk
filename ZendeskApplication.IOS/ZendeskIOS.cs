using UIKit;

namespace ZendeskApplication.IOS
{
    public  class ZendeskIOS
    {
        private static ZendeskIOS _instance;
        public static ZendeskIOS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ZendeskIOS();

                }
                return _instance;
            }

        }

        private ZendeskFramework.iOS.ZendeskFramework zendesk;

        private ZendeskIOS()
        {
            zendesk = new ZendeskFramework.iOS.ZendeskFramework();
        }

        public void Init()
        {
            zendesk.InitZendeskWithAppId(
                  "5541d2e6f34fc836de9c4fa4c76a1c3a2561f6815cce389f",
                  "mobile_sdk_client_fb6b3cb1d2c6a4587eed",
                  "https://groupehbfhelp.zendesk.com");
            zendesk.SetAnonymousIdentity();
        }
        public UIViewController GetTicketsViewContriller(UIViewController sender) { return zendesk.GetTicketsViewControllerWithAnimated(true, sender); }
    }
}
 