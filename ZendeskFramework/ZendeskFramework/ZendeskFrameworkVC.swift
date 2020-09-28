//
//  ZendeskFrameworkVC.swift
//  ZendeskFramework
//
//  Created by ZaxaroVA on 9/28/20.
//  Copyright © 2020 Pavel Chuvak. All rights reserved.
//

import Foundation
import UIKit

class ZendeskFrameworkVC: UIViewController{
    
    @objc
    public func showZendesk(vc: UIViewController, sender: UIViewController) -> Void{
        
        sender.present(vc, animated: true, completion: nil)
    }
}
