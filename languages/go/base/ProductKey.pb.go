// Code generated by protoc-gen-go. DO NOT EDIT.
// source: base/ProductKey.proto

package schema

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

type ProductKey struct {
	Id string `protobuf:"bytes,1,opt,name=id" json:"id,omitempty"`
}

func (m *ProductKey) Reset()                    { *m = ProductKey{} }
func (m *ProductKey) String() string            { return proto.CompactTextString(m) }
func (*ProductKey) ProtoMessage()               {}
func (*ProductKey) Descriptor() ([]byte, []int) { return fileDescriptor3, []int{0} }

func (m *ProductKey) GetId() string {
	if m != nil {
		return m.Id
	}
	return ""
}

func init() {
	proto.RegisterType((*ProductKey)(nil), "ProductKey")
}

func init() { proto.RegisterFile("base/ProductKey.proto", fileDescriptor3) }

var fileDescriptor3 = []byte{
	// 109 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0x12, 0x4d, 0x4a, 0x2c, 0x4e,
	0xd5, 0x0f, 0x28, 0xca, 0x4f, 0x29, 0x4d, 0x2e, 0xf1, 0x4e, 0xad, 0xd4, 0x2b, 0x28, 0xca, 0x2f,
	0xc9, 0x57, 0x92, 0xe1, 0xe2, 0x42, 0x88, 0x09, 0xf1, 0x71, 0x31, 0x65, 0xa6, 0x48, 0x30, 0x2a,
	0x30, 0x6a, 0x70, 0x06, 0x31, 0x65, 0xa6, 0x38, 0x69, 0x73, 0x89, 0x67, 0xe6, 0xeb, 0x25, 0xe5,
	0xe4, 0xe7, 0xe7, 0x26, 0xe5, 0x57, 0xe8, 0x15, 0x27, 0x67, 0xa4, 0xe6, 0x26, 0xea, 0x81, 0x4c,
	0x72, 0xe2, 0x73, 0x4a, 0x2c, 0x4e, 0x45, 0x68, 0x0d, 0x60, 0x4c, 0x62, 0x03, 0x9b, 0x68, 0x0c,
	0x08, 0x00, 0x00, 0xff, 0xff, 0x7b, 0xee, 0x19, 0xb6, 0x6a, 0x00, 0x00, 0x00,
}