﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampaignMailIdParser
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WebserviceException", Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class WebserviceException : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private object causeField;
        
        private string messageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public object cause
        {
            get
            {
                return this.causeField;
            }
            set
            {
                this.causeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId", ConfigurationName="CampaignMailIdParser.MailIdWebservice")]
    public interface MailIdWebservice
    {
        
        // CODEGEN: Generating message contract since element name in0 from namespace urn:api.broadmail.de/soap11/MailId is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CampaignMailIdParser.WebserviceException), Action="", Name="fault")]
        CampaignMailIdParser.getRecipientListIdResponse getRecipientListId(CampaignMailIdParser.getRecipientListIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientListIdResponse> getRecipientListIdAsync(CampaignMailIdParser.getRecipientListIdRequest request);
        
        // CODEGEN: Generating message contract since element name in0 from namespace urn:api.broadmail.de/soap11/MailId is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CampaignMailIdParser.WebserviceException), Action="", Name="fault")]
        CampaignMailIdParser.getRecipientIdResponse getRecipientId(CampaignMailIdParser.getRecipientIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientIdResponse> getRecipientIdAsync(CampaignMailIdParser.getRecipientIdRequest request);
        
        // CODEGEN: Generating message contract since element name in0 from namespace urn:api.broadmail.de/soap11/MailId is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CampaignMailIdParser.WebserviceException), Action="", Name="fault")]
        CampaignMailIdParser.getMailingIdResponse getMailingId(CampaignMailIdParser.getMailingIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CampaignMailIdParser.getMailingIdResponse> getMailingIdAsync(CampaignMailIdParser.getMailingIdRequest request);
        
        // CODEGEN: Generating message contract since element name in0 from namespace urn:api.broadmail.de/soap11/MailId is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CampaignMailIdParser.WebserviceException), Action="", Name="fault")]
        CampaignMailIdParser.getMandatorIdResponse getMandatorId(CampaignMailIdParser.getMandatorIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CampaignMailIdParser.getMandatorIdResponse> getMandatorIdAsync(CampaignMailIdParser.getMandatorIdRequest request);
        
        // CODEGEN: Generating message contract since element name getVersionReturn from namespace urn:api.broadmail.de/soap11/MailId is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CampaignMailIdParser.WebserviceException), Action="", Name="fault")]
        CampaignMailIdParser.getVersionResponse getVersion(CampaignMailIdParser.getVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CampaignMailIdParser.getVersionResponse> getVersionAsync(CampaignMailIdParser.getVersionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRecipientListIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRecipientListId", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getRecipientListIdRequestBody Body;
        
        public getRecipientListIdRequest()
        {
        }
        
        public getRecipientListIdRequest(CampaignMailIdParser.getRecipientListIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getRecipientListIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string in1;
        
        public getRecipientListIdRequestBody()
        {
        }
        
        public getRecipientListIdRequestBody(string in0, string in1)
        {
            this.in0 = in0;
            this.in1 = in1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRecipientListIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRecipientListIdResponse", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getRecipientListIdResponseBody Body;
        
        public getRecipientListIdResponse()
        {
        }
        
        public getRecipientListIdResponse(CampaignMailIdParser.getRecipientListIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getRecipientListIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long getRecipientListIdReturn;
        
        public getRecipientListIdResponseBody()
        {
        }
        
        public getRecipientListIdResponseBody(long getRecipientListIdReturn)
        {
            this.getRecipientListIdReturn = getRecipientListIdReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRecipientIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRecipientId", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getRecipientIdRequestBody Body;
        
        public getRecipientIdRequest()
        {
        }
        
        public getRecipientIdRequest(CampaignMailIdParser.getRecipientIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getRecipientIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string in1;
        
        public getRecipientIdRequestBody()
        {
        }
        
        public getRecipientIdRequestBody(string in0, string in1)
        {
            this.in0 = in0;
            this.in1 = in1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getRecipientIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getRecipientIdResponse", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getRecipientIdResponseBody Body;
        
        public getRecipientIdResponse()
        {
        }
        
        public getRecipientIdResponse(CampaignMailIdParser.getRecipientIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getRecipientIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getRecipientIdReturn;
        
        public getRecipientIdResponseBody()
        {
        }
        
        public getRecipientIdResponseBody(string getRecipientIdReturn)
        {
            this.getRecipientIdReturn = getRecipientIdReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMailingIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMailingId", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getMailingIdRequestBody Body;
        
        public getMailingIdRequest()
        {
        }
        
        public getMailingIdRequest(CampaignMailIdParser.getMailingIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getMailingIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string in1;
        
        public getMailingIdRequestBody()
        {
        }
        
        public getMailingIdRequestBody(string in0, string in1)
        {
            this.in0 = in0;
            this.in1 = in1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMailingIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMailingIdResponse", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getMailingIdResponseBody Body;
        
        public getMailingIdResponse()
        {
        }
        
        public getMailingIdResponse(CampaignMailIdParser.getMailingIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getMailingIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long getMailingIdReturn;
        
        public getMailingIdResponseBody()
        {
        }
        
        public getMailingIdResponseBody(long getMailingIdReturn)
        {
            this.getMailingIdReturn = getMailingIdReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMandatorIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMandatorId", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getMandatorIdRequestBody Body;
        
        public getMandatorIdRequest()
        {
        }
        
        public getMandatorIdRequest(CampaignMailIdParser.getMandatorIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getMandatorIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string in0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string in1;
        
        public getMandatorIdRequestBody()
        {
        }
        
        public getMandatorIdRequestBody(string in0, string in1)
        {
            this.in0 = in0;
            this.in1 = in1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getMandatorIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getMandatorIdResponse", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getMandatorIdResponseBody Body;
        
        public getMandatorIdResponse()
        {
        }
        
        public getMandatorIdResponse(CampaignMailIdParser.getMandatorIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getMandatorIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long getMandatorIdReturn;
        
        public getMandatorIdResponseBody()
        {
        }
        
        public getMandatorIdResponseBody(long getMandatorIdReturn)
        {
            this.getMandatorIdReturn = getMandatorIdReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getVersion", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getVersionRequestBody Body;
        
        public getVersionRequest()
        {
        }
        
        public getVersionRequest(CampaignMailIdParser.getVersionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getVersionRequestBody
    {
        
        public getVersionRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getVersionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getVersionResponse", Namespace="urn:api.broadmail.de/soap11/MailId", Order=0)]
        public CampaignMailIdParser.getVersionResponseBody Body;
        
        public getVersionResponse()
        {
        }
        
        public getVersionResponse(CampaignMailIdParser.getVersionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:api.broadmail.de/soap11/MailId")]
    public partial class getVersionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getVersionReturn;
        
        public getVersionResponseBody()
        {
        }
        
        public getVersionResponseBody(string getVersionReturn)
        {
            this.getVersionReturn = getVersionReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MailIdWebserviceChannel : CampaignMailIdParser.MailIdWebservice, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailIdWebserviceClient : System.ServiceModel.ClientBase<CampaignMailIdParser.MailIdWebservice>, CampaignMailIdParser.MailIdWebservice
    {
        
        public MailIdWebserviceClient()
        {
        }
        
        public MailIdWebserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public MailIdWebserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MailIdWebserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public MailIdWebserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CampaignMailIdParser.getRecipientListIdResponse CampaignMailIdParser.MailIdWebservice.getRecipientListId(CampaignMailIdParser.getRecipientListIdRequest request)
        {
            return base.Channel.getRecipientListId(request);
        }
        
        public long getRecipientListId(string in0, string in1)
        {
            CampaignMailIdParser.getRecipientListIdRequest inValue = new CampaignMailIdParser.getRecipientListIdRequest();
            inValue.Body = new CampaignMailIdParser.getRecipientListIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            CampaignMailIdParser.getRecipientListIdResponse retVal = ((CampaignMailIdParser.MailIdWebservice)(this)).getRecipientListId(inValue);
            return retVal.Body.getRecipientListIdReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientListIdResponse> CampaignMailIdParser.MailIdWebservice.getRecipientListIdAsync(CampaignMailIdParser.getRecipientListIdRequest request)
        {
            return base.Channel.getRecipientListIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientListIdResponse> getRecipientListIdAsync(string in0, string in1)
        {
            CampaignMailIdParser.getRecipientListIdRequest inValue = new CampaignMailIdParser.getRecipientListIdRequest();
            inValue.Body = new CampaignMailIdParser.getRecipientListIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            return ((CampaignMailIdParser.MailIdWebservice)(this)).getRecipientListIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CampaignMailIdParser.getRecipientIdResponse CampaignMailIdParser.MailIdWebservice.getRecipientId(CampaignMailIdParser.getRecipientIdRequest request)
        {
            return base.Channel.getRecipientId(request);
        }
        
        public string getRecipientId(string in0, string in1)
        {
            CampaignMailIdParser.getRecipientIdRequest inValue = new CampaignMailIdParser.getRecipientIdRequest();
            inValue.Body = new CampaignMailIdParser.getRecipientIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            CampaignMailIdParser.getRecipientIdResponse retVal = ((CampaignMailIdParser.MailIdWebservice)(this)).getRecipientId(inValue);
            return retVal.Body.getRecipientIdReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientIdResponse> CampaignMailIdParser.MailIdWebservice.getRecipientIdAsync(CampaignMailIdParser.getRecipientIdRequest request)
        {
            return base.Channel.getRecipientIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CampaignMailIdParser.getRecipientIdResponse> getRecipientIdAsync(string in0, string in1)
        {
            CampaignMailIdParser.getRecipientIdRequest inValue = new CampaignMailIdParser.getRecipientIdRequest();
            inValue.Body = new CampaignMailIdParser.getRecipientIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            return ((CampaignMailIdParser.MailIdWebservice)(this)).getRecipientIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CampaignMailIdParser.getMailingIdResponse CampaignMailIdParser.MailIdWebservice.getMailingId(CampaignMailIdParser.getMailingIdRequest request)
        {
            return base.Channel.getMailingId(request);
        }
        
        public long getMailingId(string in0, string in1)
        {
            CampaignMailIdParser.getMailingIdRequest inValue = new CampaignMailIdParser.getMailingIdRequest();
            inValue.Body = new CampaignMailIdParser.getMailingIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            CampaignMailIdParser.getMailingIdResponse retVal = ((CampaignMailIdParser.MailIdWebservice)(this)).getMailingId(inValue);
            return retVal.Body.getMailingIdReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CampaignMailIdParser.getMailingIdResponse> CampaignMailIdParser.MailIdWebservice.getMailingIdAsync(CampaignMailIdParser.getMailingIdRequest request)
        {
            return base.Channel.getMailingIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CampaignMailIdParser.getMailingIdResponse> getMailingIdAsync(string in0, string in1)
        {
            CampaignMailIdParser.getMailingIdRequest inValue = new CampaignMailIdParser.getMailingIdRequest();
            inValue.Body = new CampaignMailIdParser.getMailingIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            return ((CampaignMailIdParser.MailIdWebservice)(this)).getMailingIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CampaignMailIdParser.getMandatorIdResponse CampaignMailIdParser.MailIdWebservice.getMandatorId(CampaignMailIdParser.getMandatorIdRequest request)
        {
            return base.Channel.getMandatorId(request);
        }
        
        public long getMandatorId(string in0, string in1)
        {
            CampaignMailIdParser.getMandatorIdRequest inValue = new CampaignMailIdParser.getMandatorIdRequest();
            inValue.Body = new CampaignMailIdParser.getMandatorIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            CampaignMailIdParser.getMandatorIdResponse retVal = ((CampaignMailIdParser.MailIdWebservice)(this)).getMandatorId(inValue);
            return retVal.Body.getMandatorIdReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CampaignMailIdParser.getMandatorIdResponse> CampaignMailIdParser.MailIdWebservice.getMandatorIdAsync(CampaignMailIdParser.getMandatorIdRequest request)
        {
            return base.Channel.getMandatorIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CampaignMailIdParser.getMandatorIdResponse> getMandatorIdAsync(string in0, string in1)
        {
            CampaignMailIdParser.getMandatorIdRequest inValue = new CampaignMailIdParser.getMandatorIdRequest();
            inValue.Body = new CampaignMailIdParser.getMandatorIdRequestBody();
            inValue.Body.in0 = in0;
            inValue.Body.in1 = in1;
            return ((CampaignMailIdParser.MailIdWebservice)(this)).getMandatorIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CampaignMailIdParser.getVersionResponse CampaignMailIdParser.MailIdWebservice.getVersion(CampaignMailIdParser.getVersionRequest request)
        {
            return base.Channel.getVersion(request);
        }
        
        public string getVersion()
        {
            CampaignMailIdParser.getVersionRequest inValue = new CampaignMailIdParser.getVersionRequest();
            inValue.Body = new CampaignMailIdParser.getVersionRequestBody();
            CampaignMailIdParser.getVersionResponse retVal = ((CampaignMailIdParser.MailIdWebservice)(this)).getVersion(inValue);
            return retVal.Body.getVersionReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CampaignMailIdParser.getVersionResponse> CampaignMailIdParser.MailIdWebservice.getVersionAsync(CampaignMailIdParser.getVersionRequest request)
        {
            return base.Channel.getVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<CampaignMailIdParser.getVersionResponse> getVersionAsync()
        {
            CampaignMailIdParser.getVersionRequest inValue = new CampaignMailIdParser.getVersionRequest();
            inValue.Body = new CampaignMailIdParser.getVersionRequestBody();
            return ((CampaignMailIdParser.MailIdWebservice)(this)).getVersionAsync(inValue);
        }
    }
}