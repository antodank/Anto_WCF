﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuplexClient.ProcessService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProcessService.IProcess1", CallbackContract=typeof(DuplexClient.ProcessService.IProcess1Callback))]
    public interface IProcess1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcess1/TaskProcess", ReplyAction="http://tempuri.org/IProcess1/TaskProcessResponse")]
        void TaskProcess();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcess1/TaskProcess", ReplyAction="http://tempuri.org/IProcess1/TaskProcessResponse")]
        System.Threading.Tasks.Task TaskProcessAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProcess1Callback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcess1/TaskProcessStatus", ReplyAction="http://tempuri.org/IProcess1/TaskProcessStatusResponse")]
        void TaskProcessStatus(int percentCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProcess1Channel : DuplexClient.ProcessService.IProcess1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Process1Client : System.ServiceModel.DuplexClientBase<DuplexClient.ProcessService.IProcess1>, DuplexClient.ProcessService.IProcess1 {
        
        public Process1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Process1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Process1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Process1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Process1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void TaskProcess() {
            base.Channel.TaskProcess();
        }
        
        public System.Threading.Tasks.Task TaskProcessAsync() {
            return base.Channel.TaskProcessAsync();
        }
    }
}