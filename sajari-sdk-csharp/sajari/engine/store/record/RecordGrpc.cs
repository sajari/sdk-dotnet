// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: sajari/engine/store/record/record.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Sajari.Engine.Store.Record {
  /// <summary>
  ///  Store is a service which defines methods for adding, getting, patching
  ///  and deleting records from a collection.
  /// </summary>
  public static class Store
  {
    static readonly string __ServiceName = "sajari.engine.store.record.Store";

    static readonly Marshaller<global::Sajari.Engine.Store.Record.Records> __Marshaller_Records = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.Records.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.AddResponse> __Marshaller_AddResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.AddResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.Keys> __Marshaller_Keys = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.Keys.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.GetResponse> __Marshaller_GetResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.GetResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.DeleteResponse> __Marshaller_DeleteResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.DeleteResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.MutateRequest> __Marshaller_MutateRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.MutateRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.MutateResponse> __Marshaller_MutateResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.MutateResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.ExistsResponse> __Marshaller_ExistsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.ExistsResponse.Parser.ParseFrom);

    static readonly Method<global::Sajari.Engine.Store.Record.Records, global::Sajari.Engine.Store.Record.AddResponse> __Method_Add = new Method<global::Sajari.Engine.Store.Record.Records, global::Sajari.Engine.Store.Record.AddResponse>(
        MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_Records,
        __Marshaller_AddResponse);

    static readonly Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.GetResponse> __Method_Get = new Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.GetResponse>(
        MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Keys,
        __Marshaller_GetResponse);

    static readonly Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.DeleteResponse> __Method_Delete = new Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.DeleteResponse>(
        MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_Keys,
        __Marshaller_DeleteResponse);

    static readonly Method<global::Sajari.Engine.Store.Record.MutateRequest, global::Sajari.Engine.Store.Record.MutateResponse> __Method_Mutate = new Method<global::Sajari.Engine.Store.Record.MutateRequest, global::Sajari.Engine.Store.Record.MutateResponse>(
        MethodType.Unary,
        __ServiceName,
        "Mutate",
        __Marshaller_MutateRequest,
        __Marshaller_MutateResponse);

    static readonly Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.ExistsResponse> __Method_Exists = new Method<global::Sajari.Engine.Store.Record.Keys, global::Sajari.Engine.Store.Record.ExistsResponse>(
        MethodType.Unary,
        __ServiceName,
        "Exists",
        __Marshaller_Keys,
        __Marshaller_ExistsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sajari.Engine.Store.Record.RecordReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Store</summary>
    public abstract class StoreBase
    {
      /// <summary>
      ///  Add creates new records in the collection returning a key for each
      ///  stored record.  The key can then be used in subsequent requests to
      ///  get/delete/patch.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.AddResponse> Add(global::Sajari.Engine.Store.Record.Records request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Get retrieves the records corresponding to the listed keys.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.GetResponse> Get(global::Sajari.Engine.Store.Record.Keys request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Delete removes the records corresponding to the listed keys.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.DeleteResponse> Delete(global::Sajari.Engine.Store.Record.Keys request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Mutate applies key-value updates to records corresponding to
      ///  keys.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.MutateResponse> Mutate(global::Sajari.Engine.Store.Record.MutateRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Exists
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.ExistsResponse> Exists(global::Sajari.Engine.Store.Record.Keys request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Store</summary>
    public class StoreClient : ClientBase<StoreClient>
    {
      /// <summary>Creates a new client for Store</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StoreClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Store that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StoreClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StoreClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StoreClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Add creates new records in the collection returning a key for each
      ///  stored record.  The key can then be used in subsequent requests to
      ///  get/delete/patch.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.AddResponse Add(global::Sajari.Engine.Store.Record.Records request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Add(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Add creates new records in the collection returning a key for each
      ///  stored record.  The key can then be used in subsequent requests to
      ///  get/delete/patch.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.AddResponse Add(global::Sajari.Engine.Store.Record.Records request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Add, null, options, request);
      }
      /// <summary>
      ///  Add creates new records in the collection returning a key for each
      ///  stored record.  The key can then be used in subsequent requests to
      ///  get/delete/patch.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.AddResponse> AddAsync(global::Sajari.Engine.Store.Record.Records request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Add creates new records in the collection returning a key for each
      ///  stored record.  The key can then be used in subsequent requests to
      ///  get/delete/patch.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.AddResponse> AddAsync(global::Sajari.Engine.Store.Record.Records request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Add, null, options, request);
      }
      /// <summary>
      ///  Get retrieves the records corresponding to the listed keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.GetResponse Get(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get retrieves the records corresponding to the listed keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.GetResponse Get(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      ///  Get retrieves the records corresponding to the listed keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.GetResponse> GetAsync(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get retrieves the records corresponding to the listed keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.GetResponse> GetAsync(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      ///  Delete removes the records corresponding to the listed keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.DeleteResponse Delete(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Delete removes the records corresponding to the listed keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.DeleteResponse Delete(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      ///  Delete removes the records corresponding to the listed keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.DeleteResponse> DeleteAsync(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Delete removes the records corresponding to the listed keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.DeleteResponse> DeleteAsync(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      ///  Mutate applies key-value updates to records corresponding to
      ///  keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.MutateResponse Mutate(global::Sajari.Engine.Store.Record.MutateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Mutate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutate applies key-value updates to records corresponding to
      ///  keys.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.MutateResponse Mutate(global::Sajari.Engine.Store.Record.MutateRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Mutate, null, options, request);
      }
      /// <summary>
      ///  Mutate applies key-value updates to records corresponding to
      ///  keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.MutateResponse> MutateAsync(global::Sajari.Engine.Store.Record.MutateRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MutateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Mutate applies key-value updates to records corresponding to
      ///  keys.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.MutateResponse> MutateAsync(global::Sajari.Engine.Store.Record.MutateRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Mutate, null, options, request);
      }
      /// <summary>
      ///  Exists
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.ExistsResponse Exists(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Exists(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Exists
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.ExistsResponse Exists(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Exists, null, options, request);
      }
      /// <summary>
      ///  Exists
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.ExistsResponse> ExistsAsync(global::Sajari.Engine.Store.Record.Keys request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ExistsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Exists
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.ExistsResponse> ExistsAsync(global::Sajari.Engine.Store.Record.Keys request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Exists, null, options, request);
      }
      protected override StoreClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StoreClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(StoreBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_Mutate, serviceImpl.Mutate)
          .AddMethod(__Method_Exists, serviceImpl.Exists).Build();
    }

  }
  /// <summary>
  ///  Score is a service which defines methods for setting and incrementing
  ///  term instance scores.
  /// </summary>
  public static class Score
  {
    static readonly string __ServiceName = "sajari.engine.store.record.Score";

    static readonly Marshaller<global::Sajari.Engine.Store.Record.SetRequest> __Marshaller_SetRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.SetRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.SetResponse> __Marshaller_SetResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.SetResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.IncrementRequest> __Marshaller_IncrementRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.IncrementRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Engine.Store.Record.IncrementResponse> __Marshaller_IncrementResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Engine.Store.Record.IncrementResponse.Parser.ParseFrom);

    static readonly Method<global::Sajari.Engine.Store.Record.SetRequest, global::Sajari.Engine.Store.Record.SetResponse> __Method_Set = new Method<global::Sajari.Engine.Store.Record.SetRequest, global::Sajari.Engine.Store.Record.SetResponse>(
        MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_SetRequest,
        __Marshaller_SetResponse);

    static readonly Method<global::Sajari.Engine.Store.Record.IncrementRequest, global::Sajari.Engine.Store.Record.IncrementResponse> __Method_Increment = new Method<global::Sajari.Engine.Store.Record.IncrementRequest, global::Sajari.Engine.Store.Record.IncrementResponse>(
        MethodType.Unary,
        __ServiceName,
        "Increment",
        __Marshaller_IncrementRequest,
        __Marshaller_IncrementResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sajari.Engine.Store.Record.RecordReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of Score</summary>
    public abstract class ScoreBase
    {
      /// <summary>
      ///  SetScores sets record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.SetResponse> Set(global::Sajari.Engine.Store.Record.SetRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  IncrScores incrementally updates record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Engine.Store.Record.IncrementResponse> Increment(global::Sajari.Engine.Store.Record.IncrementRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Score</summary>
    public class ScoreClient : ClientBase<ScoreClient>
    {
      /// <summary>Creates a new client for Score</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ScoreClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Score that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ScoreClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ScoreClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ScoreClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  SetScores sets record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.SetResponse Set(global::Sajari.Engine.Store.Record.SetRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  SetScores sets record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.SetResponse Set(global::Sajari.Engine.Store.Record.SetRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>
      ///  SetScores sets record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.SetResponse> SetAsync(global::Sajari.Engine.Store.Record.SetRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  SetScores sets record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.SetResponse> SetAsync(global::Sajari.Engine.Store.Record.SetRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>
      ///  IncrScores incrementally updates record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.IncrementResponse Increment(global::Sajari.Engine.Store.Record.IncrementRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Increment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  IncrScores incrementally updates record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual global::Sajari.Engine.Store.Record.IncrementResponse Increment(global::Sajari.Engine.Store.Record.IncrementRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Increment, null, options, request);
      }
      /// <summary>
      ///  IncrScores incrementally updates record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.IncrementResponse> IncrementAsync(global::Sajari.Engine.Store.Record.IncrementRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return IncrementAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  IncrScores incrementally updates record-term instance pos/neg scores in the Store.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Engine.Store.Record.IncrementResponse> IncrementAsync(global::Sajari.Engine.Store.Record.IncrementRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Increment, null, options, request);
      }
      protected override ScoreClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ScoreClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ScoreBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Set, serviceImpl.Set)
          .AddMethod(__Method_Increment, serviceImpl.Increment).Build();
    }

  }
}
#endregion