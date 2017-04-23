using System;

namespace NBShop.Model.Abstract
{
    public interface IAuditable
    {
        #region Create

        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        #endregion Create

        #region SEO

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        #endregion SEO

        bool Status { get; set; }
    }
}