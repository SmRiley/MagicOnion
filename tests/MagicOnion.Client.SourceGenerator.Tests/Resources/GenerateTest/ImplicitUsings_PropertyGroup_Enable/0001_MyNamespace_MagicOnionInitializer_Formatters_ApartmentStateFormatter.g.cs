﻿// <auto-generated />
#pragma warning disable CS0618 // 'member' is obsolete: 'text'
#pragma warning disable CS0612 // 'member' is obsolete
#pragma warning disable CS8019 // Unnecessary using directive.

namespace MyNamespace
{
    using global::System;
    using global::MessagePack;

    partial class MagicOnionInitializer
    {
        static class MessagePackEnumFormatters
        {
            public sealed class ApartmentStateFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::System.Threading.ApartmentState>
            {
                public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::System.Threading.ApartmentState value, global::MessagePack.MessagePackSerializerOptions options)
                {
                    writer.Write((Int32)value);
                }
                
                public global::System.Threading.ApartmentState Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
                {
                    return (global::System.Threading.ApartmentState)reader.ReadInt32();
                }
            }
        }
    }
}
