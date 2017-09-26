﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABICommercialProject.ABIService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ABIService.IABIService")]
    public interface IABIService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/GetCollaborateur", ReplyAction="http://tempuri.org/IABIService/GetCollaborateurResponse")]
        ABIModel.Collaborateur GetCollaborateur(int idCollabo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/GetCollaborateur", ReplyAction="http://tempuri.org/IABIService/GetCollaborateurResponse")]
        System.Threading.Tasks.Task<ABIModel.Collaborateur> GetCollaborateurAsync(int idCollabo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/GetCollaborateurList", ReplyAction="http://tempuri.org/IABIService/GetCollaborateurListResponse")]
        ABIModel.Collaborateur[] GetCollaborateurList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/GetCollaborateurList", ReplyAction="http://tempuri.org/IABIService/GetCollaborateurListResponse")]
        System.Threading.Tasks.Task<ABIModel.Collaborateur[]> GetCollaborateurListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/UpdateCollabo", ReplyAction="http://tempuri.org/IABIService/UpdateCollaboResponse")]
        void UpdateCollabo(ABIModel.Collaborateur collabo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/UpdateCollabo", ReplyAction="http://tempuri.org/IABIService/UpdateCollaboResponse")]
        System.Threading.Tasks.Task UpdateCollaboAsync(ABIModel.Collaborateur collabo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/getName", ReplyAction="http://tempuri.org/IABIService/getNameResponse")]
        string getName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IABIService/getName", ReplyAction="http://tempuri.org/IABIService/getNameResponse")]
        System.Threading.Tasks.Task<string> getNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IABIServiceChannel : ABICommercialProject.ABIService.IABIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ABIServiceClient : System.ServiceModel.ClientBase<ABICommercialProject.ABIService.IABIService>, ABICommercialProject.ABIService.IABIService {
        
        public ABIServiceClient() {
        }
        
        public ABIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ABIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ABIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ABIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ABIModel.Collaborateur GetCollaborateur(int idCollabo) {
            return base.Channel.GetCollaborateur(idCollabo);
        }
        
        public System.Threading.Tasks.Task<ABIModel.Collaborateur> GetCollaborateurAsync(int idCollabo) {
            return base.Channel.GetCollaborateurAsync(idCollabo);
        }
        
        public ABIModel.Collaborateur[] GetCollaborateurList() {
            return base.Channel.GetCollaborateurList();
        }
        
        public System.Threading.Tasks.Task<ABIModel.Collaborateur[]> GetCollaborateurListAsync() {
            return base.Channel.GetCollaborateurListAsync();
        }
        
        public void UpdateCollabo(ABIModel.Collaborateur collabo) {
            base.Channel.UpdateCollabo(collabo);
        }
        
        public System.Threading.Tasks.Task UpdateCollaboAsync(ABIModel.Collaborateur collabo) {
            return base.Channel.UpdateCollaboAsync(collabo);
        }
        
        public string getName() {
            return base.Channel.getName();
        }
        
        public System.Threading.Tasks.Task<string> getNameAsync() {
            return base.Channel.getNameAsync();
        }
    }
}
