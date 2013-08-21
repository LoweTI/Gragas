using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace Gragas.Model.Repository
{
    [ActiveRecord(Schema = "GRAGAS")]
    public class Server : ActiveRecordLinqBase<Server>
    {
        [PrimaryKey(Column = "Id", Generator = PrimaryKeyType.HiLo)]
        public int Id { get; set; }

        [Property(Column = "Name")]
        public string Name { get; set; }



    }
}
