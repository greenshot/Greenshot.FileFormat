using Google.Protobuf;
using Greenshot.FileFormat.Proto;
using System.IO;
using Xunit;

namespace Greenshot.FileFormat.Tests
{
    public class ProtoSerializeTests
    {
        [Fact]
        public void TestSerialize()
        {
            var screenshot = new GreenshotFile();

            using (var output = File.Create("screenshot.gs"))
            {
                screenshot.WriteTo(output);
            }
        }
    }
}
