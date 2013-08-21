using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;

namespace Gragas.Model.Eagle
{
    public enum BilletValidationResult
    {
        Prized = 1,
        PrizedButRequiresConfirmation,
        PrizedAndShouldBeReclaimedOnLoterj,
        NotPrized,
        AlreadyValidated,
        Invalid,
        Prescribed,
        AlreadyValidatedSameClient,
        AlreadyValidatedAnotherClient
    }

    [ActiveRecord(Schema = "EAGLE", Table = "CachedValidatedBillet")]
    public class BilletEagle : ThirdConnection<BilletEagle>
    {
        [PrimaryKey(Column = "Id", Generator = PrimaryKeyType.Assigned)]
        public long Id { get; set; }

        [Property(Column = "CashPrize", NotNull = false)]
        public decimal? CashPrize { get; set; }

        [Property(Column = "Result")]
        public BilletValidationResult Result { get; set; }

        [Property(Column = "TotalOfRevalidations")]
        public int TotalOfRevalidations { get; set; }

        [Property(Column = "OperatorCode", NotNull = false)]
        public string OperatorCode { get; set; }

        [Property(Column = "ValidationDate")]
        public DateTime ValidationDate { get; set; }

        [Property(Column = "LoterjEndDate")]
        public DateTime? LoterjEndDate { get; set; }

        [Property(Column = "LoterjStartDate")]
        public DateTime? LoterjStartDate { get; set; }


    }
}
