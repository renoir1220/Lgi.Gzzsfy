﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 
namespace Langjia.Service
{
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Web.Services.WebServiceAttribute(Namespace = "http://www.gzsums.net/crisisValue/")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "CrisisValueSoap", Namespace = "http://www.gzsums.net/crisisValue/")]
    public abstract partial class CrisisValue : System.Web.Services.WebService
    {

        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/crisisValue/CrisisAdd", RequestNamespace = "http://www.gzsums.net/crisisValue/", ResponseNamespace = "http://www.gzsums.net/crisisValue/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public abstract Response CrisisAdd(Request req);

        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/crisisValue/CrisisUpdate", RequestNamespace = "http://www.gzsums.net/crisisValue/", ResponseNamespace = "http://www.gzsums.net/crisisValue/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public abstract Response CrisisUpdate(Request req);

        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net/crisisValue/CrisisStatusFeedback", RequestNamespace = "http://www.gzsums.net/crisisValue/", ResponseNamespace = "http://www.gzsums.net/crisisValue/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public abstract Response CrisisStatusFeedback(Request req);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gzsums.net/crisisValue/")]
    public partial class Request
    {

        private RequestHeader requestHeaderField;

        private string requestBodyField;

        /// <remarks/>
        public RequestHeader requestHeader
        {
            get
            {
                return this.requestHeaderField;
            }
            set
            {
                this.requestHeaderField = value;
            }
        }

        /// <remarks/>
        public string requestBody
        {
            get
            {
                return this.requestBodyField;
            }
            set
            {
                this.requestBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gzsums.net/crisisValue/")]
    public partial class RequestHeader
    {

        private string senderField;

        private string receiverField;

        private string requestTimeField;

        private string msgTypeField;

        private string msgIdField;

        private string msgPriorityField;

        private string msgVersionField;

        /// <remarks/>
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public string receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }

        /// <remarks/>
        public string requestTime
        {
            get
            {
                return this.requestTimeField;
            }
            set
            {
                this.requestTimeField = value;
            }
        }

        /// <remarks/>
        public string msgType
        {
            get
            {
                return this.msgTypeField;
            }
            set
            {
                this.msgTypeField = value;
            }
        }

        /// <remarks/>
        public string msgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

        /// <remarks/>
        public string msgPriority
        {
            get
            {
                return this.msgPriorityField;
            }
            set
            {
                this.msgPriorityField = value;
            }
        }

        /// <remarks/>
        public string msgVersion
        {
            get
            {
                return this.msgVersionField;
            }
            set
            {
                this.msgVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gzsums.net/crisisValue/")]
    public partial class ResponseHeader
    {

        private string senderField;

        private string receiverField;

        private string requestTimeField;

        private string msgTypeField;

        private string msgIdField;

        private string msgPriorityField;

        private string msgVersionField;

        private string _errCodeField;

        private string _errMessageField;

        /// <remarks/>
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public string receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }

        /// <remarks/>
        public string requestTime
        {
            get
            {
                return this.requestTimeField;
            }
            set
            {
                this.requestTimeField = value;
            }
        }

        /// <remarks/>
        public string msgType
        {
            get
            {
                return this.msgTypeField;
            }
            set
            {
                this.msgTypeField = value;
            }
        }

        /// <remarks/>
        public string msgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

        /// <remarks/>
        public string msgPriority
        {
            get
            {
                return this.msgPriorityField;
            }
            set
            {
                this.msgPriorityField = value;
            }
        }

        /// <remarks/>
        public string msgVersion
        {
            get
            {
                return this.msgVersionField;
            }
            set
            {
                this.msgVersionField = value;
            }
        }

        /// <remarks/>
        public string errCode
        {
            get
            {
                return this._errCodeField;
            }
            set
            {
                this._errCodeField = value;
            }
        }

        /// <remarks/>
        public string errMessage
        {
            get
            {
                return this._errMessageField;
            }
            set
            {
                this._errMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.gzsums.net/crisisValue/")]
    public partial class Response
    {

        private ResponseHeader responseHeaderField;

        private string responseBodyField;

        /// <remarks/>
        public ResponseHeader responseHeader
        {
            get
            {
                return this.responseHeaderField;
            }
            set
            {
                this.responseHeaderField = value;
            }
        }

        /// <remarks/>
        public string responseBody
        {
            get
            {
                return this.responseBodyField;
            }
            set
            {
                this.responseBodyField = value;
            }
        }
    }
}
