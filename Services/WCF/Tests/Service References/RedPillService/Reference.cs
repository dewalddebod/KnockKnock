﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Readify.Services.WCF.Tests.RedPillService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://KnockKnock.readify.net", ConfigurationName="RedPillService.IRedPill")]
    public interface IRedPill {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Threading.Tasks.Task<System.Guid> WhatIsYourTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException), Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
            "Fault", Name="ArgumentOutOfRangeException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/FibonacciNumber", ReplyAction="http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        Readify.Services.Contracts.Data.TriangleType WhatShapeIsThis(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        System.Threading.Tasks.Task<Readify.Services.Contracts.Data.TriangleType> WhatShapeIsThisAsync(int a, int b, int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/ReverseWords", ReplyAction="http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        System.Threading.Tasks.Task<string> ReverseWordsAsync(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRedPillChannel : Readify.Services.WCF.Tests.RedPillService.IRedPill, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RedPillClient : System.ServiceModel.ClientBase<Readify.Services.WCF.Tests.RedPillService.IRedPill>, Readify.Services.WCF.Tests.RedPillService.IRedPill {
        
        public RedPillClient() {
        }
        
        public RedPillClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RedPillClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid WhatIsYourToken() {
            return base.Channel.WhatIsYourToken();
        }
        
        public System.Threading.Tasks.Task<System.Guid> WhatIsYourTokenAsync() {
            return base.Channel.WhatIsYourTokenAsync();
        }
        
        public long FibonacciNumber(long n) {
            return base.Channel.FibonacciNumber(n);
        }
        
        public System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n) {
            return base.Channel.FibonacciNumberAsync(n);
        }
        
        public Readify.Services.Contracts.Data.TriangleType WhatShapeIsThis(int a, int b, int c) {
            return base.Channel.WhatShapeIsThis(a, b, c);
        }
        
        public System.Threading.Tasks.Task<Readify.Services.Contracts.Data.TriangleType> WhatShapeIsThisAsync(int a, int b, int c) {
            return base.Channel.WhatShapeIsThisAsync(a, b, c);
        }
        
        public string ReverseWords(string s) {
            return base.Channel.ReverseWords(s);
        }
        
        public System.Threading.Tasks.Task<string> ReverseWordsAsync(string s) {
            return base.Channel.ReverseWordsAsync(s);
        }
    }
}