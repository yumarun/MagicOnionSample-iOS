using Grpc.Core;
using MagicOnion.Client;
using UnityEngine;
using UnityEngine.UI;

public class ClientTest : MonoBehaviour
{
    [SerializeField]
    Text _text;

    async void Start()
    {
        var channel = new Channel("192.168.2.107", 7000, ChannelCredentials.Insecure);
        var client = MagicOnionClient.Create<MagicOnionSampleiOSServer.IMyFirstService>(channel);
        var result = await client.SumAsync(1, 2);
        _text.text = $"Result: {result}";
        await channel.ShutdownAsync();
    }

    
}
