﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace xProxy.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xgtechproxyuri.org/", ConfigurationName="ServiceReference1.DataServiceSoap")]
    public interface DataServiceSoap {
        
        // CODEGEN: 命名空间 http://xgtechproxyuri.org/ 的元素名称 ip 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/HttpToDb", ReplyAction="*")]
        xProxy.ServiceReference1.HttpToDbResponse HttpToDb(xProxy.ServiceReference1.HttpToDbRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/HttpToDb", ReplyAction="*")]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.HttpToDbResponse> HttpToDbAsync(xProxy.ServiceReference1.HttpToDbRequest request);
        
        // CODEGEN: 命名空间 http://xgtechproxyuri.org/ 的元素名称 ip 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/DelHttp", ReplyAction="*")]
        xProxy.ServiceReference1.DelHttpResponse DelHttp(xProxy.ServiceReference1.DelHttpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/DelHttp", ReplyAction="*")]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.DelHttpResponse> DelHttpAsync(xProxy.ServiceReference1.DelHttpRequest request);
        
        // CODEGEN: 命名空间 http://xgtechproxyuri.org/ 的元素名称 ip 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/Socks5ToDb", ReplyAction="*")]
        xProxy.ServiceReference1.Socks5ToDbResponse Socks5ToDb(xProxy.ServiceReference1.Socks5ToDbRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/Socks5ToDb", ReplyAction="*")]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.Socks5ToDbResponse> Socks5ToDbAsync(xProxy.ServiceReference1.Socks5ToDbRequest request);
        
        // CODEGEN: 命名空间 http://xgtechproxyuri.org/ 的元素名称 ip 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/DelSocks5", ReplyAction="*")]
        xProxy.ServiceReference1.DelSocks5Response DelSocks5(xProxy.ServiceReference1.DelSocks5Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://xgtechproxyuri.org/DelSocks5", ReplyAction="*")]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.DelSocks5Response> DelSocks5Async(xProxy.ServiceReference1.DelSocks5Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HttpToDbRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HttpToDb", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.HttpToDbRequestBody Body;
        
        public HttpToDbRequest() {
        }
        
        public HttpToDbRequest(xProxy.ServiceReference1.HttpToDbRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class HttpToDbRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string port;
        
        public HttpToDbRequestBody() {
        }
        
        public HttpToDbRequestBody(string ip, string port) {
            this.ip = ip;
            this.port = port;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HttpToDbResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HttpToDbResponse", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.HttpToDbResponseBody Body;
        
        public HttpToDbResponse() {
        }
        
        public HttpToDbResponse(xProxy.ServiceReference1.HttpToDbResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class HttpToDbResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int HttpToDbResult;
        
        public HttpToDbResponseBody() {
        }
        
        public HttpToDbResponseBody(int HttpToDbResult) {
            this.HttpToDbResult = HttpToDbResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelHttpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelHttp", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.DelHttpRequestBody Body;
        
        public DelHttpRequest() {
        }
        
        public DelHttpRequest(xProxy.ServiceReference1.DelHttpRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class DelHttpRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string port;
        
        public DelHttpRequestBody() {
        }
        
        public DelHttpRequestBody(string ip, string port) {
            this.ip = ip;
            this.port = port;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelHttpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelHttpResponse", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.DelHttpResponseBody Body;
        
        public DelHttpResponse() {
        }
        
        public DelHttpResponse(xProxy.ServiceReference1.DelHttpResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class DelHttpResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DelHttpResult;
        
        public DelHttpResponseBody() {
        }
        
        public DelHttpResponseBody(int DelHttpResult) {
            this.DelHttpResult = DelHttpResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Socks5ToDbRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Socks5ToDb", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.Socks5ToDbRequestBody Body;
        
        public Socks5ToDbRequest() {
        }
        
        public Socks5ToDbRequest(xProxy.ServiceReference1.Socks5ToDbRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class Socks5ToDbRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string port;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pwd;
        
        public Socks5ToDbRequestBody() {
        }
        
        public Socks5ToDbRequestBody(string ip, string port, string name, string pwd) {
            this.ip = ip;
            this.port = port;
            this.name = name;
            this.pwd = pwd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Socks5ToDbResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Socks5ToDbResponse", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.Socks5ToDbResponseBody Body;
        
        public Socks5ToDbResponse() {
        }
        
        public Socks5ToDbResponse(xProxy.ServiceReference1.Socks5ToDbResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class Socks5ToDbResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Socks5ToDbResult;
        
        public Socks5ToDbResponseBody() {
        }
        
        public Socks5ToDbResponseBody(int Socks5ToDbResult) {
            this.Socks5ToDbResult = Socks5ToDbResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelSocks5Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelSocks5", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.DelSocks5RequestBody Body;
        
        public DelSocks5Request() {
        }
        
        public DelSocks5Request(xProxy.ServiceReference1.DelSocks5RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class DelSocks5RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ip;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string port;
        
        public DelSocks5RequestBody() {
        }
        
        public DelSocks5RequestBody(string ip, string port) {
            this.ip = ip;
            this.port = port;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelSocks5Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelSocks5Response", Namespace="http://xgtechproxyuri.org/", Order=0)]
        public xProxy.ServiceReference1.DelSocks5ResponseBody Body;
        
        public DelSocks5Response() {
        }
        
        public DelSocks5Response(xProxy.ServiceReference1.DelSocks5ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://xgtechproxyuri.org/")]
    public partial class DelSocks5ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DelSocks5Result;
        
        public DelSocks5ResponseBody() {
        }
        
        public DelSocks5ResponseBody(int DelSocks5Result) {
            this.DelSocks5Result = DelSocks5Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataServiceSoapChannel : xProxy.ServiceReference1.DataServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceSoapClient : System.ServiceModel.ClientBase<xProxy.ServiceReference1.DataServiceSoap>, xProxy.ServiceReference1.DataServiceSoap {
        
        public DataServiceSoapClient() {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        xProxy.ServiceReference1.HttpToDbResponse xProxy.ServiceReference1.DataServiceSoap.HttpToDb(xProxy.ServiceReference1.HttpToDbRequest request) {
            return base.Channel.HttpToDb(request);
        }
        
        public int HttpToDb(string ip, string port) {
            xProxy.ServiceReference1.HttpToDbRequest inValue = new xProxy.ServiceReference1.HttpToDbRequest();
            inValue.Body = new xProxy.ServiceReference1.HttpToDbRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            xProxy.ServiceReference1.HttpToDbResponse retVal = ((xProxy.ServiceReference1.DataServiceSoap)(this)).HttpToDb(inValue);
            return retVal.Body.HttpToDbResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.HttpToDbResponse> xProxy.ServiceReference1.DataServiceSoap.HttpToDbAsync(xProxy.ServiceReference1.HttpToDbRequest request) {
            return base.Channel.HttpToDbAsync(request);
        }
        
        public System.Threading.Tasks.Task<xProxy.ServiceReference1.HttpToDbResponse> HttpToDbAsync(string ip, string port) {
            xProxy.ServiceReference1.HttpToDbRequest inValue = new xProxy.ServiceReference1.HttpToDbRequest();
            inValue.Body = new xProxy.ServiceReference1.HttpToDbRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            return ((xProxy.ServiceReference1.DataServiceSoap)(this)).HttpToDbAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        xProxy.ServiceReference1.DelHttpResponse xProxy.ServiceReference1.DataServiceSoap.DelHttp(xProxy.ServiceReference1.DelHttpRequest request) {
            return base.Channel.DelHttp(request);
        }
        
        public int DelHttp(string ip, string port) {
            xProxy.ServiceReference1.DelHttpRequest inValue = new xProxy.ServiceReference1.DelHttpRequest();
            inValue.Body = new xProxy.ServiceReference1.DelHttpRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            xProxy.ServiceReference1.DelHttpResponse retVal = ((xProxy.ServiceReference1.DataServiceSoap)(this)).DelHttp(inValue);
            return retVal.Body.DelHttpResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.DelHttpResponse> xProxy.ServiceReference1.DataServiceSoap.DelHttpAsync(xProxy.ServiceReference1.DelHttpRequest request) {
            return base.Channel.DelHttpAsync(request);
        }
        
        public System.Threading.Tasks.Task<xProxy.ServiceReference1.DelHttpResponse> DelHttpAsync(string ip, string port) {
            xProxy.ServiceReference1.DelHttpRequest inValue = new xProxy.ServiceReference1.DelHttpRequest();
            inValue.Body = new xProxy.ServiceReference1.DelHttpRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            return ((xProxy.ServiceReference1.DataServiceSoap)(this)).DelHttpAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        xProxy.ServiceReference1.Socks5ToDbResponse xProxy.ServiceReference1.DataServiceSoap.Socks5ToDb(xProxy.ServiceReference1.Socks5ToDbRequest request) {
            return base.Channel.Socks5ToDb(request);
        }
        
        public int Socks5ToDb(string ip, string port, string name, string pwd) {
            xProxy.ServiceReference1.Socks5ToDbRequest inValue = new xProxy.ServiceReference1.Socks5ToDbRequest();
            inValue.Body = new xProxy.ServiceReference1.Socks5ToDbRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            inValue.Body.name = name;
            inValue.Body.pwd = pwd;
            xProxy.ServiceReference1.Socks5ToDbResponse retVal = ((xProxy.ServiceReference1.DataServiceSoap)(this)).Socks5ToDb(inValue);
            return retVal.Body.Socks5ToDbResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.Socks5ToDbResponse> xProxy.ServiceReference1.DataServiceSoap.Socks5ToDbAsync(xProxy.ServiceReference1.Socks5ToDbRequest request) {
            return base.Channel.Socks5ToDbAsync(request);
        }
        
        public System.Threading.Tasks.Task<xProxy.ServiceReference1.Socks5ToDbResponse> Socks5ToDbAsync(string ip, string port, string name, string pwd) {
            xProxy.ServiceReference1.Socks5ToDbRequest inValue = new xProxy.ServiceReference1.Socks5ToDbRequest();
            inValue.Body = new xProxy.ServiceReference1.Socks5ToDbRequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            inValue.Body.name = name;
            inValue.Body.pwd = pwd;
            return ((xProxy.ServiceReference1.DataServiceSoap)(this)).Socks5ToDbAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        xProxy.ServiceReference1.DelSocks5Response xProxy.ServiceReference1.DataServiceSoap.DelSocks5(xProxy.ServiceReference1.DelSocks5Request request) {
            return base.Channel.DelSocks5(request);
        }
        
        public int DelSocks5(string ip, string port) {
            xProxy.ServiceReference1.DelSocks5Request inValue = new xProxy.ServiceReference1.DelSocks5Request();
            inValue.Body = new xProxy.ServiceReference1.DelSocks5RequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            xProxy.ServiceReference1.DelSocks5Response retVal = ((xProxy.ServiceReference1.DataServiceSoap)(this)).DelSocks5(inValue);
            return retVal.Body.DelSocks5Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<xProxy.ServiceReference1.DelSocks5Response> xProxy.ServiceReference1.DataServiceSoap.DelSocks5Async(xProxy.ServiceReference1.DelSocks5Request request) {
            return base.Channel.DelSocks5Async(request);
        }
        
        public System.Threading.Tasks.Task<xProxy.ServiceReference1.DelSocks5Response> DelSocks5Async(string ip, string port) {
            xProxy.ServiceReference1.DelSocks5Request inValue = new xProxy.ServiceReference1.DelSocks5Request();
            inValue.Body = new xProxy.ServiceReference1.DelSocks5RequestBody();
            inValue.Body.ip = ip;
            inValue.Body.port = port;
            return ((xProxy.ServiceReference1.DataServiceSoap)(this)).DelSocks5Async(inValue);
        }
    }
}
