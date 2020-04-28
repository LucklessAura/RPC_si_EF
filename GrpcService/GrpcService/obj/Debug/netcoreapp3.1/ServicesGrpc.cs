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
    static readonly grpc::Marshaller<global::GrpcService.Protos.GetCommentByIdRequest> __Marshaller_GetCommentByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.GetCommentByIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.GetCommentByIdResponse> __Marshaller_GetCommentByIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.GetCommentByIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.AddPostRequest> __Marshaller_AddPostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.AddPostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.AddPostResponse> __Marshaller_AddPostResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.AddPostResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.UpdatePostRequest> __Marshaller_UpdatePostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.UpdatePostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.UpdatePostResponse> __Marshaller_UpdatePostResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.UpdatePostResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.DeletePostRequest> __Marshaller_DeletePostRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.DeletePostRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.DeletePostResponse> __Marshaller_DeletePostResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.DeletePostResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.GetPostByIdRequest> __Marshaller_GetPostByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.GetPostByIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.GetPostByIdResponse> __Marshaller_GetPostByIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.GetPostByIdResponse.Parser.ParseFrom);

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

    static readonly grpc::Method<global::GrpcService.Protos.GetCommentByIdRequest, global::GrpcService.Protos.GetCommentByIdResponse> __Method_GetCommentById = new grpc::Method<global::GrpcService.Protos.GetCommentByIdRequest, global::GrpcService.Protos.GetCommentByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_GetCommentByIdRequest,
        __Marshaller_GetCommentByIdResponse);

    static readonly grpc::Method<global::GrpcService.Protos.AddPostRequest, global::GrpcService.Protos.AddPostResponse> __Method_AddPost = new grpc::Method<global::GrpcService.Protos.AddPostRequest, global::GrpcService.Protos.AddPostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_AddPostRequest,
        __Marshaller_AddPostResponse);

    static readonly grpc::Method<global::GrpcService.Protos.UpdatePostRequest, global::GrpcService.Protos.UpdatePostResponse> __Method_UpdatePost = new grpc::Method<global::GrpcService.Protos.UpdatePostRequest, global::GrpcService.Protos.UpdatePostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_UpdatePostRequest,
        __Marshaller_UpdatePostResponse);

    static readonly grpc::Method<global::GrpcService.Protos.DeletePostRequest, global::GrpcService.Protos.DeletePostResponse> __Method_DeletePost = new grpc::Method<global::GrpcService.Protos.DeletePostRequest, global::GrpcService.Protos.DeletePostResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_DeletePostRequest,
        __Marshaller_DeletePostResponse);

    static readonly grpc::Method<global::GrpcService.Protos.GetPostByIdRequest, global::GrpcService.Protos.GetPostByIdResponse> __Method_GetPostById = new grpc::Method<global::GrpcService.Protos.GetPostByIdRequest, global::GrpcService.Protos.GetPostByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_GetPostByIdRequest,
        __Marshaller_GetPostByIdResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.ServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Service</summary>
    [grpc::BindServiceMethod(typeof(Service), "BindService")]
    public abstract partial class ServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.AddCommentResponse> AddComment(global::GrpcService.Protos.AddCommentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.UpdateCommentResponse> UpdateComment(global::GrpcService.Protos.UpdateCommentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.GetCommentByIdResponse> GetCommentById(global::GrpcService.Protos.GetCommentByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.AddPostResponse> AddPost(global::GrpcService.Protos.AddPostRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.UpdatePostResponse> UpdatePost(global::GrpcService.Protos.UpdatePostRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.DeletePostResponse> DeletePost(global::GrpcService.Protos.DeletePostRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.GetPostByIdResponse> GetPostById(global::GrpcService.Protos.GetPostByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_UpdateComment, serviceImpl.UpdateComment)
          .AddMethod(__Method_GetCommentById, serviceImpl.GetCommentById)
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.AddCommentRequest, global::GrpcService.Protos.AddCommentResponse>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_UpdateComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.UpdateCommentRequest, global::GrpcService.Protos.UpdateCommentResponse>(serviceImpl.UpdateComment));
      serviceBinder.AddMethod(__Method_GetCommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.GetCommentByIdRequest, global::GrpcService.Protos.GetCommentByIdResponse>(serviceImpl.GetCommentById));
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.AddPostRequest, global::GrpcService.Protos.AddPostResponse>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.UpdatePostRequest, global::GrpcService.Protos.UpdatePostResponse>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.DeletePostRequest, global::GrpcService.Protos.DeletePostResponse>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.GetPostByIdRequest, global::GrpcService.Protos.GetPostByIdResponse>(serviceImpl.GetPostById));
    }

  }
}
#endregion
