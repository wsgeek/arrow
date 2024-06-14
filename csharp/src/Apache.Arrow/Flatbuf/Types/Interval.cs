// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Apache.Arrow.Flatbuf
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

internal struct Interval : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_9(); }
  public static Interval GetRootAsInterval(ByteBuffer _bb) { return GetRootAsInterval(_bb, new Interval()); }
  public static Interval GetRootAsInterval(ByteBuffer _bb, Interval obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Interval __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public IntervalUnit Unit { get { int o = __p.__offset(4); return o != 0 ? (IntervalUnit)__p.bb.GetShort(o + __p.bb_pos) : IntervalUnit.YEAR_MONTH; } }

  public static Offset<Interval> CreateInterval(FlatBufferBuilder builder,
      IntervalUnit unit = IntervalUnit.YEAR_MONTH) {
    builder.StartTable(1);
    Interval.AddUnit(builder, unit);
    return Interval.EndInterval(builder);
  }

  public static void StartInterval(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddUnit(FlatBufferBuilder builder, IntervalUnit unit) { builder.AddShort(0, (short)unit, 0); }
  public static Offset<Interval> EndInterval(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Interval>(o);
  }
}


static internal class IntervalVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Unit*/, 2 /*IntervalUnit*/, 2, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
