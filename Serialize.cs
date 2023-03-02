using System.Text.Json;

namespace net_8 {
    public class Serialize {

        public void LetSerializeBaby() {

            SerializeInterfaceHierarchies();
            Kebab();
            Snake();
        }

        private static void Snake() {

            var snakeOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
            };
            snakeOptions.MakeReadOnly();

            var snake = JsonSerializer.Serialize(new { ThisIsALongNameExample = "Hi" }, snakeOptions);
        }

        private static void Kebab() {

            var kebabOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower
            };
            var kebab = JsonSerializer.Serialize(new { ThisIsALongNameExample = "Hi" }, kebabOptions);
        }

        public void SerializeInterfaceHierarchies() {

            var value = new DemoObjects
            {
                Root = "Root",
                Child = "Child"
            };

            var data = JsonSerializer.Serialize(value);
        }
    }
}
