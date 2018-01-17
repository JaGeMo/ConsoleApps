using System;
using System.IO;
using System.Text;

namespace Console04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // first approach 
            StreamReader tmpStrRead = null;
            try
            {
                tmpStrRead = new StreamReader(@"/Users/janm/tmp/Code/ConsoleApps/file.zip");
                var content = tmpStrRead.ReadToEnd();
            }
            catch (DirectoryNotFoundException exDnF)
            {
                Console.WriteLine("file not found because of " + exDnF.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some other issue due to " + ex.Message);
            }
            finally
            {
                if(tmpStrRead != null)  
                {
                    tmpStrRead.Dispose();
                }
            }

            // second approach 
            try
            {
                using (StreamReader tmpStrRead2 = new StreamReader(@"/Users/janm/tmp/Code/ConsoleApps/file.zip"))
                {
                    var content = tmpStrRead.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("some other issue due to " + ex.Message);
            }

        }
    }
}
