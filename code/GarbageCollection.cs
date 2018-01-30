using System;
namespace myapp
{
   public class ManagedWord : IDisposable
   {
       bool isDisposed;
       public void Dispose()
       {
           Dispose(true);
           GC.SuppressFinalize(this);
           //throw new NotImplementedException();
       }

       

       protected virtual void Dispose(bool isDisposing)
       {
           if(this.isDisposed)
           {
               return;
           }
           if(isDisposing)
           {

           }
           this.isDisposed = true;

       }

       public void openWordDocument(string filepath)
       {
           if(isDisposed)
           {
               throw new ObjectDisposedException("ManagedWord");
           }
       }

       ~ManagedWord()
       {
           Dispose(false);
       }

       
   } 

   public class GC1
   {
       public void usingGC()
       {
           
       var word = default(ManagedWord);
       try{
           word = new ManagedWord();
       }
       catch{

       }
       finally
       {
           if(word !=null)
           {
               word.Dispose();
           }
       }
       }
   }
}