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
    private let zendeskVC = ZendeskFrameworkVC()
    
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
    public func showTicketScreen(animated: Bool, sender: UIViewController) -> Void{
        let requestListController = RequestUi.buildRequestList()
        show(viewController: requestListController, sender: sender)
    }
    
    @objc
    private func show(viewController: UIViewController, sender: UIViewController) -> Void{
        zendeskVC.showZendesk(vc: viewController, sender: sender)
    }
}
