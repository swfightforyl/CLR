﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JDD.Log.LogService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LogService.IExchange")]
    public interface IExchange {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchange/Write", ReplyAction="http://tempuri.org/IExchange/WriteResponse")]
        string Write(string logType, int siteID, byte alertLevel, string subject, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchange/Insert", ReplyAction="http://tempuri.org/IExchange/InsertResponse")]
        string Insert(string logType, int siteID, byte alertLevel, string subject, string content, string ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchange/Add", ReplyAction="http://tempuri.org/IExchange/AddResponse")]
        string Add(System.Collections.Generic.Dictionary<string, string> logItems);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExchangeChannel : JDD.Log.LogService.IExchange, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExchangeClient : System.ServiceModel.ClientBase<JDD.Log.LogService.IExchange>, JDD.Log.LogService.IExchange {
        
        public ExchangeClient() {
        }
        
        public ExchangeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExchangeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Write(string logType, int siteID, byte alertLevel, string subject, string content) {
            return base.Channel.Write(logType, siteID, alertLevel, subject, content);
        }
        
        public string Insert(string logType, int siteID, byte alertLevel, string subject, string content, string ip) {
            return base.Channel.Insert(logType, siteID, alertLevel, subject, content, ip);
        }
        
        public string Add(System.Collections.Generic.Dictionary<string, string> logItems) {
            return base.Channel.Add(logItems);
        }
    }
}
