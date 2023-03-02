using System.Text.Json.Serialization;

namespace net_8 {

    public interface IRoot {

        public string Root { get; set; }
    }

    public interface IChild : IRoot {

        public string Child { get; set; }
    }


    [JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
    public class DemoObjects : IChild {

        public string Root { get; set; }

        public string Child { get; set; }
    }
}
