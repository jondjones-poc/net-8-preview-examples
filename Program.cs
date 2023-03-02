namespace net_8 {
    public class Program {
        public static void Main(string[] args) {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGet("/json", (HttpContext httpContext) => {
                var serialize = new Serialize();
                serialize.LetSerializeBaby();
            });

            app.MapGet("/random", (HttpContext httpContext) => {
                var random = new Random();
                random.LetsGetRandomBaby();
            });

            app.MapGet("/frozen", (HttpContext httpContext) => {
                var frozen = new Frozen();
                frozen.FreezeMe();
            });

            app.MapGet("/indexing", (HttpContext httpContext) => {
                var indexing = new Indexing();
            });


            app.Run();
        }
    }
}