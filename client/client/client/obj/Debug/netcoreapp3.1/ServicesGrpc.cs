// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Services.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class Service
  {
    static readonly string __ServiceName = "Service";

    static readonly grpc::Marshaller<global::GrpcService.Protos.AddCommentRequest> __Marshaller_AddCommentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.AddCommentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.AddCommentResponse> __Marshaller_AddCommentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.AddCommentResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.UpdateCommentRequest> __Marshaller_UpdateCommentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.UpdateCommentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.UpdateCommentResponse> __Marshaller_UpdateCommentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.UpdateCommentResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.AddCommentRequest, global::GrpcService.Protos.AddCommentResponse> __Method_AddComment = new grpc::Method<global::GrpcService.Protos.AddCommentRequest, global::GrpcService.Protos.AddCommentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_AddCommentRequest,
        __Marshaller_AddCommentResponse);

    static readonly grpc::Method<global::GrpcService.Protos.UpdateCommentRequest, global::GrpcService.Protos.UpdateCommentResponse> __Method_UpdateComment = new grpc::Method<global::GrpcService.Protos.UpdateCommentRequest, global::GrpcService.Protos.UpdateCommentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_UpdateCommentRequest,
        __Marshaller_UpdateCommentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.ServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Service</summary>
    public partial class ServiceClient : grpc::ClientBase<ServiceClient>
    {
      /// <summary>Creates a new client for Service</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Service that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.Protos.AddCommentResponse AddComment(global::GrpcService.Protos.AddCommentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.AddCommentResponse AddComment(global::GrpcService.Protos.AddCommentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.AddCommentResponse> AddCommentAsync(global::GrpcService.Protos.AddCommentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.AddCommentResponse> AddCommentAsync(global::GrpcService.Protos.AddCommentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddComment, null, options, request);
      }
      public virtual global::GrpcService.Protos.UpdateCommentResponse UpdateComment(global::GrpcService.Protos.UpdateCommentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.UpdateCommentResponse UpdateComment(global::GrpcService.Protos.UpdateCommentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.UpdateCommentResponse> UpdateCommentAsync(global::GrpcService.Protos.UpdateCommentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.UpdateCommentResponse> UpdateCommentAsync(global::GrpcService.Protos.UpdateCommentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateComment, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceClient(configuration);
      }
    }

  }
}
#endregion
