﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserWindow.EmailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmailService.IEmailService")]
    public interface IEmailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmail", ReplyAction="http://tempuri.org/IEmailService/SendEmailResponse")]
        bool SendEmail(string email, string name, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmailService/SendEmail", ReplyAction="http://tempuri.org/IEmailService/SendEmailResponse")]
        System.Threading.Tasks.Task<bool> SendEmailAsync(string email, string name, string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmailServiceChannel : UserWindow.EmailService.IEmailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServiceClient : System.ServiceModel.ClientBase<UserWindow.EmailService.IEmailService>, UserWindow.EmailService.IEmailService {
        
        public EmailServiceClient() {
        }
        
        public EmailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendEmail(string email, string name, string text) {
            return base.Channel.SendEmail(email, name, text);
        }
        
        public System.Threading.Tasks.Task<bool> SendEmailAsync(string email, string name, string text) {
            return base.Channel.SendEmailAsync(email, name, text);
        }
    }
}
