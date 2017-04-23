using System;
using System.ComponentModel.DataAnnotations;

namespace NBShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        #region Create

        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        #endregion Create

        #region SEO
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }

        #endregion SEO

        public bool Status { get; set; }
    }
}