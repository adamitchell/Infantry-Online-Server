// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace db.packets
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ModQuery : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static ModQuery GetRootAsModQuery(ByteBuffer _bb) { return GetRootAsModQuery(_bb, new ModQuery()); }
  public static ModQuery GetRootAsModQuery(ByteBuffer _bb, ModQuery obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyModQuery(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, ModQueryVerify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ModQuery __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int MsgId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int QueryType { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Sender { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSenderBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSenderBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSenderArray() { return __p.__vector_as_array<byte>(8); }
  public string Query { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetQueryBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetQueryBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetQueryArray() { return __p.__vector_as_array<byte>(10); }
  public string AliasTo { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAliasToBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetAliasToBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetAliasToArray() { return __p.__vector_as_array<byte>(12); }
  public int Level { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<db.packets.ModQuery> CreateModQuery(FlatBufferBuilder builder,
      int msg_id = 0,
      int query_type = 0,
      StringOffset senderOffset = default(StringOffset),
      StringOffset queryOffset = default(StringOffset),
      StringOffset alias_toOffset = default(StringOffset),
      int level = 0) {
    builder.StartTable(6);
    ModQuery.AddLevel(builder, level);
    ModQuery.AddAliasTo(builder, alias_toOffset);
    ModQuery.AddQuery(builder, queryOffset);
    ModQuery.AddSender(builder, senderOffset);
    ModQuery.AddQueryType(builder, query_type);
    ModQuery.AddMsgId(builder, msg_id);
    return ModQuery.EndModQuery(builder);
  }

  public static void StartModQuery(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddMsgId(FlatBufferBuilder builder, int msgId) { builder.AddInt(0, msgId, 0); }
  public static void AddQueryType(FlatBufferBuilder builder, int queryType) { builder.AddInt(1, queryType, 0); }
  public static void AddSender(FlatBufferBuilder builder, StringOffset senderOffset) { builder.AddOffset(2, senderOffset.Value, 0); }
  public static void AddQuery(FlatBufferBuilder builder, StringOffset queryOffset) { builder.AddOffset(3, queryOffset.Value, 0); }
  public static void AddAliasTo(FlatBufferBuilder builder, StringOffset aliasToOffset) { builder.AddOffset(4, aliasToOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(5, level, 0); }
  public static Offset<db.packets.ModQuery> EndModQuery(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<db.packets.ModQuery>(o);
  }
  public static void FinishModQueryBuffer(FlatBufferBuilder builder, Offset<db.packets.ModQuery> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedModQueryBuffer(FlatBufferBuilder builder, Offset<db.packets.ModQuery> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class ModQueryVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MsgId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*QueryType*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Sender*/, false)
      && verifier.VerifyString(tablePos, 10 /*Query*/, false)
      && verifier.VerifyString(tablePos, 12 /*AliasTo*/, false)
      && verifier.VerifyField(tablePos, 14 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
