﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSFactory.ServiceReference_MMSService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MMSFactoryServiceLib")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_MMSService.IMMSService")]
    public interface IMMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/GetData", ReplyAction="http://tempuri.org/IMMSService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/GetData", ReplyAction="http://tempuri.org/IMMSService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMMSService/GetDataUsingDataContractResponse")]
        SMSFactory.ServiceReference_MMSService.CompositeType GetDataUsingDataContract(SMSFactory.ServiceReference_MMSService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IMMSService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<SMSFactory.ServiceReference_MMSService.CompositeType> GetDataUsingDataContractAsync(SMSFactory.ServiceReference_MMSService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/SendMsg", ReplyAction="http://tempuri.org/IMMSService/SendMsgResponse")]
        SMSFactory.ServiceReference_MMSService.SendMsgResponse SendMsg(SMSFactory.ServiceReference_MMSService.SendMsgRequest request);
        
        // CODEGEN: 正在生成消息协定，应为该操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMMSService/SendMsg", ReplyAction="http://tempuri.org/IMMSService/SendMsgResponse")]
        System.Threading.Tasks.Task<SMSFactory.ServiceReference_MMSService.SendMsgResponse> SendMsgAsync(SMSFactory.ServiceReference_MMSService.SendMsgRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendMsg", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendMsgRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public PMS.Model.SMSModel.MMSModel_Send sendModel;
        
        public SendMsgRequest() {
        }
        
        public SendMsgRequest(PMS.Model.SMSModel.MMSModel_Send sendModel) {
            this.sendModel = sendModel;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendMsgResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendMsgResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool SendMsgResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public PMS.Model.SMSModel.MMSModel_Receive receiveModel;
        
        public SendMsgResponse() {
        }
        
        public SendMsgResponse(bool SendMsgResult, PMS.Model.SMSModel.MMSModel_Receive receiveModel) {
            this.SendMsgResult = SendMsgResult;
            this.receiveModel = receiveModel;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMMSServiceChannel : SMSFactory.ServiceReference_MMSService.IMMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MMSServiceClient : System.ServiceModel.ClientBase<SMSFactory.ServiceReference_MMSService.IMMSService>, SMSFactory.ServiceReference_MMSService.IMMSService {
        
        public MMSServiceClient() {
        }
        
        public MMSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MMSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MMSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public SMSFactory.ServiceReference_MMSService.CompositeType GetDataUsingDataContract(SMSFactory.ServiceReference_MMSService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<SMSFactory.ServiceReference_MMSService.CompositeType> GetDataUsingDataContractAsync(SMSFactory.ServiceReference_MMSService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SMSFactory.ServiceReference_MMSService.SendMsgResponse SMSFactory.ServiceReference_MMSService.IMMSService.SendMsg(SMSFactory.ServiceReference_MMSService.SendMsgRequest request) {
            return base.Channel.SendMsg(request);
        }
        
        public bool SendMsg(PMS.Model.SMSModel.MMSModel_Send sendModel, out PMS.Model.SMSModel.MMSModel_Receive receiveModel) {
            SMSFactory.ServiceReference_MMSService.SendMsgRequest inValue = new SMSFactory.ServiceReference_MMSService.SendMsgRequest();
            inValue.sendModel = sendModel;
            SMSFactory.ServiceReference_MMSService.SendMsgResponse retVal = ((SMSFactory.ServiceReference_MMSService.IMMSService)(this)).SendMsg(inValue);
            receiveModel = retVal.receiveModel;
            return retVal.SendMsgResult;
        }
        
        public System.Threading.Tasks.Task<SMSFactory.ServiceReference_MMSService.SendMsgResponse> SendMsgAsync(SMSFactory.ServiceReference_MMSService.SendMsgRequest request) {
            return base.Channel.SendMsgAsync(request);
        }
    }
}
