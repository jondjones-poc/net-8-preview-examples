using System.Buffers;
using System.Globalization;
using System.Text;

namespace net_8 {
    public class Performance {

        public Performance() {

            IndexOfAnyValuesExample();
            CompositeFormatExample();
        }

        public void IndexOfAnyValuesExample() {

            var example = "This is some text";

            var oldWay = "is".ToCharArray();
            var oldIndex = example.IndexOfAny(oldWay);

            var newWay = IndexOfAnyValues.Create("is");
            var newIndex = example.AsSpan().IndexOfAny(newWay);
        }

        public void CompositeFormatExample() {

            var example = "This is some {0}";

            var newWay = CompositeFormat.Parse(example);

            var newIndex = newWay.Format;
            var result = string.Format(CultureInfo.InvariantCulture, newWay, "Text");
        }
    }
}
