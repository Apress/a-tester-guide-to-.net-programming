﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50215.44
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50215.44.
// 
namespace WebServTestBed.CalculateArea {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RectangleAreaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = WebServTestBed.Properties.Settings.Default.WebServTestBed_CalculateArea_Service;
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
        public event RectangleAreaCompletedEventHandler RectangleAreaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RectangleArea", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public float RectangleArea(float length, float width) {
            object[] results = this.Invoke("RectangleArea", new object[] {
                        length,
                        width});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void RectangleAreaAsync(float length, float width) {
            this.RectangleAreaAsync(length, width, null);
        }
        
        /// <remarks/>
        public void RectangleAreaAsync(float length, float width, object userState) {
            if ((this.RectangleAreaOperationCompleted == null)) {
                this.RectangleAreaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRectangleAreaOperationCompleted);
            }
            this.InvokeAsync("RectangleArea", new object[] {
                        length,
                        width}, this.RectangleAreaOperationCompleted, userState);
        }
        
        private void OnRectangleAreaOperationCompleted(object arg) {
            if ((this.RectangleAreaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RectangleAreaCompleted(this, new RectangleAreaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
            if ((((wsUri.Port >= 1024) 
                        && (wsUri.Port <= 5000)) 
                        && (string.Compare(wsUri.Host, "localHost", true) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    public delegate void RectangleAreaCompletedEventHandler(object sender, RectangleAreaCompletedEventArgs e);
    
    /// <remarks/>
    public partial class RectangleAreaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RectangleAreaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
}
