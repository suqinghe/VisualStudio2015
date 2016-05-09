using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckInventoryWorkflowLib;
using System.Activities;

namespace WorkflowLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Inventory Look Up ****");

            Console.WriteLine("Enter Color:");
            var color = Console.ReadLine();

            Console.WriteLine("Enter Make:");
            var make = Console.ReadLine();

            var wfArgs = new Dictionary<string, object>()
            {
                { "RequestedColor",color},
                {"RequestedMake",make }
            };

            try
            {
                var outputArgs = WorkflowInvoker.Invoke( new CheckInventory(), wfArgs );

                Console.WriteLine(outputArgs["FormattedResponse"]);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
