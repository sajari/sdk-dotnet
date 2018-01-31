// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: sajari/api/query/v1/query.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Sajari.Api.Query.V1 {
  public static class Query
  {
    static readonly string __ServiceName = "sajari.api.query.v1.Query";

    static readonly Marshaller<global::Sajari.Api.Query.V1.SearchRequest> __Marshaller_SearchRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Api.Query.V1.SearchRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sajari.Api.Query.V1.SearchResponse> __Marshaller_SearchResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sajari.Api.Query.V1.SearchResponse.Parser.ParseFrom);

    static readonly Method<global::Sajari.Api.Query.V1.SearchRequest, global::Sajari.Api.Query.V1.SearchResponse> __Method_Search = new Method<global::Sajari.Api.Query.V1.SearchRequest, global::Sajari.Api.Query.V1.SearchResponse>(
        MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_SearchRequest,
        __Marshaller_SearchResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sajari.Api.Query.V1.QueryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Query</summary>
    public abstract class QueryBase
    {
      /// <summary>
      ///  Search performs a search.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Sajari.Api.Query.V1.SearchResponse> Search(global::Sajari.Api.Query.V1.SearchRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Query</summary>
    public class QueryClient : ClientBase<QueryClient>
    {
      /// <summary>Creates a new client for Query</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public QueryClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Query that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public QueryClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected QueryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected QueryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Search performs a search.
      /// </summary>
      public virtual global::Sajari.Api.Query.V1.SearchResponse Search(global::Sajari.Api.Query.V1.SearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Search(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Search performs a search.
      /// </summary>
      public virtual global::Sajari.Api.Query.V1.SearchResponse Search(global::Sajari.Api.Query.V1.SearchRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>
      ///  Search performs a search.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Api.Query.V1.SearchResponse> SearchAsync(global::Sajari.Api.Query.V1.SearchRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Search performs a search.
      /// </summary>
      public virtual AsyncUnaryCall<global::Sajari.Api.Query.V1.SearchResponse> SearchAsync(global::Sajari.Api.Query.V1.SearchRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      protected override QueryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new QueryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(QueryBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Search, serviceImpl.Search).Build();
    }

  }
}
#endregion
