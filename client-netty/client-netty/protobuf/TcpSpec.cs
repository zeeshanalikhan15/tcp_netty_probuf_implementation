// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tcp_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from tcp_spec.proto</summary>
public static partial class TcpSpecReflection {

  #region Descriptor
  /// <summary>File descriptor for tcp_spec.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TcpSpecReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg50Y3Bfc3BlYy5wcm90byJNCglNUU1lc3NhZ2USIAoLYWdlbnRfZXZlbnQY",
          "ZCABKAsyCy5BZ2VudEV2ZW50Eh4KCmNhbGxfZXZlbnQYZSABKAsyCi5DYWxs",
          "RXZlbnQiZAoKQWdlbnRFdmVudBIeCgpldmVudF90eXBlGAEgASgOMgouRXZl",
          "bnRUeXBlEhAKCGFnZW50X2lkGAIgASgJEhAKCHNraWxsX2lkGAMgASgJEhIK",
          "CmV2ZW50X3RpbWUYBCABKAMizQEKCUNhbGxFdmVudBIeCgpldmVudF90eXBl",
          "GAEgASgOMgouRXZlbnRUeXBlEhQKDGFiYW5kb25fdGltZRgCIAEoAxIPCgdj",
          "YWxsX2lkGAMgASgJEhYKDmNvbm5lY3RlZF90aW1lGAQgASgDEhkKEWRpc2Nv",
          "bm5lY3RlZF90aW1lGAUgASgDEhUKDWNhbGxlcl9udW1iZXIYBiABKAkSCwoD",
          "dmRuGAcgASgJEhAKCHNraWxsX2lkGAggASgJEhAKCGFnZW50X2lkGAkgASgJ",
          "KnkKCUV2ZW50VHlwZRIPCgtBR0VOVF9MT0dJThAAEhAKDEFHRU5UX0xPR09V",
          "VBABEg4KCkFHRU5UX0JVU1kQAhIOCgpBR0VOVF9GUkVFEAMSEgoOQ0FMTF9D",
          "T05ORUNURUQQBBIVChFDQUxMX0RJU0NPTk5FQ1RFRBAFYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EventType), }, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MQMessage), global::MQMessage.Parser, new[]{ "AgentEvent", "CallEvent" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AgentEvent), global::AgentEvent.Parser, new[]{ "EventType", "AgentId", "SkillId", "EventTime" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::CallEvent), global::CallEvent.Parser, new[]{ "EventType", "AbandonTime", "CallId", "ConnectedTime", "DisconnectedTime", "CallerNumber", "Vdn", "SkillId", "AgentId" }, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum EventType {
  /// <summary>
  /// agent events
  /// </summary>
  [pbr::OriginalName("AGENT_LOGIN")] AgentLogin = 0,
  [pbr::OriginalName("AGENT_LOGOUT")] AgentLogout = 1,
  [pbr::OriginalName("AGENT_BUSY")] AgentBusy = 2,
  [pbr::OriginalName("AGENT_FREE")] AgentFree = 3,
  /// <summary>
  /// call events
  /// </summary>
  [pbr::OriginalName("CALL_CONNECTED")] CallConnected = 4,
  [pbr::OriginalName("CALL_DISCONNECTED")] CallDisconnected = 5,
}

#endregion

#region Messages
public sealed partial class MQMessage : pb::IMessage<MQMessage> {
  private static readonly pb::MessageParser<MQMessage> _parser = new pb::MessageParser<MQMessage>(() => new MQMessage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MQMessage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TcpSpecReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MQMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MQMessage(MQMessage other) : this() {
    agentEvent_ = other.agentEvent_ != null ? other.agentEvent_.Clone() : null;
    callEvent_ = other.callEvent_ != null ? other.callEvent_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MQMessage Clone() {
    return new MQMessage(this);
  }

  /// <summary>Field number for the "agent_event" field.</summary>
  public const int AgentEventFieldNumber = 100;
  private global::AgentEvent agentEvent_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::AgentEvent AgentEvent {
    get { return agentEvent_; }
    set {
      agentEvent_ = value;
    }
  }

  /// <summary>Field number for the "call_event" field.</summary>
  public const int CallEventFieldNumber = 101;
  private global::CallEvent callEvent_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::CallEvent CallEvent {
    get { return callEvent_; }
    set {
      callEvent_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MQMessage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MQMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(AgentEvent, other.AgentEvent)) return false;
    if (!object.Equals(CallEvent, other.CallEvent)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (agentEvent_ != null) hash ^= AgentEvent.GetHashCode();
    if (callEvent_ != null) hash ^= CallEvent.GetHashCode();
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
    if (agentEvent_ != null) {
      output.WriteRawTag(162, 6);
      output.WriteMessage(AgentEvent);
    }
    if (callEvent_ != null) {
      output.WriteRawTag(170, 6);
      output.WriteMessage(CallEvent);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (agentEvent_ != null) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(AgentEvent);
    }
    if (callEvent_ != null) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(CallEvent);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MQMessage other) {
    if (other == null) {
      return;
    }
    if (other.agentEvent_ != null) {
      if (agentEvent_ == null) {
        agentEvent_ = new global::AgentEvent();
      }
      AgentEvent.MergeFrom(other.AgentEvent);
    }
    if (other.callEvent_ != null) {
      if (callEvent_ == null) {
        callEvent_ = new global::CallEvent();
      }
      CallEvent.MergeFrom(other.CallEvent);
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
        case 802: {
          if (agentEvent_ == null) {
            agentEvent_ = new global::AgentEvent();
          }
          input.ReadMessage(agentEvent_);
          break;
        }
        case 810: {
          if (callEvent_ == null) {
            callEvent_ = new global::CallEvent();
          }
          input.ReadMessage(callEvent_);
          break;
        }
      }
    }
  }

}

public sealed partial class AgentEvent : pb::IMessage<AgentEvent> {
  private static readonly pb::MessageParser<AgentEvent> _parser = new pb::MessageParser<AgentEvent>(() => new AgentEvent());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AgentEvent> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TcpSpecReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentEvent() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentEvent(AgentEvent other) : this() {
    eventType_ = other.eventType_;
    agentId_ = other.agentId_;
    skillId_ = other.skillId_;
    eventTime_ = other.eventTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AgentEvent Clone() {
    return new AgentEvent(this);
  }

  /// <summary>Field number for the "event_type" field.</summary>
  public const int EventTypeFieldNumber = 1;
  private global::EventType eventType_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::EventType EventType {
    get { return eventType_; }
    set {
      eventType_ = value;
    }
  }

  /// <summary>Field number for the "agent_id" field.</summary>
  public const int AgentIdFieldNumber = 2;
  private string agentId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string AgentId {
    get { return agentId_; }
    set {
      agentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "skill_id" field.</summary>
  public const int SkillIdFieldNumber = 3;
  private string skillId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string SkillId {
    get { return skillId_; }
    set {
      skillId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "event_time" field.</summary>
  public const int EventTimeFieldNumber = 4;
  private long eventTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long EventTime {
    get { return eventTime_; }
    set {
      eventTime_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AgentEvent);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AgentEvent other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EventType != other.EventType) return false;
    if (AgentId != other.AgentId) return false;
    if (SkillId != other.SkillId) return false;
    if (EventTime != other.EventTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (EventType != 0) hash ^= EventType.GetHashCode();
    if (AgentId.Length != 0) hash ^= AgentId.GetHashCode();
    if (SkillId.Length != 0) hash ^= SkillId.GetHashCode();
    if (EventTime != 0L) hash ^= EventTime.GetHashCode();
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
    if (EventType != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) EventType);
    }
    if (AgentId.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(AgentId);
    }
    if (SkillId.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(SkillId);
    }
    if (EventTime != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(EventTime);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (EventType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
    }
    if (AgentId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(AgentId);
    }
    if (SkillId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(SkillId);
    }
    if (EventTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(EventTime);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AgentEvent other) {
    if (other == null) {
      return;
    }
    if (other.EventType != 0) {
      EventType = other.EventType;
    }
    if (other.AgentId.Length != 0) {
      AgentId = other.AgentId;
    }
    if (other.SkillId.Length != 0) {
      SkillId = other.SkillId;
    }
    if (other.EventTime != 0L) {
      EventTime = other.EventTime;
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
        case 8: {
          eventType_ = (global::EventType) input.ReadEnum();
          break;
        }
        case 18: {
          AgentId = input.ReadString();
          break;
        }
        case 26: {
          SkillId = input.ReadString();
          break;
        }
        case 32: {
          EventTime = input.ReadInt64();
          break;
        }
      }
    }
  }

}

public sealed partial class CallEvent : pb::IMessage<CallEvent> {
  private static readonly pb::MessageParser<CallEvent> _parser = new pb::MessageParser<CallEvent>(() => new CallEvent());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<CallEvent> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TcpSpecReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CallEvent() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CallEvent(CallEvent other) : this() {
    eventType_ = other.eventType_;
    abandonTime_ = other.abandonTime_;
    callId_ = other.callId_;
    connectedTime_ = other.connectedTime_;
    disconnectedTime_ = other.disconnectedTime_;
    callerNumber_ = other.callerNumber_;
    vdn_ = other.vdn_;
    skillId_ = other.skillId_;
    agentId_ = other.agentId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CallEvent Clone() {
    return new CallEvent(this);
  }

  /// <summary>Field number for the "event_type" field.</summary>
  public const int EventTypeFieldNumber = 1;
  private global::EventType eventType_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::EventType EventType {
    get { return eventType_; }
    set {
      eventType_ = value;
    }
  }

  /// <summary>Field number for the "abandon_time" field.</summary>
  public const int AbandonTimeFieldNumber = 2;
  private long abandonTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long AbandonTime {
    get { return abandonTime_; }
    set {
      abandonTime_ = value;
    }
  }

  /// <summary>Field number for the "call_id" field.</summary>
  public const int CallIdFieldNumber = 3;
  private string callId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string CallId {
    get { return callId_; }
    set {
      callId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "connected_time" field.</summary>
  public const int ConnectedTimeFieldNumber = 4;
  private long connectedTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long ConnectedTime {
    get { return connectedTime_; }
    set {
      connectedTime_ = value;
    }
  }

  /// <summary>Field number for the "disconnected_time" field.</summary>
  public const int DisconnectedTimeFieldNumber = 5;
  private long disconnectedTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long DisconnectedTime {
    get { return disconnectedTime_; }
    set {
      disconnectedTime_ = value;
    }
  }

  /// <summary>Field number for the "caller_number" field.</summary>
  public const int CallerNumberFieldNumber = 6;
  private string callerNumber_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string CallerNumber {
    get { return callerNumber_; }
    set {
      callerNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "vdn" field.</summary>
  public const int VdnFieldNumber = 7;
  private string vdn_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Vdn {
    get { return vdn_; }
    set {
      vdn_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "skill_id" field.</summary>
  public const int SkillIdFieldNumber = 8;
  private string skillId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string SkillId {
    get { return skillId_; }
    set {
      skillId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "agent_id" field.</summary>
  public const int AgentIdFieldNumber = 9;
  private string agentId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string AgentId {
    get { return agentId_; }
    set {
      agentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as CallEvent);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(CallEvent other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EventType != other.EventType) return false;
    if (AbandonTime != other.AbandonTime) return false;
    if (CallId != other.CallId) return false;
    if (ConnectedTime != other.ConnectedTime) return false;
    if (DisconnectedTime != other.DisconnectedTime) return false;
    if (CallerNumber != other.CallerNumber) return false;
    if (Vdn != other.Vdn) return false;
    if (SkillId != other.SkillId) return false;
    if (AgentId != other.AgentId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (EventType != 0) hash ^= EventType.GetHashCode();
    if (AbandonTime != 0L) hash ^= AbandonTime.GetHashCode();
    if (CallId.Length != 0) hash ^= CallId.GetHashCode();
    if (ConnectedTime != 0L) hash ^= ConnectedTime.GetHashCode();
    if (DisconnectedTime != 0L) hash ^= DisconnectedTime.GetHashCode();
    if (CallerNumber.Length != 0) hash ^= CallerNumber.GetHashCode();
    if (Vdn.Length != 0) hash ^= Vdn.GetHashCode();
    if (SkillId.Length != 0) hash ^= SkillId.GetHashCode();
    if (AgentId.Length != 0) hash ^= AgentId.GetHashCode();
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
    if (EventType != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) EventType);
    }
    if (AbandonTime != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(AbandonTime);
    }
    if (CallId.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(CallId);
    }
    if (ConnectedTime != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(ConnectedTime);
    }
    if (DisconnectedTime != 0L) {
      output.WriteRawTag(40);
      output.WriteInt64(DisconnectedTime);
    }
    if (CallerNumber.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(CallerNumber);
    }
    if (Vdn.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Vdn);
    }
    if (SkillId.Length != 0) {
      output.WriteRawTag(66);
      output.WriteString(SkillId);
    }
    if (AgentId.Length != 0) {
      output.WriteRawTag(74);
      output.WriteString(AgentId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (EventType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
    }
    if (AbandonTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(AbandonTime);
    }
    if (CallId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(CallId);
    }
    if (ConnectedTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(ConnectedTime);
    }
    if (DisconnectedTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(DisconnectedTime);
    }
    if (CallerNumber.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(CallerNumber);
    }
    if (Vdn.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Vdn);
    }
    if (SkillId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(SkillId);
    }
    if (AgentId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(AgentId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(CallEvent other) {
    if (other == null) {
      return;
    }
    if (other.EventType != 0) {
      EventType = other.EventType;
    }
    if (other.AbandonTime != 0L) {
      AbandonTime = other.AbandonTime;
    }
    if (other.CallId.Length != 0) {
      CallId = other.CallId;
    }
    if (other.ConnectedTime != 0L) {
      ConnectedTime = other.ConnectedTime;
    }
    if (other.DisconnectedTime != 0L) {
      DisconnectedTime = other.DisconnectedTime;
    }
    if (other.CallerNumber.Length != 0) {
      CallerNumber = other.CallerNumber;
    }
    if (other.Vdn.Length != 0) {
      Vdn = other.Vdn;
    }
    if (other.SkillId.Length != 0) {
      SkillId = other.SkillId;
    }
    if (other.AgentId.Length != 0) {
      AgentId = other.AgentId;
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
        case 8: {
          eventType_ = (global::EventType) input.ReadEnum();
          break;
        }
        case 16: {
          AbandonTime = input.ReadInt64();
          break;
        }
        case 26: {
          CallId = input.ReadString();
          break;
        }
        case 32: {
          ConnectedTime = input.ReadInt64();
          break;
        }
        case 40: {
          DisconnectedTime = input.ReadInt64();
          break;
        }
        case 50: {
          CallerNumber = input.ReadString();
          break;
        }
        case 58: {
          Vdn = input.ReadString();
          break;
        }
        case 66: {
          SkillId = input.ReadString();
          break;
        }
        case 74: {
          AgentId = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
