// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: sajari/bayes/trainingset/trainingset.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Sajari.Bayes.Trainingset {

  /// <summary>Holder for reflection information generated from sajari/bayes/trainingset/trainingset.proto</summary>
  public static partial class TrainingsetReflection {

    #region Descriptor
    /// <summary>File descriptor for sajari/bayes/trainingset/trainingset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainingsetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipzYWphcmkvYmF5ZXMvdHJhaW5pbmdzZXQvdHJhaW5pbmdzZXQucHJvdG8S",
            "GHNhamFyaS5iYXllcy50cmFpbmluZ3NldBoWc2FqYXJpL3JwYy9lbXB0eS5w",
            "cm90byI6Cg1VcGxvYWRSZXF1ZXN0EgwKBG5hbWUYASABKAkSDQoFY2xhc3MY",
            "AiABKAkSDAoEZGF0YRgDIAMoCSIeCg5VcGxvYWRSZXNwb25zZRIMCgRoYXNo",
            "GAEgASgJIh0KDUNyZWF0ZVJlcXVlc3QSDAoEbmFtZRgBIAEoCSIbCgtJbmZv",
            "UmVxdWVzdBIMCgRuYW1lGAEgASgJIh8KDEluZm9SZXNwb25zZRIPCgdjbGFz",
            "c2VzGAEgAygJIi4KD0FkZENsYXNzUmVxdWVzdBIMCgRuYW1lGAEgASgJEg0K",
            "BWNsYXNzGAIgASgJMtECCgtUcmFpbmluZ1NldBJbCgZVcGxvYWQSJy5zYWph",
            "cmkuYmF5ZXMudHJhaW5pbmdzZXQuVXBsb2FkUmVxdWVzdBooLnNhamFyaS5i",
            "YXllcy50cmFpbmluZ3NldC5VcGxvYWRSZXNwb25zZRJECgZDcmVhdGUSJy5z",
            "YWphcmkuYmF5ZXMudHJhaW5pbmdzZXQuQ3JlYXRlUmVxdWVzdBoRLnNhamFy",
            "aS5ycGMuRW1wdHkSVQoESW5mbxIlLnNhamFyaS5iYXllcy50cmFpbmluZ3Nl",
            "dC5JbmZvUmVxdWVzdBomLnNhamFyaS5iYXllcy50cmFpbmluZ3NldC5JbmZv",
            "UmVzcG9uc2USSAoIQWRkQ2xhc3MSKS5zYWphcmkuYmF5ZXMudHJhaW5pbmdz",
            "ZXQuQWRkQ2xhc3NSZXF1ZXN0GhEuc2FqYXJpLnJwYy5FbXB0eWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Sajari.Rpc.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.UploadRequest), global::Sajari.Bayes.Trainingset.UploadRequest.Parser, new[]{ "Name", "Class", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.UploadResponse), global::Sajari.Bayes.Trainingset.UploadResponse.Parser, new[]{ "Hash" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.CreateRequest), global::Sajari.Bayes.Trainingset.CreateRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.InfoRequest), global::Sajari.Bayes.Trainingset.InfoRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.InfoResponse), global::Sajari.Bayes.Trainingset.InfoResponse.Parser, new[]{ "Classes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sajari.Bayes.Trainingset.AddClassRequest), global::Sajari.Bayes.Trainingset.AddClassRequest.Parser, new[]{ "Name", "Class" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// UploadRequest encapsulates training data representing a document to add to the
  /// specified training set and class name
  /// </summary>
  public sealed partial class UploadRequest : pb::IMessage<UploadRequest> {
    private static readonly pb::MessageParser<UploadRequest> _parser = new pb::MessageParser<UploadRequest>(() => new UploadRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadRequest(UploadRequest other) : this() {
      name_ = other.name_;
      class_ = other.class_;
      data_ = other.data_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadRequest Clone() {
      return new UploadRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the training set
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "class" field.</summary>
    public const int ClassFieldNumber = 2;
    private string class_ = "";
    /// <summary>
    /// Class name to add the data to
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Class {
      get { return class_; }
      set {
        class_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_data_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> data_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Data represents the individual strings representing the input query to be
    /// classified. Normally these would represent words from text. It is the
    /// callers responsibility to stem and tokenise into an array of strings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Class != other.Class) return false;
      if(!data_.Equals(other.data_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Class.Length != 0) hash ^= Class.GetHashCode();
      hash ^= data_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Class.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Class);
      }
      data_.WriteTo(output, _repeated_data_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Class.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Class);
      }
      size += data_.CalculateSize(_repeated_data_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Class.Length != 0) {
        Class = other.Class;
      }
      data_.Add(other.data_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Class = input.ReadString();
            break;
          }
          case 26: {
            data_.AddEntriesFrom(input, _repeated_data_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// UploadResponse contains a unique hash for the uploaded data to prevent
  /// duplicate documents distorting the training set probabilities
  /// </summary>
  public sealed partial class UploadResponse : pb::IMessage<UploadResponse> {
    private static readonly pb::MessageParser<UploadResponse> _parser = new pb::MessageParser<UploadResponse>(() => new UploadResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UploadResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadResponse(UploadResponse other) : this() {
      hash_ = other.hash_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UploadResponse Clone() {
      return new UploadResponse(this);
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 1;
    private string hash_ = "";
    /// <summary>
    /// unique hash for the uploaded data
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UploadResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UploadResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hash != other.Hash) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Hash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Hash);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UploadResponse other) {
      if (other == null) {
        return;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// CreateRequest creates a new training set
  /// </summary>
  public sealed partial class CreateRequest : pb::IMessage<CreateRequest> {
    private static readonly pb::MessageParser<CreateRequest> _parser = new pb::MessageParser<CreateRequest>(() => new CreateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest(CreateRequest other) : this() {
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRequest Clone() {
      return new CreateRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the training set to create
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// InfoRequest gets information for a training set
  /// </summary>
  public sealed partial class InfoRequest : pb::IMessage<InfoRequest> {
    private static readonly pb::MessageParser<InfoRequest> _parser = new pb::MessageParser<InfoRequest>(() => new InfoRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InfoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoRequest(InfoRequest other) : this() {
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoRequest Clone() {
      return new InfoRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the training set to get information
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InfoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InfoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InfoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// InfoResponse returns information for a given training set
  /// </summary>
  public sealed partial class InfoResponse : pb::IMessage<InfoResponse> {
    private static readonly pb::MessageParser<InfoResponse> _parser = new pb::MessageParser<InfoResponse>(() => new InfoResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InfoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoResponse(InfoResponse other) : this() {
      classes_ = other.classes_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InfoResponse Clone() {
      return new InfoResponse(this);
    }

    /// <summary>Field number for the "classes" field.</summary>
    public const int ClassesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_classes_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> classes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// List of classes for the specified training set
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Classes {
      get { return classes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InfoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InfoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!classes_.Equals(other.classes_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= classes_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      classes_.WriteTo(output, _repeated_classes_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += classes_.CalculateSize(_repeated_classes_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InfoResponse other) {
      if (other == null) {
        return;
      }
      classes_.Add(other.classes_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            classes_.AddEntriesFrom(input, _repeated_classes_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// AddClassRequest creates a new class for the specified training set
  /// </summary>
  public sealed partial class AddClassRequest : pb::IMessage<AddClassRequest> {
    private static readonly pb::MessageParser<AddClassRequest> _parser = new pb::MessageParser<AddClassRequest>(() => new AddClassRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddClassRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sajari.Bayes.Trainingset.TrainingsetReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddClassRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddClassRequest(AddClassRequest other) : this() {
      name_ = other.name_;
      class_ = other.class_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddClassRequest Clone() {
      return new AddClassRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the training set to add the class to
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "class" field.</summary>
    public const int ClassFieldNumber = 2;
    private string class_ = "";
    /// <summary>
    /// Name of the class to add
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Class {
      get { return class_; }
      set {
        class_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddClassRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddClassRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Class != other.Class) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Class.Length != 0) hash ^= Class.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Class.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Class);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Class.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Class);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddClassRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Class.Length != 0) {
        Class = other.Class;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Class = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
