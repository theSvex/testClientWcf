﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testClientWcf.GenLibService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Population", Namespace="http://schemas.datacontract.org/2004/07/GAF")]
    [System.SerializableAttribute()]
    public partial class Population : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FittestValue", Namespace="http://schemas.datacontract.org/2004/07/wcfGenLib")]
    [System.SerializableAttribute()]
    public partial class FittestValue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double FitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
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
        public double Fit {
            get {
                return this.FitField;
            }
            set {
                if ((this.FitField.Equals(value) != true)) {
                    this.FitField = value;
                    this.RaisePropertyChanged("Fit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/wcfGenLib")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GenLibService.IGenLib")]
    public interface IGenLib {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/TerminateAlgorithm", ReplyAction="http://tempuri.org/IGenLib/TerminateAlgorithmResponse")]
        bool TerminateAlgorithm(testClientWcf.GenLibService.Population population, int currentGeneration, long currentEvaluation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/TerminateAlgorithm", ReplyAction="http://tempuri.org/IGenLib/TerminateAlgorithmResponse")]
        System.Threading.Tasks.Task<bool> TerminateAlgorithmAsync(testClientWcf.GenLibService.Population population, int currentGeneration, long currentEvaluation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/EvaluateFitness", ReplyAction="http://tempuri.org/IGenLib/EvaluateFitnessResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(testClientWcf.GenLibService.Population))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(testClientWcf.GenLibService.FittestValue))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(testClientWcf.GenLibService.CompositeType))]
        double EvaluateFitness(object[] chrom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/EvaluateFitness", ReplyAction="http://tempuri.org/IGenLib/EvaluateFitnessResponse")]
        System.Threading.Tasks.Task<double> EvaluateFitnessAsync(object[] chrom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/Start", ReplyAction="http://tempuri.org/IGenLib/StartResponse")]
        testClientWcf.GenLibService.FittestValue Start(double crossoverProb, double mutationProb, int elitismPerc, int perPopulation, int populationCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/Start", ReplyAction="http://tempuri.org/IGenLib/StartResponse")]
        System.Threading.Tasks.Task<testClientWcf.GenLibService.FittestValue> StartAsync(double crossoverProb, double mutationProb, int elitismPerc, int perPopulation, int populationCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IGenLib/GetDataUsingDataContractResponse")]
        testClientWcf.GenLibService.CompositeType GetDataUsingDataContract(testClientWcf.GenLibService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenLib/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IGenLib/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<testClientWcf.GenLibService.CompositeType> GetDataUsingDataContractAsync(testClientWcf.GenLibService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGenLibChannel : testClientWcf.GenLibService.IGenLib, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GenLibClient : System.ServiceModel.ClientBase<testClientWcf.GenLibService.IGenLib>, testClientWcf.GenLibService.IGenLib {
        
        public GenLibClient() {
        }
        
        public GenLibClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GenLibClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenLibClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenLibClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool TerminateAlgorithm(testClientWcf.GenLibService.Population population, int currentGeneration, long currentEvaluation) {
            return base.Channel.TerminateAlgorithm(population, currentGeneration, currentEvaluation);
        }
        
        public System.Threading.Tasks.Task<bool> TerminateAlgorithmAsync(testClientWcf.GenLibService.Population population, int currentGeneration, long currentEvaluation) {
            return base.Channel.TerminateAlgorithmAsync(population, currentGeneration, currentEvaluation);
        }
        
        public double EvaluateFitness(object[] chrom) {
            return base.Channel.EvaluateFitness(chrom);
        }
        
        public System.Threading.Tasks.Task<double> EvaluateFitnessAsync(object[] chrom) {
            return base.Channel.EvaluateFitnessAsync(chrom);
        }
        
        public testClientWcf.GenLibService.FittestValue Start(double crossoverProb, double mutationProb, int elitismPerc, int perPopulation, int populationCount) {
            return base.Channel.Start(crossoverProb, mutationProb, elitismPerc, perPopulation, populationCount);
        }
        
        public System.Threading.Tasks.Task<testClientWcf.GenLibService.FittestValue> StartAsync(double crossoverProb, double mutationProb, int elitismPerc, int perPopulation, int populationCount) {
            return base.Channel.StartAsync(crossoverProb, mutationProb, elitismPerc, perPopulation, populationCount);
        }
        
        public testClientWcf.GenLibService.CompositeType GetDataUsingDataContract(testClientWcf.GenLibService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<testClientWcf.GenLibService.CompositeType> GetDataUsingDataContractAsync(testClientWcf.GenLibService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
