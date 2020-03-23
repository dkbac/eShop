using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class CategoryTranslation
    {
        public int CategoryTranslationID { set; get; }
        public int CategoryID { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageID { set; get; }
        public string SeoAlias { set; get; }

        public Category Category { get; set; }
        public Language Language { get; set; }

    }
}
