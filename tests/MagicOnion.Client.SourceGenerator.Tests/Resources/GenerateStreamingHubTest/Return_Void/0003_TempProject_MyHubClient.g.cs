﻿// <auto-generated />
#pragma warning disable CS0618 // 'member' is obsolete: 'text'
#pragma warning disable CS0612 // 'member' is obsolete
#pragma warning disable CS0414 // The private field 'field' is assigned but its value is never used
#pragma warning disable CS8019 // Unnecessary using directive.
#pragma warning disable CS1522 // Empty switch block

namespace TempProject
{
    partial class MagicOnionInitializer
    {
        static partial class MagicOnionGeneratedClient
        {
            [global::MagicOnion.Ignore]
            public class TempProject_MyHubClient : global::MagicOnion.Client.StreamingHubClientBase<global::TempProject.IMyHub, global::TempProject.IMyHubReceiver>, global::TempProject.IMyHub
            {
                public TempProject_MyHubClient(global::Grpc.Core.CallInvoker callInvoker, global::System.String host, global::Grpc.Core.CallOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider, global::MagicOnion.Client.IMagicOnionClientLogger logger)
                    : base("IMyHub", callInvoker, host, options, serializerProvider, logger)
                {
                }

                public void A()
                    => this.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1005848884, global::MessagePack.Nil.Default);

                public global::TempProject.IMyHub FireAndForget()
                    => new FireAndForgetClient(this);
                    
                [global::MagicOnion.Ignore]
                class FireAndForgetClient : global::TempProject.IMyHub
                {
                    readonly TempProject_MyHubClient parent;

                    public FireAndForgetClient(TempProject_MyHubClient parent)
                        => this.parent = parent;

                    public global::TempProject.IMyHub FireAndForget() => this;
                    public global::System.Threading.Tasks.Task DisposeAsync() => throw new global::System.NotSupportedException();
                    public global::System.Threading.Tasks.Task WaitForDisconnect() => throw new global::System.NotSupportedException();

                    public void A()
                        => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1005848884, global::MessagePack.Nil.Default);

                }

                protected override void OnBroadcastEvent(global::System.Int32 methodId, global::System.ReadOnlyMemory<global::System.Byte> data)
                {
                    switch (methodId)
                    {
                    }
                }

                protected override void OnResponseEvent(global::System.Int32 methodId, global::System.Object taskCompletionSource, global::System.ReadOnlyMemory<global::System.Byte> data)
                {
                    switch (methodId)
                    {
                        case -1005848884: // Void A()
                            base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                            break;
                    }
                }

            }
        }
    }
}
