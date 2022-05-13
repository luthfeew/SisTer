﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWcf_1198.wcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfService.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/tambah", ReplyAction="http://tempuri.org/ICalculator/tambahResponse")]
        int tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/tambah", ReplyAction="http://tempuri.org/ICalculator/tambahResponse")]
        System.Threading.Tasks.Task<int> tambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/bagi", ReplyAction="http://tempuri.org/ICalculator/bagiResponse")]
        double bagi(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/bagi", ReplyAction="http://tempuri.org/ICalculator/bagiResponse")]
        System.Threading.Tasks.Task<double> bagiAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/kali", ReplyAction="http://tempuri.org/ICalculator/kaliResponse")]
        int kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/kali", ReplyAction="http://tempuri.org/ICalculator/kaliResponse")]
        System.Threading.Tasks.Task<int> kaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/kurang", ReplyAction="http://tempuri.org/ICalculator/kurangResponse")]
        int kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/kurang", ReplyAction="http://tempuri.org/ICalculator/kurangResponse")]
        System.Threading.Tasks.Task<int> kurangAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ClientWcf_1198.wcfService.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<ClientWcf_1198.wcfService.ICalculator>, ClientWcf_1198.wcfService.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int tambah(int a, int b) {
            return base.Channel.tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> tambahAsync(int a, int b) {
            return base.Channel.tambahAsync(a, b);
        }
        
        public double bagi(double a, double b) {
            return base.Channel.bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<double> bagiAsync(double a, double b) {
            return base.Channel.bagiAsync(a, b);
        }
        
        public int kali(int a, int b) {
            return base.Channel.kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> kaliAsync(int a, int b) {
            return base.Channel.kaliAsync(a, b);
        }
        
        public int kurang(int a, int b) {
            return base.Channel.kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> kurangAsync(int a, int b) {
            return base.Channel.kurangAsync(a, b);
        }
    }
}
