namespace NdaLesson01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello! Đức Anh");

            app.Run();
        }
    }
}
