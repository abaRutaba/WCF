﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grid_View_Example.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="testlistmodel.displayname", Namespace="http://schemas.datacontract.org/2004/07/Business_Logics.Model")]
    [System.SerializableAttribute()]
    public partial class testlistmodeldisplayname : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string my_countryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public System.DateTime Created {
            get {
                return this.CreatedField;
            }
            set {
                if ((this.CreatedField.Equals(value) != true)) {
                    this.CreatedField = value;
                    this.RaisePropertyChanged("Created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string my_country {
            get {
                return this.my_countryField;
            }
            set {
                if ((object.ReferenceEquals(this.my_countryField, value) != true)) {
                    this.my_countryField = value;
                    this.RaisePropertyChanged("my_country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICRUD_SP")]
    public interface ICRUD_SP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/DoWork", ReplyAction="http://tempuri.org/ICRUD_SP/DoWorkResponse")]
        Grid_View_Example.ServiceReference1.testlistmodeldisplayname[] DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/DoWork", ReplyAction="http://tempuri.org/ICRUD_SP/DoWorkResponse")]
        System.Threading.Tasks.Task<Grid_View_Example.ServiceReference1.testlistmodeldisplayname[]> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Insert", ReplyAction="http://tempuri.org/ICRUD_SP/InsertResponse")]
        bool Insert(string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Insert", ReplyAction="http://tempuri.org/ICRUD_SP/InsertResponse")]
        System.Threading.Tasks.Task<bool> InsertAsync(string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Update", ReplyAction="http://tempuri.org/ICRUD_SP/UpdateResponse")]
        bool Update(int id, string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Update", ReplyAction="http://tempuri.org/ICRUD_SP/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(int id, string name, string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Delete", ReplyAction="http://tempuri.org/ICRUD_SP/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUD_SP/Delete", ReplyAction="http://tempuri.org/ICRUD_SP/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRUD_SPChannel : Grid_View_Example.ServiceReference1.ICRUD_SP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRUD_SPClient : System.ServiceModel.ClientBase<Grid_View_Example.ServiceReference1.ICRUD_SP>, Grid_View_Example.ServiceReference1.ICRUD_SP {
        
        public CRUD_SPClient() {
        }
        
        public CRUD_SPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRUD_SPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUD_SPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUD_SPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Grid_View_Example.ServiceReference1.testlistmodeldisplayname[] DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<Grid_View_Example.ServiceReference1.testlistmodeldisplayname[]> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public bool Insert(string name, string country) {
            return base.Channel.Insert(name, country);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAsync(string name, string country) {
            return base.Channel.InsertAsync(name, country);
        }
        
        public bool Update(int id, string name, string country) {
            return base.Channel.Update(id, name, country);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(int id, string name, string country) {
            return base.Channel.UpdateAsync(id, name, country);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
