using System.Security.Cryptography;

namespace net_8 {
    public class Random {

        public void LetsGetRandomBaby() {

            var list = new List<string> {
                "one",
                "two",
                "three"
            };

            GetItems(list);
            Shuffle(list);
        }

        private void GetItems(List<string> list) {

            var readOnly = new ReadOnlySpan<string>(list.ToArray());
            var items = RandomNumberGenerator.GetItems(readOnly, 2);
        }

        private void Shuffle(List<string> list) {

            var span = new Span<string>(list.ToArray());
            RandomNumberGenerator.Shuffle(span);
        }
    }
}
