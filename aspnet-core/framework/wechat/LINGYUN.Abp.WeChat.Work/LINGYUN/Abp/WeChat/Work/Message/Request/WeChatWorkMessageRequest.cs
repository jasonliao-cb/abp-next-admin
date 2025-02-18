﻿namespace LINGYUN.Abp.WeChat.Work.Message.Request;
public class WeChatWorkMessageRequest<TMessage>
{
    public string AccessToken { get; set; }
    public TMessage Message { get; set; }
    public WeChatWorkMessageRequest(string accessToken, TMessage message)
    {
        AccessToken = accessToken;
        Message = message;
    }
}
