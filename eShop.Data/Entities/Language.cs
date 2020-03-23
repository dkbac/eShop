using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Language
    {
        public int LanguageID { get; set; }

        public string LanguageCode { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
