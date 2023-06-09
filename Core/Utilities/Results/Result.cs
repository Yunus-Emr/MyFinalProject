using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        /*ikisini birden çalıştırmak istesek böyle kullanırız nedeni ise programcı sadece true yada false vermek isteyebilir
          ama biz tek ctor ile yapsaydık o zaman hem bool hemde string ifade göndermek zorunda olurduk ama aşşağıdaki yapıda sadece true yada false kullanmak istesek
          this anahtar kelimesi ile üsteki result'ı çalıştırarak istersek hem mesaj bool yada sadece bool'u kullanabiliriz    
         
        Bu Yapı constructor'un en üst kullanım şekillerinden biridir.*/
        
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
