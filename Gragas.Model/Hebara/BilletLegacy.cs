using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace Gragas.Model.Hebara
{
    [ActiveRecord(Schema = "ADM_LEGADO", Table = "BILHETES_VALIDADOS")]
    public class BilletLegacy : SecondConnection<BilletLegacy>
    {
        [PrimaryKey(Column = "BILLET_ID", Generator = PrimaryKeyType.Assigned)]
        public long BilletId { get; set; }

        [Property(Column = "LOT_ID")]
        public long LotId { get; set; }

        [Property(Column = "VALIDATION_DATE")]
        public DateTime ValidationDate { get; set; }

        [Property(Column = "PRIZE")]
        public decimal Prize { get; set; }
    }
}
