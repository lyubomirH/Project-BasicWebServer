using WebServer.Server;
using WebServer.Server.Responses;

namespace WebServer.demo
{
    public class StartUp
    {
        public static void Main()
        {
            var server = new HttpServer(routes =>
            {                                                                        //Други проблеми може да дойдат от Extensions
                routes
                .MapGet("/", new TextResponse("Hello from the server!"))             // Проблем при търсене на един и същ URL Програмата гърми
                .MapGet("/HTML", new HtmlResponse("<h1>HTML response</h1>"))         //
                .MapGet("/Redirect", new RedirectResponse("https://softuni.org/"));  //
            });
            server.Start();
        }
    }
}
