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
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace LGInterface.WebReferenceForDaiJiaTiJian {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MessageRouteServiceSoapImplServiceSoapBinding", Namespace="http://ws.www.gzsums.net/")]
    public partial class MessageRouteServiceSoapImplService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getProgressNoteRecOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendMessageAsyncOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendMessageSyncOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MessageRouteServiceSoapImplService() {
            this.Url = global::LGInterface.Properties.Settings.Default.LGInterface_WebReferenceForDaiJiaTiJian_MessageRouteServiceSoapImplService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getProgressNoteRecCompletedEventHandler getProgressNoteRecCompleted;
        
        /// <remarks/>
        public event sendMessageAsyncCompletedEventHandler sendMessageAsyncCompleted;
        
        /// <remarks/>
        public event sendMessageSyncCompletedEventHandler sendMessageSyncCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://esb.www.gzsums.net", ResponseNamespace="http://esb.www.gzsums.net", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getProgressNoteRecReturn")]
        public Response getProgressNoteRec(Request req) {
            object[] results = this.Invoke("getProgressNoteRec", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void getProgressNoteRecAsync(Request req) {
            this.getProgressNoteRecAsync(req, null);
        }
        
        /// <remarks/>
        public void getProgressNoteRecAsync(Request req, object userState) {
            if ((this.getProgressNoteRecOperationCompleted == null)) {
                this.getProgressNoteRecOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetProgressNoteRecOperationCompleted);
            }
            this.InvokeAsync("getProgressNoteRec", new object[] {
                        req}, this.getProgressNoteRecOperationCompleted, userState);
        }
        
        private void OngetProgressNoteRecOperationCompleted(object arg) {
            if ((this.getProgressNoteRecCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getProgressNoteRecCompleted(this, new getProgressNoteRecCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net//esb/sendMessageAsync", RequestNamespace="http://www.gzsums.net//esb/", ResponseNamespace="http://www.gzsums.net//esb/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response sendMessageAsync(Request req) {
            object[] results = this.Invoke("sendMessageAsync", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void sendMessageAsyncAsync(Request req) {
            this.sendMessageAsyncAsync(req, null);
        }
        
        /// <remarks/>
        public void sendMessageAsyncAsync(Request req, object userState) {
            if ((this.sendMessageAsyncOperationCompleted == null)) {
                this.sendMessageAsyncOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendMessageAsyncOperationCompleted);
            }
            this.InvokeAsync("sendMessageAsync", new object[] {
                        req}, this.sendMessageAsyncOperationCompleted, userState);
        }
        
        private void OnsendMessageAsyncOperationCompleted(object arg) {
            if ((this.sendMessageAsyncCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendMessageAsyncCompleted(this, new sendMessageAsyncCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gzsums.net//esb/sendMessageSync", RequestNamespace="http://www.gzsums.net//esb/", ResponseNamespace="http://www.gzsums.net//esb/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Response sendMessageSync(Request req) {
            object[] results = this.Invoke("sendMessageSync", new object[] {
                        req});
            return ((Response)(results[0]));
        }
        
        /// <remarks/>
        public void sendMessageSyncAsync(Request req) {
            this.sendMessageSyncAsync(req, null);
        }
        
        /// <remarks/>
        public void sendMessageSyncAsync(Request req, object userState) {
            if ((this.sendMessageSyncOperationCompleted == null)) {
                this.sendMessageSyncOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendMessageSyncOperationCompleted);
            }
            this.InvokeAsync("sendMessageSync", new object[] {
                        req}, this.sendMessageSyncOperationCompleted, userState);
        }
        
        private void OnsendMessageSyncOperationCompleted(object arg) {
            if ((this.sendMessageSyncCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendMessageSyncCompleted(this, new sendMessageSyncCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net//esb/")]
    public partial class Request {
        
        private RequestHeader requestHeaderField;
        
        private string requestBodyField;
        
        /// <remarks/>
        public RequestHeader requestHeader {
            get {
                return this.requestHeaderField;
            }
            set {
                this.requestHeaderField = value;
            }
        }
        
        /// <remarks/>
        public string requestBody {
            get {
                return this.requestBodyField;
            }
            set {
                this.requestBodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net//esb/")]
    public partial class RequestHeader {
        
        private string senderField;
        
        private string receiverField;
        
        private string requestTimeField;
        
        private string msgTypeField;
        
        private string msgIdField;
        
        private string msgPriorityField;
        
        private string msgVersionField;
        
        /// <remarks/>
        public string sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        public string receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        public string requestTime {
            get {
                return this.requestTimeField;
            }
            set {
                this.requestTimeField = value;
            }
        }
        
        /// <remarks/>
        public string msgType {
            get {
                return this.msgTypeField;
            }
            set {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        public string msgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public string msgPriority {
            get {
                return this.msgPriorityField;
            }
            set {
                this.msgPriorityField = value;
            }
        }
        
        /// <remarks/>
        public string msgVersion {
            get {
                return this.msgVersionField;
            }
            set {
                this.msgVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net//esb/")]
    public partial class ResponseHeader {
        
        private string senderField;
        
        private string receiverField;
        
        private string responseTimeField;
        
        private string msgTypeField;
        
        private string msgIdField;
        
        private string errCodeField;
        
        private string errMessageField;
        
        private string msgPriorityField;
        
        private string msgVersionField;
        
        /// <remarks/>
        public string sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        public string receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        public string responseTime {
            get {
                return this.responseTimeField;
            }
            set {
                this.responseTimeField = value;
            }
        }
        
        /// <remarks/>
        public string msgType {
            get {
                return this.msgTypeField;
            }
            set {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        public string msgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public string errCode {
            get {
                return this.errCodeField;
            }
            set {
                this.errCodeField = value;
            }
        }
        
        /// <remarks/>
        public string errMessage {
            get {
                return this.errMessageField;
            }
            set {
                this.errMessageField = value;
            }
        }
        
        /// <remarks/>
        public string msgPriority {
            get {
                return this.msgPriorityField;
            }
            set {
                this.msgPriorityField = value;
            }
        }
        
        /// <remarks/>
        public string msgVersion {
            get {
                return this.msgVersionField;
            }
            set {
                this.msgVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gzsums.net//esb/")]
    public partial class Response {
        
        private ResponseHeader responseHeaderField;
        
        private string responseBodyField;
        
        /// <remarks/>
        public ResponseHeader responseHeader {
            get {
                return this.responseHeaderField;
            }
            set {
                this.responseHeaderField = value;
            }
        }
        
        /// <remarks/>
        public string responseBody {
            get {
                return this.responseBodyField;
            }
            set {
                this.responseBodyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getProgressNoteRecCompletedEventHandler(object sender, getProgressNoteRecCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getProgressNoteRecCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getProgressNoteRecCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void sendMessageAsyncCompletedEventHandler(object sender, sendMessageAsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendMessageAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendMessageAsyncCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void sendMessageSyncCompletedEventHandler(object sender, sendMessageSyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendMessageSyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendMessageSyncCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Response Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Response)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591