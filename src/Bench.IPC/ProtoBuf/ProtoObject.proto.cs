// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtoBuf/ProtoObject.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bench.IPC.ProtoBuf {

  /// <summary>Holder for reflection information generated from ProtoBuf/ProtoObject.proto</summary>
  public static partial class ProtoObjectReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtoBuf/ProtoObject.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoObjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b0J1Zi9Qcm90b09iamVjdC5wcm90byKOAQoPUGJJbnRlcm9wT2Jq",
            "ZWN0EioKBXByb3BzGAEgAygLMhsuUGJJbnRlcm9wT2JqZWN0LlByb3BzRW50",
            "cnkSEwoLQ29udGVudFR5cGUYAiABKAkSDAoERGF0YRgDIAEoDBosCgpQcm9w",
            "c0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFCFaoCEkJl",
            "bmNoLklQQy5Qcm90b0J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bench.IPC.ProtoBuf.PbInteropObject), global::Bench.IPC.ProtoBuf.PbInteropObject.Parser, new[]{ "Props", "ContentType", "Data" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PbInteropObject : pb::IMessage<PbInteropObject> {
    private static readonly pb::MessageParser<PbInteropObject> _parser = new pb::MessageParser<PbInteropObject>(() => new PbInteropObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PbInteropObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bench.IPC.ProtoBuf.ProtoObjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbInteropObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbInteropObject(PbInteropObject other) : this() {
      props_ = other.props_.Clone();
      contentType_ = other.contentType_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbInteropObject Clone() {
      return new PbInteropObject(this);
    }

    /// <summary>Field number for the "props" field.</summary>
    public const int PropsFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_props_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> props_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Props {
      get { return props_; }
    }

    /// <summary>Field number for the "ContentType" field.</summary>
    public const int ContentTypeFieldNumber = 2;
    private string contentType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 3;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PbInteropObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PbInteropObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Props.Equals(other.Props)) return false;
      if (ContentType != other.ContentType) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Props.GetHashCode();
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      props_.WriteTo(output, _map_props_codec);
      if (ContentType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ContentType);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += props_.CalculateSize(_map_props_codec);
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PbInteropObject other) {
      if (other == null) {
        return;
      }
      props_.Add(other.props_);
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            props_.AddEntriesFrom(input, _map_props_codec);
            break;
          }
          case 18: {
            ContentType = input.ReadString();
            break;
          }
          case 26: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
