﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLR读书笔记二.Greet {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Greet.Igreeting")]
    public interface Igreeting {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igreeting/sayhi", ReplyAction="http://tempuri.org/Igreeting/sayhiResponse")]
        string sayhi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Igreeting/sayhi", ReplyAction="http://tempuri.org/Igreeting/sayhiResponse")]
        System.Threading.Tasks.Task<string> sayhiAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IgreetingChannel : CLR读书笔记二.Greet.Igreeting, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IgreetingClient : System.ServiceModel.ClientBase<CLR读书笔记二.Greet.Igreeting>, CLR读书笔记二.Greet.Igreeting {
        
        public IgreetingClient() {
        }
        
        public IgreetingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IgreetingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgreetingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IgreetingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string sayhi() {
            return base.Channel.sayhi();
        }
        
        public System.Threading.Tasks.Task<string> sayhiAsync() {
            return base.Channel.sayhiAsync();
        }
    }
}
