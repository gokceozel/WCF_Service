﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfBasicProject.KategoriServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryDTO", Namespace="http://schemas.datacontract.org/2004/07/WCF_Service.Dto.DtoModels")]
    [System.SerializableAttribute()]
    public partial class CategoryDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
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
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KategoriServiceReference.IServiceRepositoryOf_CategoryDTO")]
    public interface IServiceRepositoryOf_CategoryDTO {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/GetList", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/GetListResponse")]
        System.Collections.Generic.List<WcfBasicProject.KategoriServiceReference.CategoryDTO> GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/GetList", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WcfBasicProject.KategoriServiceReference.CategoryDTO>> GetListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Add", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/AddResponse")]
        bool Add(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Add", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Update", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/UpdateResponse")]
        bool Update(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Update", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Delete", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/DeleteResponse")]
        bool Delete(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/Delete", ReplyAction="http://tempuri.org/IServiceRepositoryOf_CategoryDTO/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceRepositoryOf_CategoryDTOChannel : WcfBasicProject.KategoriServiceReference.IServiceRepositoryOf_CategoryDTO, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceRepositoryOf_CategoryDTOClient : System.ServiceModel.ClientBase<WcfBasicProject.KategoriServiceReference.IServiceRepositoryOf_CategoryDTO>, WcfBasicProject.KategoriServiceReference.IServiceRepositoryOf_CategoryDTO {
        
        public ServiceRepositoryOf_CategoryDTOClient() {
        }
        
        public ServiceRepositoryOf_CategoryDTOClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceRepositoryOf_CategoryDTOClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepositoryOf_CategoryDTOClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepositoryOf_CategoryDTOClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WcfBasicProject.KategoriServiceReference.CategoryDTO> GetList() {
            return base.Channel.GetList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WcfBasicProject.KategoriServiceReference.CategoryDTO>> GetListAsync() {
            return base.Channel.GetListAsync();
        }
        
        public bool Add(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.Add(entity);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.AddAsync(entity);
        }
        
        public bool Update(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.UpdateAsync(entity);
        }
        
        public bool Delete(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.Delete(entity);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(WcfBasicProject.KategoriServiceReference.CategoryDTO entity) {
            return base.Channel.DeleteAsync(entity);
        }
    }
}
