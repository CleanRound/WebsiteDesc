class Website
{
    private string siteName;
    private string sitePath;
    private string siteDescription;
    private string ipAddress;

    public void InputData()
    {
        Console.Write("Enter the site name: ");
        siteName = Console.ReadLine();

        Console.Write("Enter the site path: ");
        sitePath = Console.ReadLine();

        Console.Write("Enter the site description: ");
        siteDescription = Console.ReadLine();

        Console.Write("Enter the IP address: ");
        ipAddress = Console.ReadLine();
    }

    public void OutputData()
    {
        Console.WriteLine($"Site Name: {siteName}");
        Console.WriteLine($"Site Path: {sitePath}");
        Console.WriteLine($"Site Description: {siteDescription}");
        Console.WriteLine($"IP Address: {ipAddress}");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Website myWebsite = new Website();

        myWebsite.InputData();

        myWebsite.OutputData();
    }
}