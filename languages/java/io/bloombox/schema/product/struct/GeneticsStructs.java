// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: structs/Genetics.proto

package io.bloombox.schema.product.struct;

public final class GeneticsStructs {
  private GeneticsStructs() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_Genetics_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_Genetics_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\026structs/Genetics.proto\032\022content/Name.p" +
      "roto\"6\n\010Genetics\022\023\n\004male\030\001 \001(\0132\005.Name\022\025\n" +
      "\006female\030\002 \001(\0132\005.NameB6\n!io.bloombox.sche" +
      "ma.product.structB\017GeneticsStructsP\001b\006pr" +
      "oto3"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
        new com.google.protobuf.Descriptors.FileDescriptor.    InternalDescriptorAssigner() {
          public com.google.protobuf.ExtensionRegistry assignDescriptors(
              com.google.protobuf.Descriptors.FileDescriptor root) {
            descriptor = root;
            return null;
          }
        };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          io.bloombox.schema.content.NameContent.getDescriptor(),
        }, assigner);
    internal_static_Genetics_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_Genetics_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_Genetics_descriptor,
        new java.lang.String[] { "Male", "Female", });
    io.bloombox.schema.content.NameContent.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}