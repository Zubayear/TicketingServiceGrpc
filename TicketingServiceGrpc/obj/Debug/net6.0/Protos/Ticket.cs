// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ticket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TicketingServiceGrpc {

  /// <summary>Holder for reflection information generated from Protos/ticket.proto</summary>
  public static partial class TicketReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ticket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TicketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3MvdGlja2V0LnByb3RvEgZ0aWNrZXQiSQoNVGlja2V0UmVxdWVz",
            "dBISCgp0aWNrZXROYW1lGAEgASgJEhMKC3RpY2tldFByaWNlGAIgASgCEg8K",
            "B3N0YWRpdW0YAyABKAkiRwoLVGlja2V0UmVwbHkSEgoKdGlja2V0TmFtZRgB",
            "IAEoCRITCgt0aWNrZXRQcmljZRgCIAEoAhIPCgdzdGFkaXVtGAMgASgJMkQK",
            "BlRpY2tldBI6CgxDcmVhdGVUaWNrZXQSFS50aWNrZXQuVGlja2V0UmVxdWVz",
            "dBoTLnRpY2tldC5UaWNrZXRSZXBseUIXqgIUVGlja2V0aW5nU2VydmljZUdy",
            "cGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TicketingServiceGrpc.TicketRequest), global::TicketingServiceGrpc.TicketRequest.Parser, new[]{ "TicketName", "TicketPrice", "Stadium" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TicketingServiceGrpc.TicketReply), global::TicketingServiceGrpc.TicketReply.Parser, new[]{ "TicketName", "TicketPrice", "Stadium" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TicketRequest : pb::IMessage<TicketRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TicketRequest> _parser = new pb::MessageParser<TicketRequest>(() => new TicketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TicketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TicketingServiceGrpc.TicketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketRequest(TicketRequest other) : this() {
      ticketName_ = other.ticketName_;
      ticketPrice_ = other.ticketPrice_;
      stadium_ = other.stadium_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketRequest Clone() {
      return new TicketRequest(this);
    }

    /// <summary>Field number for the "ticketName" field.</summary>
    public const int TicketNameFieldNumber = 1;
    private string ticketName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TicketName {
      get { return ticketName_; }
      set {
        ticketName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ticketPrice" field.</summary>
    public const int TicketPriceFieldNumber = 2;
    private float ticketPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TicketPrice {
      get { return ticketPrice_; }
      set {
        ticketPrice_ = value;
      }
    }

    /// <summary>Field number for the "stadium" field.</summary>
    public const int StadiumFieldNumber = 3;
    private string stadium_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Stadium {
      get { return stadium_; }
      set {
        stadium_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TicketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TicketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TicketName != other.TicketName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TicketPrice, other.TicketPrice)) return false;
      if (Stadium != other.Stadium) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TicketName.Length != 0) hash ^= TicketName.GetHashCode();
      if (TicketPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TicketPrice);
      if (Stadium.Length != 0) hash ^= Stadium.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TicketName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TicketName);
      }
      if (TicketPrice != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TicketPrice);
      }
      if (Stadium.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Stadium);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TicketName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TicketName);
      }
      if (TicketPrice != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TicketPrice);
      }
      if (Stadium.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Stadium);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TicketName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TicketName);
      }
      if (TicketPrice != 0F) {
        size += 1 + 4;
      }
      if (Stadium.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Stadium);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TicketRequest other) {
      if (other == null) {
        return;
      }
      if (other.TicketName.Length != 0) {
        TicketName = other.TicketName;
      }
      if (other.TicketPrice != 0F) {
        TicketPrice = other.TicketPrice;
      }
      if (other.Stadium.Length != 0) {
        Stadium = other.Stadium;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TicketName = input.ReadString();
            break;
          }
          case 21: {
            TicketPrice = input.ReadFloat();
            break;
          }
          case 26: {
            Stadium = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            TicketName = input.ReadString();
            break;
          }
          case 21: {
            TicketPrice = input.ReadFloat();
            break;
          }
          case 26: {
            Stadium = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TicketReply : pb::IMessage<TicketReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TicketReply> _parser = new pb::MessageParser<TicketReply>(() => new TicketReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TicketReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TicketingServiceGrpc.TicketReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketReply(TicketReply other) : this() {
      ticketName_ = other.ticketName_;
      ticketPrice_ = other.ticketPrice_;
      stadium_ = other.stadium_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TicketReply Clone() {
      return new TicketReply(this);
    }

    /// <summary>Field number for the "ticketName" field.</summary>
    public const int TicketNameFieldNumber = 1;
    private string ticketName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TicketName {
      get { return ticketName_; }
      set {
        ticketName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ticketPrice" field.</summary>
    public const int TicketPriceFieldNumber = 2;
    private float ticketPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TicketPrice {
      get { return ticketPrice_; }
      set {
        ticketPrice_ = value;
      }
    }

    /// <summary>Field number for the "stadium" field.</summary>
    public const int StadiumFieldNumber = 3;
    private string stadium_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Stadium {
      get { return stadium_; }
      set {
        stadium_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TicketReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TicketReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TicketName != other.TicketName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TicketPrice, other.TicketPrice)) return false;
      if (Stadium != other.Stadium) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TicketName.Length != 0) hash ^= TicketName.GetHashCode();
      if (TicketPrice != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TicketPrice);
      if (Stadium.Length != 0) hash ^= Stadium.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TicketName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TicketName);
      }
      if (TicketPrice != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TicketPrice);
      }
      if (Stadium.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Stadium);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TicketName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TicketName);
      }
      if (TicketPrice != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TicketPrice);
      }
      if (Stadium.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Stadium);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TicketName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TicketName);
      }
      if (TicketPrice != 0F) {
        size += 1 + 4;
      }
      if (Stadium.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Stadium);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TicketReply other) {
      if (other == null) {
        return;
      }
      if (other.TicketName.Length != 0) {
        TicketName = other.TicketName;
      }
      if (other.TicketPrice != 0F) {
        TicketPrice = other.TicketPrice;
      }
      if (other.Stadium.Length != 0) {
        Stadium = other.Stadium;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TicketName = input.ReadString();
            break;
          }
          case 21: {
            TicketPrice = input.ReadFloat();
            break;
          }
          case 26: {
            Stadium = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            TicketName = input.ReadString();
            break;
          }
          case 21: {
            TicketPrice = input.ReadFloat();
            break;
          }
          case 26: {
            Stadium = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
