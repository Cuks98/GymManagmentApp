﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainerSoapService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrainerResponse", Namespace="http://tempuri.org/")]
    public partial class TrainerResponse : object
    {
        
        private System.Nullable<int> ErrorIdField;
        
        private string ErrorMsgField;
        
        private System.Collections.Generic.List<TrainerSoapService.Trainer> TrainersField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> ErrorId
        {
            get
            {
                return this.ErrorIdField;
            }
            set
            {
                this.ErrorIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ErrorMsg
        {
            get
            {
                return this.ErrorMsgField;
            }
            set
            {
                this.ErrorMsgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<TrainerSoapService.Trainer> Trainers
        {
            get
            {
                return this.TrainersField;
            }
            set
            {
                this.TrainersField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Trainer", Namespace="http://tempuri.org/")]
    public partial class Trainer : object
    {
        
        private System.Nullable<int> IdField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private System.DateTime DoBField;
        
        private string PhoneNumberField;
        
        private string GenderField;
        
        private System.Nullable<int> WeightField;
        
        private System.Nullable<int> HeightField;
        
        private string SportHistoryField;
        
        private int SpecialityField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime DoB
        {
            get
            {
                return this.DoBField;
            }
            set
            {
                this.DoBField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Gender
        {
            get
            {
                return this.GenderField;
            }
            set
            {
                this.GenderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<int> Weight
        {
            get
            {
                return this.WeightField;
            }
            set
            {
                this.WeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<int> Height
        {
            get
            {
                return this.HeightField;
            }
            set
            {
                this.HeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string SportHistory
        {
            get
            {
                return this.SportHistoryField;
            }
            set
            {
                this.SportHistoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=9)]
        public int Speciality
        {
            get
            {
                return this.SpecialityField;
            }
            set
            {
                this.SpecialityField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TrainerSoapService.ISoapService")]
    public interface ISoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/Test", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.TestResponse> TestAsync(TrainerSoapService.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/GetTrainers", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.GetTrainersResponse> GetTrainersAsync(TrainerSoapService.GetTrainersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/GetTrainer", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.GetTrainerResponse> GetTrainerAsync(TrainerSoapService.GetTrainerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/RegisterNewTrainer", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.RegisterNewTrainerResponse> RegisterNewTrainerAsync(TrainerSoapService.RegisterNewTrainerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/UpdateTrainer", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.UpdateTrainerResponse> UpdateTrainerAsync(TrainerSoapService.UpdateTrainerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISoapService/DeleteTrainer", ReplyAction="*")]
        System.Threading.Tasks.Task<TrainerSoapService.DeleteTrainerResponse> DeleteTrainerAsync(TrainerSoapService.DeleteTrainerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Test", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.TestRequestBody Body;
        
        public TestRequest()
        {
        }
        
        public TestRequest(TrainerSoapService.TestRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string s;
        
        public TestRequestBody()
        {
        }
        
        public TestRequestBody(string s)
        {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.TestResponseBody Body;
        
        public TestResponse()
        {
        }
        
        public TestResponse(TrainerSoapService.TestResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TestResult;
        
        public TestResponseBody()
        {
        }
        
        public TestResponseBody(string TestResult)
        {
            this.TestResult = TestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTrainersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTrainers", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.GetTrainersRequestBody Body;
        
        public GetTrainersRequest()
        {
        }
        
        public GetTrainersRequest(TrainerSoapService.GetTrainersRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetTrainersRequestBody
    {
        
        public GetTrainersRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTrainersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTrainersResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.GetTrainersResponseBody Body;
        
        public GetTrainersResponse()
        {
        }
        
        public GetTrainersResponse(TrainerSoapService.GetTrainersResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTrainersResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.TrainerResponse GetTrainersResult;
        
        public GetTrainersResponseBody()
        {
        }
        
        public GetTrainersResponseBody(TrainerSoapService.TrainerResponse GetTrainersResult)
        {
            this.GetTrainersResult = GetTrainersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTrainerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTrainer", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.GetTrainerRequestBody Body;
        
        public GetTrainerRequest()
        {
        }
        
        public GetTrainerRequest(TrainerSoapService.GetTrainerRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTrainerRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetTrainerRequestBody()
        {
        }
        
        public GetTrainerRequestBody(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTrainerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTrainerResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.GetTrainerResponseBody Body;
        
        public GetTrainerResponse()
        {
        }
        
        public GetTrainerResponse(TrainerSoapService.GetTrainerResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTrainerResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.TrainerResponse GetTrainerResult;
        
        public GetTrainerResponseBody()
        {
        }
        
        public GetTrainerResponseBody(TrainerSoapService.TrainerResponse GetTrainerResult)
        {
            this.GetTrainerResult = GetTrainerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterNewTrainerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterNewTrainer", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.RegisterNewTrainerRequestBody Body;
        
        public RegisterNewTrainerRequest()
        {
        }
        
        public RegisterNewTrainerRequest(TrainerSoapService.RegisterNewTrainerRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterNewTrainerRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.Trainer trainer;
        
        public RegisterNewTrainerRequestBody()
        {
        }
        
        public RegisterNewTrainerRequestBody(TrainerSoapService.Trainer trainer)
        {
            this.trainer = trainer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterNewTrainerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterNewTrainerResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.RegisterNewTrainerResponseBody Body;
        
        public RegisterNewTrainerResponse()
        {
        }
        
        public RegisterNewTrainerResponse(TrainerSoapService.RegisterNewTrainerResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterNewTrainerResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.TrainerResponse RegisterNewTrainerResult;
        
        public RegisterNewTrainerResponseBody()
        {
        }
        
        public RegisterNewTrainerResponseBody(TrainerSoapService.TrainerResponse RegisterNewTrainerResult)
        {
            this.RegisterNewTrainerResult = RegisterNewTrainerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateTrainerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateTrainer", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.UpdateTrainerRequestBody Body;
        
        public UpdateTrainerRequest()
        {
        }
        
        public UpdateTrainerRequest(TrainerSoapService.UpdateTrainerRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateTrainerRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.Trainer trainer;
        
        public UpdateTrainerRequestBody()
        {
        }
        
        public UpdateTrainerRequestBody(TrainerSoapService.Trainer trainer)
        {
            this.trainer = trainer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateTrainerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateTrainerResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.UpdateTrainerResponseBody Body;
        
        public UpdateTrainerResponse()
        {
        }
        
        public UpdateTrainerResponse(TrainerSoapService.UpdateTrainerResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateTrainerResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.TrainerResponse UpdateTrainerResult;
        
        public UpdateTrainerResponseBody()
        {
        }
        
        public UpdateTrainerResponseBody(TrainerSoapService.TrainerResponse UpdateTrainerResult)
        {
            this.UpdateTrainerResult = UpdateTrainerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteTrainerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteTrainer", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.DeleteTrainerRequestBody Body;
        
        public DeleteTrainerRequest()
        {
        }
        
        public DeleteTrainerRequest(TrainerSoapService.DeleteTrainerRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteTrainerRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DeleteTrainerRequestBody()
        {
        }
        
        public DeleteTrainerRequestBody(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteTrainerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteTrainerResponse", Namespace="http://tempuri.org/", Order=0)]
        public TrainerSoapService.DeleteTrainerResponseBody Body;
        
        public DeleteTrainerResponse()
        {
        }
        
        public DeleteTrainerResponse(TrainerSoapService.DeleteTrainerResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteTrainerResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TrainerSoapService.TrainerResponse DeleteTrainerResult;
        
        public DeleteTrainerResponseBody()
        {
        }
        
        public DeleteTrainerResponseBody(TrainerSoapService.TrainerResponse DeleteTrainerResult)
        {
            this.DeleteTrainerResult = DeleteTrainerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ISoapServiceChannel : TrainerSoapService.ISoapService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class SoapServiceClient : System.ServiceModel.ClientBase<TrainerSoapService.ISoapService>, TrainerSoapService.ISoapService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SoapServiceClient() : 
                base(SoapServiceClient.GetDefaultBinding(), SoapServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISoapService_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), SoapServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SoapServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.TestResponse> TrainerSoapService.ISoapService.TestAsync(TrainerSoapService.TestRequest request)
        {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.TestResponse> TestAsync(string s)
        {
            TrainerSoapService.TestRequest inValue = new TrainerSoapService.TestRequest();
            inValue.Body = new TrainerSoapService.TestRequestBody();
            inValue.Body.s = s;
            return ((TrainerSoapService.ISoapService)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.GetTrainersResponse> TrainerSoapService.ISoapService.GetTrainersAsync(TrainerSoapService.GetTrainersRequest request)
        {
            return base.Channel.GetTrainersAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.GetTrainersResponse> GetTrainersAsync()
        {
            TrainerSoapService.GetTrainersRequest inValue = new TrainerSoapService.GetTrainersRequest();
            inValue.Body = new TrainerSoapService.GetTrainersRequestBody();
            return ((TrainerSoapService.ISoapService)(this)).GetTrainersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.GetTrainerResponse> TrainerSoapService.ISoapService.GetTrainerAsync(TrainerSoapService.GetTrainerRequest request)
        {
            return base.Channel.GetTrainerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.GetTrainerResponse> GetTrainerAsync(int id)
        {
            TrainerSoapService.GetTrainerRequest inValue = new TrainerSoapService.GetTrainerRequest();
            inValue.Body = new TrainerSoapService.GetTrainerRequestBody();
            inValue.Body.id = id;
            return ((TrainerSoapService.ISoapService)(this)).GetTrainerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.RegisterNewTrainerResponse> TrainerSoapService.ISoapService.RegisterNewTrainerAsync(TrainerSoapService.RegisterNewTrainerRequest request)
        {
            return base.Channel.RegisterNewTrainerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.RegisterNewTrainerResponse> RegisterNewTrainerAsync(TrainerSoapService.Trainer trainer)
        {
            TrainerSoapService.RegisterNewTrainerRequest inValue = new TrainerSoapService.RegisterNewTrainerRequest();
            inValue.Body = new TrainerSoapService.RegisterNewTrainerRequestBody();
            inValue.Body.trainer = trainer;
            return ((TrainerSoapService.ISoapService)(this)).RegisterNewTrainerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.UpdateTrainerResponse> TrainerSoapService.ISoapService.UpdateTrainerAsync(TrainerSoapService.UpdateTrainerRequest request)
        {
            return base.Channel.UpdateTrainerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.UpdateTrainerResponse> UpdateTrainerAsync(TrainerSoapService.Trainer trainer)
        {
            TrainerSoapService.UpdateTrainerRequest inValue = new TrainerSoapService.UpdateTrainerRequest();
            inValue.Body = new TrainerSoapService.UpdateTrainerRequestBody();
            inValue.Body.trainer = trainer;
            return ((TrainerSoapService.ISoapService)(this)).UpdateTrainerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TrainerSoapService.DeleteTrainerResponse> TrainerSoapService.ISoapService.DeleteTrainerAsync(TrainerSoapService.DeleteTrainerRequest request)
        {
            return base.Channel.DeleteTrainerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TrainerSoapService.DeleteTrainerResponse> DeleteTrainerAsync(int id)
        {
            TrainerSoapService.DeleteTrainerRequest inValue = new TrainerSoapService.DeleteTrainerRequest();
            inValue.Body = new TrainerSoapService.DeleteTrainerRequestBody();
            inValue.Body.id = id;
            return ((TrainerSoapService.ISoapService)(this)).DeleteTrainerAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISoapService_soap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44311/SoapServer.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SoapServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SoapServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISoapService_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISoapService_soap,
        }
    }
}