﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IQoniacTestTaskService")]
public interface IQoniacTestTaskService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQoniacTestTaskService/ParsePrice", ReplyAction="http://tempuri.org/IQoniacTestTaskService/ParsePriceResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IQoniacTestTaskService/ParsePriceStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    string ParsePrice(string price);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQoniacTestTaskService/ParsePrice", ReplyAction="http://tempuri.org/IQoniacTestTaskService/ParsePriceResponse")]
    System.Threading.Tasks.Task<string> ParsePriceAsync(string price);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IQoniacTestTaskServiceChannel : IQoniacTestTaskService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class QoniacTestTaskServiceClient : System.ServiceModel.ClientBase<IQoniacTestTaskService>, IQoniacTestTaskService
{
    
    public QoniacTestTaskServiceClient()
    {
    }
    
    public QoniacTestTaskServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public QoniacTestTaskServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public QoniacTestTaskServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public QoniacTestTaskServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string ParsePrice(string price)
    {
        return base.Channel.ParsePrice(price);
    }
    
    public System.Threading.Tasks.Task<string> ParsePriceAsync(string price)
    {
        return base.Channel.ParsePriceAsync(price);
    }
}
