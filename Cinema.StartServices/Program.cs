namespace Cinema.StartServices
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8000/");

            // Step 2 Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(Cinema.WCFService.Classes.CinemaService), baseAddress);
            try
            {
                selfHost.Open();
                Console.WriteLine("The service is hosted.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException)
            {
                Console.WriteLine("Need to run it with Administrator rights.");
                selfHost.Abort();
                Console.ReadLine();
            }            
        }
    }
}
