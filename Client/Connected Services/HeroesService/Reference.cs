﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.HeroesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Work", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial class Work : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WorthField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Worth {
            get {
                return this.WorthField;
            }
            set {
                if ((this.WorthField.Equals(value) != true)) {
                    this.WorthField = value;
                    this.RaisePropertyChanged("Worth");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Hero", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial class Hero : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string arenaField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string arena {
            get {
                return this.arenaField;
            }
            set {
                if ((object.ReferenceEquals(this.arenaField, value) != true)) {
                    this.arenaField = value;
                    this.RaisePropertyChanged("arena");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HeroesService.IHeroesService")]
    public interface IHeroesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHeroesService/GetHeroSchool", ReplyAction="http://tempuri.org/IHeroesService/GetHeroSchoolResponse")]
        string GetHeroSchool(string arena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHeroesService/GetHeroSchool", ReplyAction="http://tempuri.org/IHeroesService/GetHeroSchoolResponse")]
        System.Threading.Tasks.Task<string> GetHeroSchoolAsync(string arena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHeroesService/GetHero", ReplyAction="http://tempuri.org/IHeroesService/GetHeroResponse")]
        Client.HeroesService.Hero GetHero(Client.HeroesService.Work work);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHeroesService/GetHero", ReplyAction="http://tempuri.org/IHeroesService/GetHeroResponse")]
        System.Threading.Tasks.Task<Client.HeroesService.Hero> GetHeroAsync(Client.HeroesService.Work work);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHeroesServiceChannel : Client.HeroesService.IHeroesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HeroesServiceClient : System.ServiceModel.ClientBase<Client.HeroesService.IHeroesService>, Client.HeroesService.IHeroesService {
        
        public HeroesServiceClient() {
        }
        
        public HeroesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HeroesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HeroesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HeroesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHeroSchool(string arena) {
            return base.Channel.GetHeroSchool(arena);
        }
        
        public System.Threading.Tasks.Task<string> GetHeroSchoolAsync(string arena) {
            return base.Channel.GetHeroSchoolAsync(arena);
        }
        
        public Client.HeroesService.Hero GetHero(Client.HeroesService.Work work) {
            return base.Channel.GetHero(work);
        }
        
        public System.Threading.Tasks.Task<Client.HeroesService.Hero> GetHeroAsync(Client.HeroesService.Work work) {
            return base.Channel.GetHeroAsync(work);
        }
    }
}
