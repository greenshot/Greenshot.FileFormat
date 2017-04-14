// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Style.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Greenshot.FileFormat.Proto {

  /// <summary>Holder for reflection information generated from Style.proto</summary>
  public static partial class StyleReflection {

    #region Descriptor
    /// <summary>File descriptor for Style.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StyleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtTdHlsZS5wcm90bxIaZ3JlZW5zaG90LmZpbGVmb3JtYXQucHJvdG8iQAoF",
            "Q29sb3ISCwoDcmVkGAEgASgNEg0KBWdyZWVuGAIgASgNEgwKBGJsdWUYAyAB",
            "KA0SDQoFYWxwaGEYBCABKA0ioAEKCEZvbnRJbmZvEg4KBmZhbWlseRgBIAEo",
            "CRI5Cglmb250U3R5bGUYAiABKA4yJi5ncmVlbnNob3QuZmlsZWZvcm1hdC5w",
            "cm90by5Gb250U3R5bGVzEgwKBHNpemUYAyABKA0SOwoIc2l6ZVVuaXQYBCAB",
            "KA4yKS5ncmVlbnNob3QuZmlsZWZvcm1hdC5wcm90by5Gb250U2l6ZVVuaXRz",
            "IjYKBk1hdHJpeBIMCgRyb3dzGAEgASgNEgwKBGNvbHMYAiABKA0SEAoEZGF0",
            "YRgDIAMoAUICEAEqTQoKRm9udFN0eWxlcxILCgdSZWd1bGFyEAASCAoEQm9s",
            "ZBABEgoKBkl0YWxpYxACEg0KCVVuZGVybGluZRAEEg0KCVN0cmlrZW91dBAI",
            "KjAKDUZvbnRTaXplVW5pdHMSCgoGUGl4ZWxzEAASCgoGUG9pbnRzEAISBwoD",
            "RW1zEAEqKwoJQWxpZ25tZW50EgkKBVN0YXJ0EAASCgoGTWlkZGxlEAESBwoD",
            "RW5kEAJCHaoCGkdyZWVuc2hvdC5GaWxlRm9ybWF0LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Greenshot.FileFormat.Proto.FontStyles), typeof(global::Greenshot.FileFormat.Proto.FontSizeUnits), typeof(global::Greenshot.FileFormat.Proto.Alignment), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Greenshot.FileFormat.Proto.Color), global::Greenshot.FileFormat.Proto.Color.Parser, new[]{ "Red", "Green", "Blue", "Alpha" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greenshot.FileFormat.Proto.FontInfo), global::Greenshot.FileFormat.Proto.FontInfo.Parser, new[]{ "Family", "FontStyle", "Size", "SizeUnit" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Greenshot.FileFormat.Proto.Matrix), global::Greenshot.FileFormat.Proto.Matrix.Parser, new[]{ "Rows", "Cols", "Data" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  //// Defines the style of the font
  /// </summary>
  public enum FontStyles {
    [pbr::OriginalName("Regular")] Regular = 0,
    [pbr::OriginalName("Bold")] Bold = 1,
    [pbr::OriginalName("Italic")] Italic = 2,
    [pbr::OriginalName("Underline")] Underline = 4,
    [pbr::OriginalName("Strikeout")] Strikeout = 8,
  }

  /// <summary>
  //// Defines the way how the size of the font should be interpreted
  /// </summary>
  public enum FontSizeUnits {
    [pbr::OriginalName("Pixels")] Pixels = 0,
    [pbr::OriginalName("Points")] Points = 2,
    [pbr::OriginalName("Ems")] Ems = 1,
  }

  /// <summary>
  /// Alignment, without horizontal or vertical
  /// </summary>
  public enum Alignment {
    [pbr::OriginalName("Start")] Start = 0,
    [pbr::OriginalName("Middle")] Middle = 1,
    [pbr::OriginalName("End")] End = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  //// Defines a color
  /// </summary>
  public sealed partial class Color : pb::IMessage<Color> {
    private static readonly pb::MessageParser<Color> _parser = new pb::MessageParser<Color>(() => new Color());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Color> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greenshot.FileFormat.Proto.StyleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color(Color other) : this() {
      red_ = other.red_;
      green_ = other.green_;
      blue_ = other.blue_;
      alpha_ = other.alpha_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color Clone() {
      return new Color(this);
    }

    /// <summary>Field number for the "red" field.</summary>
    public const int RedFieldNumber = 1;
    private uint red_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Red {
      get { return red_; }
      set {
        red_ = value;
      }
    }

    /// <summary>Field number for the "green" field.</summary>
    public const int GreenFieldNumber = 2;
    private uint green_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Green {
      get { return green_; }
      set {
        green_ = value;
      }
    }

    /// <summary>Field number for the "blue" field.</summary>
    public const int BlueFieldNumber = 3;
    private uint blue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Blue {
      get { return blue_; }
      set {
        blue_ = value;
      }
    }

    /// <summary>Field number for the "alpha" field.</summary>
    public const int AlphaFieldNumber = 4;
    private uint alpha_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Alpha {
      get { return alpha_; }
      set {
        alpha_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Color);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Color other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Red != other.Red) return false;
      if (Green != other.Green) return false;
      if (Blue != other.Blue) return false;
      if (Alpha != other.Alpha) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Red != 0) hash ^= Red.GetHashCode();
      if (Green != 0) hash ^= Green.GetHashCode();
      if (Blue != 0) hash ^= Blue.GetHashCode();
      if (Alpha != 0) hash ^= Alpha.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Red != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Red);
      }
      if (Green != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Green);
      }
      if (Blue != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Blue);
      }
      if (Alpha != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Alpha);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Red != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Red);
      }
      if (Green != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Green);
      }
      if (Blue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Blue);
      }
      if (Alpha != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Alpha);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Color other) {
      if (other == null) {
        return;
      }
      if (other.Red != 0) {
        Red = other.Red;
      }
      if (other.Green != 0) {
        Green = other.Green;
      }
      if (other.Blue != 0) {
        Blue = other.Blue;
      }
      if (other.Alpha != 0) {
        Alpha = other.Alpha;
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
          case 8: {
            Red = input.ReadUInt32();
            break;
          }
          case 16: {
            Green = input.ReadUInt32();
            break;
          }
          case 24: {
            Blue = input.ReadUInt32();
            break;
          }
          case 32: {
            Alpha = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  //// Describes everything to know about a font
  /// </summary>
  public sealed partial class FontInfo : pb::IMessage<FontInfo> {
    private static readonly pb::MessageParser<FontInfo> _parser = new pb::MessageParser<FontInfo>(() => new FontInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FontInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greenshot.FileFormat.Proto.StyleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FontInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FontInfo(FontInfo other) : this() {
      family_ = other.family_;
      fontStyle_ = other.fontStyle_;
      size_ = other.size_;
      sizeUnit_ = other.sizeUnit_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FontInfo Clone() {
      return new FontInfo(this);
    }

    /// <summary>Field number for the "family" field.</summary>
    public const int FamilyFieldNumber = 1;
    private string family_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Family {
      get { return family_; }
      set {
        family_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fontStyle" field.</summary>
    public const int FontStyleFieldNumber = 2;
    private global::Greenshot.FileFormat.Proto.FontStyles fontStyle_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Greenshot.FileFormat.Proto.FontStyles FontStyle {
      get { return fontStyle_; }
      set {
        fontStyle_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 3;
    private uint size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "sizeUnit" field.</summary>
    public const int SizeUnitFieldNumber = 4;
    private global::Greenshot.FileFormat.Proto.FontSizeUnits sizeUnit_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Greenshot.FileFormat.Proto.FontSizeUnits SizeUnit {
      get { return sizeUnit_; }
      set {
        sizeUnit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FontInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FontInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Family != other.Family) return false;
      if (FontStyle != other.FontStyle) return false;
      if (Size != other.Size) return false;
      if (SizeUnit != other.SizeUnit) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Family.Length != 0) hash ^= Family.GetHashCode();
      if (FontStyle != 0) hash ^= FontStyle.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
      if (SizeUnit != 0) hash ^= SizeUnit.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Family.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Family);
      }
      if (FontStyle != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FontStyle);
      }
      if (Size != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Size);
      }
      if (SizeUnit != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SizeUnit);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Family.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Family);
      }
      if (FontStyle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FontStyle);
      }
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Size);
      }
      if (SizeUnit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SizeUnit);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FontInfo other) {
      if (other == null) {
        return;
      }
      if (other.Family.Length != 0) {
        Family = other.Family;
      }
      if (other.FontStyle != 0) {
        FontStyle = other.FontStyle;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.SizeUnit != 0) {
        SizeUnit = other.SizeUnit;
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
            Family = input.ReadString();
            break;
          }
          case 16: {
            fontStyle_ = (global::Greenshot.FileFormat.Proto.FontStyles) input.ReadEnum();
            break;
          }
          case 24: {
            Size = input.ReadUInt32();
            break;
          }
          case 32: {
            sizeUnit_ = (global::Greenshot.FileFormat.Proto.FontSizeUnits) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  //// A matrix for transformations
  /// </summary>
  public sealed partial class Matrix : pb::IMessage<Matrix> {
    private static readonly pb::MessageParser<Matrix> _parser = new pb::MessageParser<Matrix>(() => new Matrix());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Matrix> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Greenshot.FileFormat.Proto.StyleReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matrix() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matrix(Matrix other) : this() {
      rows_ = other.rows_;
      cols_ = other.cols_;
      data_ = other.data_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Matrix Clone() {
      return new Matrix(this);
    }

    /// <summary>Field number for the "rows" field.</summary>
    public const int RowsFieldNumber = 1;
    private uint rows_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Rows {
      get { return rows_; }
      set {
        rows_ = value;
      }
    }

    /// <summary>Field number for the "cols" field.</summary>
    public const int ColsFieldNumber = 2;
    private uint cols_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Cols {
      get { return cols_; }
      set {
        cols_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 3;
    private static readonly pb::FieldCodec<double> _repeated_data_codec
        = pb::FieldCodec.ForDouble(26);
    private readonly pbc::RepeatedField<double> data_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Matrix);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Matrix other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Rows != other.Rows) return false;
      if (Cols != other.Cols) return false;
      if(!data_.Equals(other.data_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Rows != 0) hash ^= Rows.GetHashCode();
      if (Cols != 0) hash ^= Cols.GetHashCode();
      hash ^= data_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Rows != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Rows);
      }
      if (Cols != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Cols);
      }
      data_.WriteTo(output, _repeated_data_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Rows != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rows);
      }
      if (Cols != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Cols);
      }
      size += data_.CalculateSize(_repeated_data_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Matrix other) {
      if (other == null) {
        return;
      }
      if (other.Rows != 0) {
        Rows = other.Rows;
      }
      if (other.Cols != 0) {
        Cols = other.Cols;
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
          case 8: {
            Rows = input.ReadUInt32();
            break;
          }
          case 16: {
            Cols = input.ReadUInt32();
            break;
          }
          case 26:
          case 25: {
            data_.AddEntriesFrom(input, _repeated_data_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code