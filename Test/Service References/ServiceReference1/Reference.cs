﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SMSModel_Send", Namespace="http://schemas.datacontract.org/2004/07/PMS.Model.SMSModel")]
    [System.SerializableAttribute()]
    public partial class SMSModel_Send : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string accountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string msgidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] phonesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime sendtimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string subcodeField;
        
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
        public string account {
            get {
                return this.accountField;
            }
            set {
                if ((object.ReferenceEquals(this.accountField, value) != true)) {
                    this.accountField = value;
                    this.RaisePropertyChanged("account");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string msgid {
            get {
                return this.msgidField;
            }
            set {
                if ((object.ReferenceEquals(this.msgidField, value) != true)) {
                    this.msgidField = value;
                    this.RaisePropertyChanged("msgid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] phones {
            get {
                return this.phonesField;
            }
            set {
                if ((object.ReferenceEquals(this.phonesField, value) != true)) {
                    this.phonesField = value;
                    this.RaisePropertyChanged("phones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime sendtime {
            get {
                return this.sendtimeField;
            }
            set {
                if ((this.sendtimeField.Equals(value) != true)) {
                    this.sendtimeField = value;
                    this.RaisePropertyChanged("sendtime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string subcode {
            get {
                return this.subcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.subcodeField, value) != true)) {
                    this.subcodeField = value;
                    this.RaisePropertyChanged("subcode");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SMSModel_Receive", Namespace="http://schemas.datacontract.org/2004/07/PMS.Model.SMSModel")]
    [System.SerializableAttribute()]
    public partial class SMSModel_Receive : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] failPhonesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string msgidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string resultField;
        
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
        public string desc {
            get {
                return this.descField;
            }
            set {
                if ((object.ReferenceEquals(this.descField, value) != true)) {
                    this.descField = value;
                    this.RaisePropertyChanged("desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] failPhones {
            get {
                return this.failPhonesField;
            }
            set {
                if ((object.ReferenceEquals(this.failPhonesField, value) != true)) {
                    this.failPhonesField = value;
                    this.RaisePropertyChanged("failPhones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string msgid {
            get {
                return this.msgidField;
            }
            set {
                if ((object.ReferenceEquals(this.msgidField, value) != true)) {
                    this.msgidField = value;
                    this.RaisePropertyChanged("msgid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string result {
            get {
                return this.resultField;
            }
            set {
                if ((object.ReferenceEquals(this.resultField, value) != true)) {
                    this.resultField = value;
                    this.RaisePropertyChanged("result");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISMSService")]
    public interface ISMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMSService/SendMsg", ReplyAction="http://tempuri.org/ISMSService/SendMsgResponse")]
        Test.ServiceReference1.SendMsgResponse SendMsg(Test.ServiceReference1.SendMsgRequest request);
        
        // CODEGEN: 正在生成消息协定，应为该操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMSService/SendMsg", ReplyAction="http://tempuri.org/ISMSService/SendMsgResponse")]
        System.Threading.Tasks.Task<Test.ServiceReference1.SendMsgResponse> SendMsgAsync(Test.ServiceReference1.SendMsgRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendMsg", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendMsgRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Test.ServiceReference1.SMSModel_Send smsdata;
        
        public SendMsgRequest() {
        }
        
        public SendMsgRequest(Test.ServiceReference1.SMSModel_Send smsdata) {
            this.smsdata = smsdata;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendMsgResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendMsgResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool SendMsgResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public Test.ServiceReference1.SMSModel_Receive receiveModel;
        
        public SendMsgResponse() {
        }
        
        public SendMsgResponse(bool SendMsgResult, Test.ServiceReference1.SMSModel_Receive receiveModel) {
            this.SendMsgResult = SendMsgResult;
            this.receiveModel = receiveModel;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISMSServiceChannel : Test.ServiceReference1.ISMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMSServiceClient : System.ServiceModel.ClientBase<Test.ServiceReference1.ISMSService>, Test.ServiceReference1.ISMSService {
        
        public SMSServiceClient() {
        }
        
        public SMSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Test.ServiceReference1.SendMsgResponse Test.ServiceReference1.ISMSService.SendMsg(Test.ServiceReference1.SendMsgRequest request) {
            return base.Channel.SendMsg(request);
        }
        
        public bool SendMsg(Test.ServiceReference1.SMSModel_Send smsdata, out Test.ServiceReference1.SMSModel_Receive receiveModel) {
            Test.ServiceReference1.SendMsgRequest inValue = new Test.ServiceReference1.SendMsgRequest();
            inValue.smsdata = smsdata;
            Test.ServiceReference1.SendMsgResponse retVal = ((Test.ServiceReference1.ISMSService)(this)).SendMsg(inValue);
            receiveModel = retVal.receiveModel;
            return retVal.SendMsgResult;
        }
        
        public System.Threading.Tasks.Task<Test.ServiceReference1.SendMsgResponse> SendMsgAsync(Test.ServiceReference1.SendMsgRequest request) {
            return base.Channel.SendMsgAsync(request);
        }
    }
}
