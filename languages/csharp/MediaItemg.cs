// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: media/MediaItem.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from media/MediaItem.proto</summary>
public static partial class MediaItemReflection {

  #region Descriptor
  /// <summary>File descriptor for media/MediaItem.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MediaItemReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVtZWRpYS9NZWRpYUl0ZW0ucHJvdG8aFG1lZGlhL01lZGlhS2V5LnByb3Rv",
          "GhVtZWRpYS9NZWRpYVR5cGUucHJvdG8iSwoJTWVkaWFJdGVtEhYKA2tleRgB",
          "IAEoCzIJLk1lZGlhS2V5EhgKBHR5cGUYAiABKAsyCi5NZWRpYVR5cGUSDAoE",
          "bmFtZRgDIAEoCUIwChhpby5ibG9vbWJveC5zY2hlbWEubWVkaWFCDUF0dGFj",
          "aGVkTWVkaWFIAVAB+AEBYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MediaKeyReflection.Descriptor, global::MediaTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MediaItem), global::MediaItem.Parser, new[]{ "Key", "Type", "Name" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class MediaItem : pb::IMessage<MediaItem> {
  private static readonly pb::MessageParser<MediaItem> _parser = new pb::MessageParser<MediaItem>(() => new MediaItem());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MediaItem> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MediaItemReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MediaItem() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MediaItem(MediaItem other) : this() {
    Key = other.key_ != null ? other.Key.Clone() : null;
    Type = other.type_ != null ? other.Type.Clone() : null;
    name_ = other.name_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MediaItem Clone() {
    return new MediaItem(this);
  }

  /// <summary>Field number for the "key" field.</summary>
  public const int KeyFieldNumber = 1;
  private global::MediaKey key_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MediaKey Key {
    get { return key_; }
    set {
      key_ = value;
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 2;
  private global::MediaType type_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MediaType Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 3;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MediaItem);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MediaItem other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Key, other.Key)) return false;
    if (!object.Equals(Type, other.Type)) return false;
    if (Name != other.Name) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (key_ != null) hash ^= Key.GetHashCode();
    if (type_ != null) hash ^= Type.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (key_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Key);
    }
    if (type_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Type);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Name);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (key_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Key);
    }
    if (type_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Type);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MediaItem other) {
    if (other == null) {
      return;
    }
    if (other.key_ != null) {
      if (key_ == null) {
        key_ = new global::MediaKey();
      }
      Key.MergeFrom(other.Key);
    }
    if (other.type_ != null) {
      if (type_ == null) {
        type_ = new global::MediaType();
      }
      Type.MergeFrom(other.Type);
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
          if (key_ == null) {
            key_ = new global::MediaKey();
          }
          input.ReadMessage(key_);
          break;
        }
        case 18: {
          if (type_ == null) {
            type_ = new global::MediaType();
          }
          input.ReadMessage(type_);
          break;
        }
        case 26: {
          Name = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code