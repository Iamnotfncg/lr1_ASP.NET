namespace pr1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            var rand = new Random();
            var company = new Company() { Name ="AMD", Location= "Santa Clara", Description= "Makes processor" };

            app.Run(async (context) => {
                await context.Response.WriteAsync($"{company}\nRandom number: {rand.Next(101)}");
            });

            app.Run();
        }
    }
}