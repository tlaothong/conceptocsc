﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationWeb.RegistrationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Register", Namespace="http://schemas.datacontract.org/2004/07/TheS.eXam.Web.Models")]
    [System.SerializableAttribute()]
    public partial class Register : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AppointDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ApprovedDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExamNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpireDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ForPracticeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> ForTestSystemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsListenQuizField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LicenseTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuizLanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SchoolIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationIdField, value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AppointDateTime {
            get {
                return this.AppointDateTimeField;
            }
            set {
                if ((this.AppointDateTimeField.Equals(value) != true)) {
                    this.AppointDateTimeField = value;
                    this.RaisePropertyChanged("AppointDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ApprovedDateTime {
            get {
                return this.ApprovedDateTimeField;
            }
            set {
                if ((this.ApprovedDateTimeField.Equals(value) != true)) {
                    this.ApprovedDateTimeField = value;
                    this.RaisePropertyChanged("ApprovedDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseType {
            get {
                return this.CourseTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseTypeField, value) != true)) {
                    this.CourseTypeField = value;
                    this.RaisePropertyChanged("CourseType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExamNumber {
            get {
                return this.ExamNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ExamNumberField, value) != true)) {
                    this.ExamNumberField = value;
                    this.RaisePropertyChanged("ExamNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ExpireDateTime {
            get {
                return this.ExpireDateTimeField;
            }
            set {
                if ((this.ExpireDateTimeField.Equals(value) != true)) {
                    this.ExpireDateTimeField = value;
                    this.RaisePropertyChanged("ExpireDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ForPractice {
            get {
                return this.ForPracticeField;
            }
            set {
                if ((this.ForPracticeField.Equals(value) != true)) {
                    this.ForPracticeField = value;
                    this.RaisePropertyChanged("ForPractice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> ForTestSystem {
            get {
                return this.ForTestSystemField;
            }
            set {
                if ((this.ForTestSystemField.Equals(value) != true)) {
                    this.ForTestSystemField = value;
                    this.RaisePropertyChanged("ForTestSystem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsListenQuiz {
            get {
                return this.IsListenQuizField;
            }
            set {
                if ((this.IsListenQuizField.Equals(value) != true)) {
                    this.IsListenQuizField = value;
                    this.RaisePropertyChanged("IsListenQuiz");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LicenseType {
            get {
                return this.LicenseTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.LicenseTypeField, value) != true)) {
                    this.LicenseTypeField = value;
                    this.RaisePropertyChanged("LicenseType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PID {
            get {
                return this.PIDField;
            }
            set {
                if ((object.ReferenceEquals(this.PIDField, value) != true)) {
                    this.PIDField = value;
                    this.RaisePropertyChanged("PID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuizLanguage {
            get {
                return this.QuizLanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.QuizLanguageField, value) != true)) {
                    this.QuizLanguageField = value;
                    this.RaisePropertyChanged("QuizLanguage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SchoolId {
            get {
                return this.SchoolIdField;
            }
            set {
                if ((this.SchoolIdField.Equals(value) != true)) {
                    this.SchoolIdField = value;
                    this.RaisePropertyChanged("SchoolId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RegistrationService.IRegistrationService")]
    public interface IRegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RegisterNewPerson", ReplyAction="http://tempuri.org/IRegistrationService/RegisterNewPersonResponse")]
        void RegisterNewPerson(RegistrationWeb.RegistrationService.Register[] registers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationService/RegisterNewPerson", ReplyAction="http://tempuri.org/IRegistrationService/RegisterNewPersonResponse")]
        System.Threading.Tasks.Task RegisterNewPersonAsync(RegistrationWeb.RegistrationService.Register[] registers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistrationServiceChannel : RegistrationWeb.RegistrationService.IRegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrationServiceClient : System.ServiceModel.ClientBase<RegistrationWeb.RegistrationService.IRegistrationService>, RegistrationWeb.RegistrationService.IRegistrationService {
        
        public RegistrationServiceClient() {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterNewPerson(RegistrationWeb.RegistrationService.Register[] registers) {
            base.Channel.RegisterNewPerson(registers);
        }
        
        public System.Threading.Tasks.Task RegisterNewPersonAsync(RegistrationWeb.RegistrationService.Register[] registers) {
            return base.Channel.RegisterNewPersonAsync(registers);
        }
    }
}