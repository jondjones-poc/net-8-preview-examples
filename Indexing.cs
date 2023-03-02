using System.Buffers;
using System.Globalization;
using System.Text;

namespace net_8 {
    public class Indexing {

        public Indexing() {

            IndexOfAnyValuesExample();
            CompositeFormatExample();
        }

        public void IndexOfAnyValuesExample() {

            var example = "-.0123456789ABCDEFGH IJKLMNOPQRST UVWXYZ_abcdefghijklmnopqrstuvwxyz";

            var oldWay = "012".ToCharArray();
            int oldIndex = example.IndexOfAny(oldWay);

            var newWay = IndexOfAnyValues.Create("012");
            int newIndex = example.AsSpan().IndexOfAny(newWay);
        }

        public void CompositeFormatExample() {

            var example = "This is some {0}";

            var newWay = CompositeFormat.Parse(example);

            var newIndex = newWay.Format;
            var result = string.Format(CultureInfo.InvariantCulture, newWay, "Text");
        }
    }
}
