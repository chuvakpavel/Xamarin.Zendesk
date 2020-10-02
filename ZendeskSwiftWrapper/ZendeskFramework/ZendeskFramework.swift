//
//  ZendeskFramework.swift
//  ZendeskFramework
//
//  Created by ZaxaroVA on 9/23/20.
//  Copyright © 2020 Pavel Chuvak. All rights reserved.
//

import Foundation
import ZendeskProviderSDK
import ZendeskCoreSDK
import ZendeskSDK
import UIKit

@objc(ZendeskFramework)
public class ZendeskFramework : NSObject{
    
    private let navigationController = UINavigationController()
    
    @objc
    public func initZendesk(appId: String, clientId: String, zendeskUrl: String) -> Void{
        Zendesk.initialize(appId: appId, clientId: clientId, zendeskUrl: zendeskUrl)
        Support.initialize(withZendesk: Zendesk.instance)
    }
    
    @objc
    public func setAnonymousIdentity() -> Void{
        let identity = Identity.createAnonymous()
        Zendesk.instance?.setIdentity(identity)
    }
    
    @objc
    public func setIdentity(name: String, email: String) -> Void{
        let identity = Identity.createAnonymous(name: name, email: email)
        Zendesk.instance?.setIdentity(identity)
    }
    
    @objc
    public func setUniqueIdentity(token: String) -> Void{
        let identity = Identity.createJwt(token: token)
        Zendesk.instance?.setIdentity(identity)
    }
    
    @objc
    public func showTicketsViewController(animated: Bool, sender: UIViewController) -> Void{
        let requestListController = RequestUi.buildRequestList()
        showViewController(viewController: requestListController, sender: sender)
    }
    
    @objc
    public func getTicketsViewController(animated: Bool, sender: UIViewController) -> UIViewController{
        let requestListController = RequestUi.buildRequestList()
        return requestListController
    }
    
    @objc
    public func showTicketViewController(animated: Bool, sender: UIViewController) -> Void{
        let requestController = RequestUi.buildRequestUi(requestId: "<id>")
        showViewController(viewController: requestController, sender: sender)
    }
    
    @objc
    public func getTicketViewController(animated: Bool, sender: UIViewController) -> UIViewController{
        let requestController = RequestUi.buildRequestUi(requestId: "<id>")
        return requestController
    }
    @objc
    public func showViewController(viewController: UIViewController, sender: UIViewController) -> Void{
        sender.present(viewController, animated: true, completion: nil)
    }
}
