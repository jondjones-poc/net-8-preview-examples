using System.Collections.Frozen;

namespace net_8 {
    public class Frozen {

        public void FreezeMe() {
            Dictionary<string, string> example = new Dictionary<string, string>();
            FrozenDictionary<string, string> frozen = example.ToFrozenDictionary();
        }
    }
}
