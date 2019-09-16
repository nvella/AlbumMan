using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace AlbumMan
{
    internal static class Yaml
    {
        public static ISerializer Serializer =>
            new SerializerBuilder()
            .WithNamingConvention(new UnderscoredNamingConvention())
            .Build();

        public static IDeserializer Deserializer =>
            new DeserializerBuilder()
            .WithNamingConvention(new UnderscoredNamingConvention())
            .Build();
    }
}
