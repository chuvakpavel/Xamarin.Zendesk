//
//  ZendeskFramework.swift
//  ZendeskFramework
//
//  Created by ZaxaroVA on 9/18/20.
//  Copyright © 2020 Pavel Chuvak. All rights reserved.
//

import Foundation
import SupportProvidersSDK
import ZendeskCoreSDK

@objc(ZendeskFramework)
public class ZendeskFramework : NSObject{
    @objc
    public func initZendesk(appId: String, clientId: String, zendeskUrl: String) -> Void{
        Zendesk.initialize(appId: appId, clientId: clientId, zendeskUrl: zendeskUrl)
        Support.initialize(withZendesk: Zendesk.instance)
    }
}
