using System;
using System.Globalization;
using System.IO;
namespace myapp
{
    class GarbageCollection1
    {
        public void AnyMethod()
        {
            StreamReader streamReaderObject = null;
            try
            {
                streamReaderObject = new StreamReader("file.txt");
                String contents = streamReaderObject.ReadToEnd();
                streamReaderObject.Close();
                Console.WriteLine("The file has {0} text elements", new StringInfo(contents).LengthInTextElements);
        }
            catch (FileNotFoundException)
            {
           Console.WriteLine("The file can not be found"); 
        }
            finally
            {
            if(streamReaderObject != null)
            {
            streamReaderObject.Dispose();
            }
        }

        }
    }

}