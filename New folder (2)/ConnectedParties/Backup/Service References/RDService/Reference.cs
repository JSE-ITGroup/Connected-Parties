﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5472
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectedParties.RDService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReturnInfo", Namespace="http://schemas.datacontract.org/2004/07/RDService")]
    [System.SerializableAttribute()]
    public partial class ReturnInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConnectedParties.RDService.ErrorInfo ErrorInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConnectedParties.RDService.IDInfo[] IDInfoField;
        
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
        public ConnectedParties.RDService.ErrorInfo ErrorInfo {
            get {
                return this.ErrorInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorInfoField, value) != true)) {
                    this.ErrorInfoField = value;
                    this.RaisePropertyChanged("ErrorInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasError {
            get {
                return this.HasErrorField;
            }
            set {
                if ((this.HasErrorField.Equals(value) != true)) {
                    this.HasErrorField = value;
                    this.RaisePropertyChanged("HasError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConnectedParties.RDService.IDInfo[] IDInfo {
            get {
                return this.IDInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.IDInfoField, value) != true)) {
                    this.IDInfoField = value;
                    this.RaisePropertyChanged("IDInfo");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorInfo", Namespace="http://schemas.datacontract.org/2004/07/RDService")]
    [System.SerializableAttribute()]
    public partial class ErrorInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorAltTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTextField;
        
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
        public string ErrorAltText {
            get {
                return this.ErrorAltTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorAltTextField, value) != true)) {
                    this.ErrorAltTextField = value;
                    this.RaisePropertyChanged("ErrorAltText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorID {
            get {
                return this.ErrorIDField;
            }
            set {
                if ((this.ErrorIDField.Equals(value) != true)) {
                    this.ErrorIDField = value;
                    this.RaisePropertyChanged("ErrorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorReference {
            get {
                return this.ErrorReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorReferenceField, value) != true)) {
                    this.ErrorReferenceField = value;
                    this.RaisePropertyChanged("ErrorReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorText {
            get {
                return this.ErrorTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTextField, value) != true)) {
                    this.ErrorTextField = value;
                    this.RaisePropertyChanged("ErrorText");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IDInfo", Namespace="http://schemas.datacontract.org/2004/07/RDService")]
    [System.SerializableAttribute()]
    public partial class IDInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDValueField;
        
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
        public string IDText {
            get {
                return this.IDTextField;
            }
            set {
                if ((object.ReferenceEquals(this.IDTextField, value) != true)) {
                    this.IDTextField = value;
                    this.RaisePropertyChanged("IDText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDType {
            get {
                return this.IDTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.IDTypeField, value) != true)) {
                    this.IDTypeField = value;
                    this.RaisePropertyChanged("IDType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDValue {
            get {
                return this.IDValueField;
            }
            set {
                if ((this.IDValueField.Equals(value) != true)) {
                    this.IDValueField = value;
                    this.RaisePropertyChanged("IDValue");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QueryParams", Namespace="http://schemas.datacontract.org/2004/07/RD")]
    [System.SerializableAttribute()]
    public partial class QueryParams : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConnectedParties.RDService.Pair[] PARAMSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PARAM_ORDERField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PARAM_SELECTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PARAM_TARGETField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PARAM_WHEREField;
        
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
        public ConnectedParties.RDService.Pair[] PARAMS {
            get {
                return this.PARAMSField;
            }
            set {
                if ((object.ReferenceEquals(this.PARAMSField, value) != true)) {
                    this.PARAMSField = value;
                    this.RaisePropertyChanged("PARAMS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PARAM_ORDER {
            get {
                return this.PARAM_ORDERField;
            }
            set {
                if ((object.ReferenceEquals(this.PARAM_ORDERField, value) != true)) {
                    this.PARAM_ORDERField = value;
                    this.RaisePropertyChanged("PARAM_ORDER");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PARAM_SELECT {
            get {
                return this.PARAM_SELECTField;
            }
            set {
                if ((object.ReferenceEquals(this.PARAM_SELECTField, value) != true)) {
                    this.PARAM_SELECTField = value;
                    this.RaisePropertyChanged("PARAM_SELECT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PARAM_TARGET {
            get {
                return this.PARAM_TARGETField;
            }
            set {
                if ((object.ReferenceEquals(this.PARAM_TARGETField, value) != true)) {
                    this.PARAM_TARGETField = value;
                    this.RaisePropertyChanged("PARAM_TARGET");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PARAM_WHERE {
            get {
                return this.PARAM_WHEREField;
            }
            set {
                if ((object.ReferenceEquals(this.PARAM_WHEREField, value) != true)) {
                    this.PARAM_WHEREField = value;
                    this.RaisePropertyChanged("PARAM_WHERE");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pair", Namespace="http://schemas.datacontract.org/2004/07/RD")]
    [System.SerializableAttribute()]
    public partial class Pair : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VALUEField;
        
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
        public string NAME {
            get {
                return this.NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.NAMEField, value) != true)) {
                    this.NAMEField = value;
                    this.RaisePropertyChanged("NAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VALUE {
            get {
                return this.VALUEField;
            }
            set {
                if ((object.ReferenceEquals(this.VALUEField, value) != true)) {
                    this.VALUEField = value;
                    this.RaisePropertyChanged("VALUE");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditReference", Namespace="http://schemas.datacontract.org/2004/07/RD")]
    [System.SerializableAttribute()]
    public partial class AuditReference : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActionTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuditRefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> BillAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> BillCenterIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillChargeDescrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> BillVATField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConnectedParties.RDService.AuditDocument[] DocumentField;
        
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
        public int ActionType {
            get {
                return this.ActionTypeField;
            }
            set {
                if ((this.ActionTypeField.Equals(value) != true)) {
                    this.ActionTypeField = value;
                    this.RaisePropertyChanged("ActionType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuditRef {
            get {
                return this.AuditRefField;
            }
            set {
                if ((object.ReferenceEquals(this.AuditRefField, value) != true)) {
                    this.AuditRefField = value;
                    this.RaisePropertyChanged("AuditRef");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> BillAmount {
            get {
                return this.BillAmountField;
            }
            set {
                if ((this.BillAmountField.Equals(value) != true)) {
                    this.BillAmountField = value;
                    this.RaisePropertyChanged("BillAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> BillCenterID {
            get {
                return this.BillCenterIDField;
            }
            set {
                if ((this.BillCenterIDField.Equals(value) != true)) {
                    this.BillCenterIDField = value;
                    this.RaisePropertyChanged("BillCenterID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillChargeDescr {
            get {
                return this.BillChargeDescrField;
            }
            set {
                if ((object.ReferenceEquals(this.BillChargeDescrField, value) != true)) {
                    this.BillChargeDescrField = value;
                    this.RaisePropertyChanged("BillChargeDescr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> BillVAT {
            get {
                return this.BillVATField;
            }
            set {
                if ((this.BillVATField.Equals(value) != true)) {
                    this.BillVATField = value;
                    this.RaisePropertyChanged("BillVAT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConnectedParties.RDService.AuditDocument[] Document {
            get {
                return this.DocumentField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentField, value) != true)) {
                    this.DocumentField = value;
                    this.RaisePropertyChanged("Document");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuditDocument", Namespace="http://schemas.datacontract.org/2004/07/RD")]
    [System.SerializableAttribute()]
    public partial class AuditDocument : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DocAttachementFileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocAttachementFilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DocDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocReferenceTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocRemarksField;
        
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
        public byte[] DocAttachementFile {
            get {
                return this.DocAttachementFileField;
            }
            set {
                if ((object.ReferenceEquals(this.DocAttachementFileField, value) != true)) {
                    this.DocAttachementFileField = value;
                    this.RaisePropertyChanged("DocAttachementFile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocAttachementFilename {
            get {
                return this.DocAttachementFilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.DocAttachementFilenameField, value) != true)) {
                    this.DocAttachementFilenameField = value;
                    this.RaisePropertyChanged("DocAttachementFilename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DocDate {
            get {
                return this.DocDateField;
            }
            set {
                if ((this.DocDateField.Equals(value) != true)) {
                    this.DocDateField = value;
                    this.RaisePropertyChanged("DocDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocReference {
            get {
                return this.DocReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.DocReferenceField, value) != true)) {
                    this.DocReferenceField = value;
                    this.RaisePropertyChanged("DocReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocReferenceType {
            get {
                return this.DocReferenceTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DocReferenceTypeField, value) != true)) {
                    this.DocReferenceTypeField = value;
                    this.RaisePropertyChanged("DocReferenceType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocRemarks {
            get {
                return this.DocRemarksField;
            }
            set {
                if ((object.ReferenceEquals(this.DocRemarksField, value) != true)) {
                    this.DocRemarksField = value;
                    this.RaisePropertyChanged("DocRemarks");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="HTTP://WWW.PERCIVAL.CO.UK/ML7", ConfigurationName="RDService.IRDService")]
    public interface IRDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/Version", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/VersionResponse")]
        string Version(int atype);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/GetOperationSchema", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/GetOperationSchemaResponse")]
        string GetOperationSchema(string operationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/WebLogin", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/WebLoginResponse")]
        ConnectedParties.RDService.ReturnInfo WebLogin(out string sessionId, string user, string password, string clientVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/RegardLogin", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/RegardLoginResponse")]
        ConnectedParties.RDService.ReturnInfo RegardLogin(out string sessionId, string user, string password, string clientVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DependLogin", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DependLoginResponse")]
        ConnectedParties.RDService.ReturnInfo DependLogin(out string sessionId, string user, string password, string clientVersion, string participant);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/Logout", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/LogoutResponse")]
        ConnectedParties.RDService.ReturnInfo Logout(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/LoginChangeWorkgroup", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/LoginChangeWorkgroupResponse")]
        ConnectedParties.RDService.ReturnInfo LoginChangeWorkgroup(string sessionId, int workgroupId);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetListZIP", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetListZIPResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetListZIP(out string schema, out byte[] data, string sessionId, string name, int top, string @where);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetList", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetListResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetList(out string schema, out string data, string sessionId, string name, int top, string @where);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetUpdate", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetUpdateResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetUpdate(ref int auditId, string sessionId, string name, int batchId, string data, string auditReference);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetUpdateZIP", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetUpdateZIPResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetUpdateZIP(ref int auditId, string sessionId, string name, int batchId, byte[] data, string auditReference);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetConfirm", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetConfirmResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetConfirm(int auditId, string sessionId, string auditReference);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetReject", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DataSetRejectResponse")]
        ConnectedParties.RDService.ReturnInfo DataSetReject(int auditId, string sessionId, string auditReference);
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/GetOptions", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/GetOptionsResponse")]
        ConnectedParties.RDService.QueryParams[] GetOptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DefineAuditReference", ReplyAction="HTTP://WWW.PERCIVAL.CO.UK/ML7/IRDService/DefineAuditReferenceResponse")]
        ConnectedParties.RDService.AuditReference DefineAuditReference();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IRDServiceChannel : ConnectedParties.RDService.IRDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class RDServiceClient : System.ServiceModel.ClientBase<ConnectedParties.RDService.IRDService>, ConnectedParties.RDService.IRDService {
        
        public RDServiceClient() {
        }
        
        public RDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Version(int atype) {
            return base.Channel.Version(atype);
        }
        
        public string GetOperationSchema(string operationName) {
            return base.Channel.GetOperationSchema(operationName);
        }
        
        public ConnectedParties.RDService.ReturnInfo WebLogin(out string sessionId, string user, string password, string clientVersion) {
            return base.Channel.WebLogin(out sessionId, user, password, clientVersion);
        }
        
        public ConnectedParties.RDService.ReturnInfo RegardLogin(out string sessionId, string user, string password, string clientVersion) {
            return base.Channel.RegardLogin(out sessionId, user, password, clientVersion);
        }
        
        public ConnectedParties.RDService.ReturnInfo DependLogin(out string sessionId, string user, string password, string clientVersion, string participant) {
            return base.Channel.DependLogin(out sessionId, user, password, clientVersion, participant);
        }
        
        public ConnectedParties.RDService.ReturnInfo Logout(string sessionId) {
            return base.Channel.Logout(sessionId);
        }
        
        public ConnectedParties.RDService.ReturnInfo LoginChangeWorkgroup(string sessionId, int workgroupId) {
            return base.Channel.LoginChangeWorkgroup(sessionId, workgroupId);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetListZIP(out string schema, out byte[] data, string sessionId, string name, int top, string @where) {
            return base.Channel.DataSetListZIP(out schema, out data, sessionId, name, top, @where);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetList(out string schema, out string data, string sessionId, string name, int top, string @where) {
            return base.Channel.DataSetList(out schema, out data, sessionId, name, top, @where);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetUpdate(ref int auditId, string sessionId, string name, int batchId, string data, string auditReference) {
            return base.Channel.DataSetUpdate(ref auditId, sessionId, name, batchId, data, auditReference);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetUpdateZIP(ref int auditId, string sessionId, string name, int batchId, byte[] data, string auditReference) {
            return base.Channel.DataSetUpdateZIP(ref auditId, sessionId, name, batchId, data, auditReference);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetConfirm(int auditId, string sessionId, string auditReference) {
            return base.Channel.DataSetConfirm(auditId, sessionId, auditReference);
        }
        
        public ConnectedParties.RDService.ReturnInfo DataSetReject(int auditId, string sessionId, string auditReference) {
            return base.Channel.DataSetReject(auditId, sessionId, auditReference);
        }
        
        public ConnectedParties.RDService.QueryParams[] GetOptions() {
            return base.Channel.GetOptions();
        }
        
        public ConnectedParties.RDService.AuditReference DefineAuditReference() {
            return base.Channel.DefineAuditReference();
        }
    }
}
