﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationWindow.SignUpServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SignUpServiceReference.ISignUpService")]
    public interface ISignUpService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/GetCode", ReplyAction="http://tempuri.org/ISignUpService/GetCodeResponse")]
        int GetCode(string p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/GetCode", ReplyAction="http://tempuri.org/ISignUpService/GetCodeResponse")]
        System.Threading.Tasks.Task<int> GetCodeAsync(string p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/SignUp", ReplyAction="http://tempuri.org/ISignUpService/SignUpResponse")]
        bool SignUp(string phone, string password, string email, int code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISignUpService/SignUp", ReplyAction="http://tempuri.org/ISignUpService/SignUpResponse")]
        System.Threading.Tasks.Task<bool> SignUpAsync(string phone, string password, string email, int code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISignUpServiceChannel : RegistrationWindow.SignUpServiceReference.ISignUpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SignUpServiceClient : System.ServiceModel.ClientBase<RegistrationWindow.SignUpServiceReference.ISignUpService>, RegistrationWindow.SignUpServiceReference.ISignUpService {
        
        public SignUpServiceClient() {
        }
        
        public SignUpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SignUpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignUpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SignUpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetCode(string p) {
            return base.Channel.GetCode(p);
        }
        
        public System.Threading.Tasks.Task<int> GetCodeAsync(string p) {
            return base.Channel.GetCodeAsync(p);
        }
        
        public bool SignUp(string phone, string password, string email, int code) {
            return base.Channel.SignUp(phone, password, email, code);
        }
        
        public System.Threading.Tasks.Task<bool> SignUpAsync(string phone, string password, string email, int code) {
            return base.Channel.SignUpAsync(phone, password, email, code);
        }
    }
}