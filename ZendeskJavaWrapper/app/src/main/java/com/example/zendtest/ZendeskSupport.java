package com.example.zendtest;

import android.content.Context;

import zendesk.core.AnonymousIdentity;
import zendesk.core.Identity;
import zendesk.core.Zendesk;
import zendesk.support.Support;
import zendesk.support.request.RequestActivity;
import zendesk.support.requestlist.RequestListActivity;

public class ZendeskSupport {
    public  void Init(Context cont, String zendeskUrl, String appId, String clientId)
    {
        Zendesk.INSTANCE.init(cont, zendeskUrl, appId, clientId);
        Identity identity = new AnonymousIdentity();
        Zendesk.INSTANCE.setIdentity(identity);
        Support.INSTANCE.init(Zendesk.INSTANCE);
    }

    public  void ShowRequestActivity(Context cont)
    {
        RequestActivity.builder()
                .show(cont);
    }
    public void ShowRequestListActivity(Context cont)
    {
        RequestListActivity.builder()
                .show(cont);
    }
}