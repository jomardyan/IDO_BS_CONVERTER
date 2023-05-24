
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class offer
{

    private offerProducts productsField;

    private string file_formatField;

    private string generatedField;

    private string expiresField;

    private decimal versionField;

    private string extensionsField;

    /// <remarks/>
    public offerProducts products
    {
        get
        {
            return this.productsField;
        }
        set
        {
            this.productsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string file_format
    {
        get
        {
            return this.file_formatField;
        }
        set
        {
            this.file_formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string generated
    {
        get
        {
            return this.generatedField;
        }
        set
        {
            this.generatedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extensions
    {
        get
        {
            return this.extensionsField;
        }
        set
        {
            this.extensionsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProducts
{

    private offerProductsProduct[] productField;

    private string currencyField;

    private string iof_translation_generatedField;

    private string languageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("product")]
    public offerProductsProduct[] product
    {
        get
        {
            return this.productField;
        }
        set
        {
            this.productField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string iof_translation_generated
    {
        get
        {
            return this.iof_translation_generatedField;
        }
        set
        {
            this.iof_translation_generatedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string language
    {
        get
        {
            return this.languageField;
        }
        set
        {
            this.languageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProduct
{

    private object[] itemsField;

    private ushort idField;

    private string currencyField;

    private string code_on_cardField;

    private string producer_code_standardField;

    private string typeField;

    private decimal vatField;

    private bool vatFieldSpecified;

    private string siteField;

    private string deletedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("attachments", typeof(offerProductsProductAttachments))]
    [System.Xml.Serialization.XmlElementAttribute("card", typeof(offerProductsProductCard))]
    [System.Xml.Serialization.XmlElementAttribute("category", typeof(offerProductsProductCategory))]
    [System.Xml.Serialization.XmlElementAttribute("category_idosell", typeof(offerProductsProductCategory_idosell))]
    [System.Xml.Serialization.XmlElementAttribute("description", typeof(offerProductsProductDescription))]
    [System.Xml.Serialization.XmlElementAttribute("group", typeof(offerProductsProductGroup))]
    [System.Xml.Serialization.XmlElementAttribute("inwrapper", typeof(inwrapper), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("omnibus_price_retail", typeof(omnibus_price_retail), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("omnibus_price_wholesale", typeof(omnibus_price_wholesale), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("price_retail_dynamic", typeof(price_retail_dynamic), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("sell_by", typeof(sell_by), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("services_descriptions", typeof(object), Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    [System.Xml.Serialization.XmlElementAttribute("images", typeof(offerProductsProductImages))]
    [System.Xml.Serialization.XmlElementAttribute("parameters", typeof(offerProductsProductParameters))]
    [System.Xml.Serialization.XmlElementAttribute("price", typeof(offerProductsProductPrice))]
    [System.Xml.Serialization.XmlElementAttribute("producer", typeof(offerProductsProductProducer))]
    [System.Xml.Serialization.XmlElementAttribute("sizes", typeof(offerProductsProductSizes))]
    [System.Xml.Serialization.XmlElementAttribute("srp", typeof(offerProductsProductSrp))]
    [System.Xml.Serialization.XmlElementAttribute("unit", typeof(offerProductsProductUnit))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code_on_card
    {
        get
        {
            return this.code_on_cardField;
        }
        set
        {
            this.code_on_cardField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string producer_code_standard
    {
        get
        {
            return this.producer_code_standardField;
        }
        set
        {
            this.producer_code_standardField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vat
    {
        get
        {
            return this.vatField;
        }
        set
        {
            this.vatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vatSpecified
    {
        get
        {
            return this.vatFieldSpecified;
        }
        set
        {
            this.vatFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string site
    {
        get
        {
            return this.siteField;
        }
        set
        {
            this.siteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deleted
    {
        get
        {
            return this.deletedField;
        }
        set
        {
            this.deletedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductAttachments
{

    private offerProductsProductAttachmentsFile[] fileField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("file")]
    public offerProductsProductAttachmentsFile[] file
    {
        get
        {
            return this.fileField;
        }
        set
        {
            this.fileField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductAttachmentsFile
{

    private offerProductsProductAttachmentsFileName nameField;

    private string versionField;

    private string urlField;

    private byte priorityField;

    private string attachment_file_typeField;

    private string attachment_file_extensionField;

    private string enableField;

    private string download_logField;

    /// <remarks/>
    public offerProductsProductAttachmentsFileName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string attachment_file_type
    {
        get
        {
            return this.attachment_file_typeField;
        }
        set
        {
            this.attachment_file_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string attachment_file_extension
    {
        get
        {
            return this.attachment_file_extensionField;
        }
        set
        {
            this.attachment_file_extensionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string enable
    {
        get
        {
            return this.enableField;
        }
        set
        {
            this.enableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string download_log
    {
        get
        {
            return this.download_logField;
        }
        set
        {
            this.download_logField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductAttachmentsFileName
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductCard
{

    private string urlField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductCategory
{

    private uint idField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductCategory_idosell
{

    private ushort idField;

    private string pathField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string path
    {
        get
        {
            return this.pathField;
        }
        set
        {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescription
{

    private offerProductsProductDescriptionName[] nameField;

    private offerProductsProductDescriptionVersion versionField;

    private offerProductsProductDescriptionLong_desc long_descField;

    private offerProductsProductDescriptionShort_desc short_descField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name")]
    public offerProductsProductDescriptionName[] name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductDescriptionVersion version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductDescriptionLong_desc long_desc
    {
        get
        {
            return this.long_descField;
        }
        set
        {
            this.long_descField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductDescriptionShort_desc short_desc
    {
        get
        {
            return this.short_descField;
        }
        set
        {
            this.short_descField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescriptionName
{

    private string langField;

    private string typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescriptionVersion
{

    private offerProductsProductDescriptionVersionName nameField;

    private string name1Field;

    /// <remarks/>
    public offerProductsProductDescriptionVersionName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("name")]
    public string name1
    {
        get
        {
            return this.name1Field;
        }
        set
        {
            this.name1Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescriptionVersionName
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescriptionLong_desc
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductDescriptionShort_desc
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductGroup
{

    private offerProductsProductGroupGroup_by_parameter group_by_parameterField;

    private ushort idField;

    private ushort first_product_idField;

    private string first_product_code_producerField;

    private string first_product_code_iaiField;

    /// <remarks/>
    public offerProductsProductGroupGroup_by_parameter group_by_parameter
    {
        get
        {
            return this.group_by_parameterField;
        }
        set
        {
            this.group_by_parameterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort first_product_id
    {
        get
        {
            return this.first_product_idField;
        }
        set
        {
            this.first_product_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string first_product_code_producer
    {
        get
        {
            return this.first_product_code_producerField;
        }
        set
        {
            this.first_product_code_producerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string first_product_code_iai
    {
        get
        {
            return this.first_product_code_iaiField;
        }
        set
        {
            this.first_product_code_iaiField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductGroupGroup_by_parameter
{

    private offerProductsProductGroupGroup_by_parameterName nameField;

    private offerProductsProductGroupGroup_by_parameterProduct_value product_valueField;

    private string idField;

    /// <remarks/>
    public offerProductsProductGroupGroup_by_parameterName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductGroupGroup_by_parameterProduct_value product_value
    {
        get
        {
            return this.product_valueField;
        }
        set
        {
            this.product_valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductGroupGroup_by_parameterName
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductGroupGroup_by_parameterProduct_value
{

    private offerProductsProductGroupGroup_by_parameterProduct_valueName nameField;

    private string idField;

    /// <remarks/>
    public offerProductsProductGroupGroup_by_parameterProduct_valueName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductGroupGroup_by_parameterProduct_valueName
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
public partial class inwrapper
{

    private byte quantityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
public partial class omnibus_price_retail
{

    private omnibus_price_retailSite siteField;

    /// <remarks/>
    public omnibus_price_retailSite site
    {
        get
        {
            return this.siteField;
        }
        set
        {
            this.siteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
public partial class omnibus_price_retailSite
{

    private byte idField;

    private byte size_idField;

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte size_id
    {
        get
        {
            return this.size_idField;
        }
        set
        {
            this.size_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
public partial class omnibus_price_wholesale
{

    private omnibus_price_wholesaleSite siteField;

    /// <remarks/>
    public omnibus_price_wholesaleSite site
    {
        get
        {
            return this.siteField;
        }
        set
        {
            this.siteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
public partial class omnibus_price_wholesaleSite
{

    private byte idField;

    private byte size_idField;

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte size_id
    {
        get
        {
            return this.size_idField;
        }
        set
        {
            this.size_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
public partial class price_retail_dynamic
{

    private price_retail_dynamicSite siteField;

    /// <remarks/>
    public price_retail_dynamicSite site
    {
        get
        {
            return this.siteField;
        }
        set
        {
            this.siteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
public partial class price_retail_dynamicSite
{

    private byte idField;

    private byte size_idField;

    private byte grossField;

    private byte netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte size_id
    {
        get
        {
            return this.size_idField;
        }
        set
        {
            this.size_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml", IsNullable = false)]
public partial class sell_by
{

    private sell_byRetail retailField;

    private sell_byWholesale wholesaleField;

    /// <remarks/>
    public sell_byRetail retail
    {
        get
        {
            return this.retailField;
        }
        set
        {
            this.retailField = value;
        }
    }

    /// <remarks/>
    public sell_byWholesale wholesale
    {
        get
        {
            return this.wholesaleField;
        }
        set
        {
            this.wholesaleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
public partial class sell_byRetail
{

    private byte quantityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
public partial class sell_byWholesale
{

    private byte quantityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImages
{

    private offerProductsProductImagesImage[] largeField;

    private offerProductsProductImagesIcons iconsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
    public offerProductsProductImagesImage[] large
    {
        get
        {
            return this.largeField;
        }
        set
        {
            this.largeField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductImagesIcons icons
    {
        get
        {
            return this.iconsField;
        }
        set
        {
            this.iconsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImagesImage
{

    private byte priorityField;

    private string urlField;

    private string hashField;

    private string changedField;

    private ushort widthField;

    private ushort heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public byte priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changed
    {
        get
        {
            return this.changedField;
        }
        set
        {
            this.changedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImagesIcons
{

    private offerProductsProductImagesIconsIcon iconField;

    private offerProductsProductImagesIconsAuction_icon auction_iconField;

    private offerProductsProductImagesIconsGroup_icon group_iconField;

    /// <remarks/>
    public offerProductsProductImagesIconsIcon icon
    {
        get
        {
            return this.iconField;
        }
        set
        {
            this.iconField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductImagesIconsAuction_icon auction_icon
    {
        get
        {
            return this.auction_iconField;
        }
        set
        {
            this.auction_iconField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductImagesIconsGroup_icon group_icon
    {
        get
        {
            return this.group_iconField;
        }
        set
        {
            this.group_iconField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImagesIconsIcon
{

    private string urlField;

    private string hashField;

    private string changedField;

    private ushort widthField;

    private byte heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changed
    {
        get
        {
            return this.changedField;
        }
        set
        {
            this.changedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImagesIconsAuction_icon
{

    private string urlField;

    private string changedField;

    private string hashField;

    private ushort widthField;

    private ushort heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changed
    {
        get
        {
            return this.changedField;
        }
        set
        {
            this.changedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductImagesIconsGroup_icon
{

    private string urlField;

    private string hashField;

    private string changedField;

    private ushort widthField;

    private ushort heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hash
    {
        get
        {
            return this.hashField;
        }
        set
        {
            this.hashField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string changed
    {
        get
        {
            return this.changedField;
        }
        set
        {
            this.changedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductParameters
{

    private offerProductsProductParametersParameter[] parameterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public offerProductsProductParametersParameter[] parameter
    {
        get
        {
            return this.parameterField;
        }
        set
        {
            this.parameterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductParametersParameter
{

    private offerProductsProductParametersParameterValue[] valueField;

    private string typeField;

    private ushort idField;

    private byte priorityField;

    private string distinctionField;

    private string group_distinctionField;

    private string hideField;

    private string auction_template_hideField;

    private string nameField;

    private string context_idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public offerProductsProductParametersParameterValue[] value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string distinction
    {
        get
        {
            return this.distinctionField;
        }
        set
        {
            this.distinctionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string group_distinction
    {
        get
        {
            return this.group_distinctionField;
        }
        set
        {
            this.group_distinctionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hide
    {
        get
        {
            return this.hideField;
        }
        set
        {
            this.hideField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string auction_template_hide
    {
        get
        {
            return this.auction_template_hideField;
        }
        set
        {
            this.auction_template_hideField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string context_id
    {
        get
        {
            return this.context_idField;
        }
        set
        {
            this.context_idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductParametersParameterValue
{

    private ushort idField;

    private byte priorityField;

    private string nameField;

    private string context_idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string context_id
    {
        get
        {
            return this.context_idField;
        }
        set
        {
            this.context_idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductPrice
{

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductProducer
{

    private uint idField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSizes
{

    private offerProductsProductSizesSize sizeField;

    private string group_nameField;

    private sbyte group_idField;

    private bool group_idFieldSpecified;

    private string sizeListField;

    /// <remarks/>
    public offerProductsProductSizesSize size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string group_name
    {
        get
        {
            return this.group_nameField;
        }
        set
        {
            this.group_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public sbyte group_id
    {
        get
        {
            return this.group_idField;
        }
        set
        {
            this.group_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool group_idSpecified
    {
        get
        {
            return this.group_idFieldSpecified;
        }
        set
        {
            this.group_idFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string sizeList
    {
        get
        {
            return this.sizeListField;
        }
        set
        {
            this.sizeListField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSizesSize
{

    private offerProductsProductSizesSizePrice priceField;

    private offerProductsProductSizesSizeSrp srpField;

    private offerProductsProductSizesSizeStock[] stockField;

    private string idField;

    private string nameField;

    private string panel_nameField;

    private string codeField;

    private ushort weightField;

    private ushort weight_netField;

    private string code_producerField;

    private byte priorityField;

    private string code_externalField;

    /// <remarks/>
    public offerProductsProductSizesSizePrice price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    public offerProductsProductSizesSizeSrp srp
    {
        get
        {
            return this.srpField;
        }
        set
        {
            this.srpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("stock")]
    public offerProductsProductSizesSizeStock[] stock
    {
        get
        {
            return this.stockField;
        }
        set
        {
            this.stockField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string panel_name
    {
        get
        {
            return this.panel_nameField;
        }
        set
        {
            this.panel_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public ushort weight_net
    {
        get
        {
            return this.weight_netField;
        }
        set
        {
            this.weight_netField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code_producer
    {
        get
        {
            return this.code_producerField;
        }
        set
        {
            this.code_producerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public byte priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.iai-shop.com/developers/iof/extensions.phtml")]
    public string code_external
    {
        get
        {
            return this.code_externalField;
        }
        set
        {
            this.code_externalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSizesSizePrice
{

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSizesSizeSrp
{

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSizesSizeStock
{

    private byte idField;

    private decimal quantityField;

    private decimal available_stock_quantityField;

    private decimal stock_quantityField;

    private byte location_idField;

    private bool location_idFieldSpecified;

    private string location_text_idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal available_stock_quantity
    {
        get
        {
            return this.available_stock_quantityField;
        }
        set
        {
            this.available_stock_quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal stock_quantity
    {
        get
        {
            return this.stock_quantityField;
        }
        set
        {
            this.stock_quantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte location_id
    {
        get
        {
            return this.location_idField;
        }
        set
        {
            this.location_idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool location_idSpecified
    {
        get
        {
            return this.location_idFieldSpecified;
        }
        set
        {
            this.location_idFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string location_text_id
    {
        get
        {
            return this.location_text_idField;
        }
        set
        {
            this.location_text_idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductSrp
{

    private decimal grossField;

    private decimal netField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gross
    {
        get
        {
            return this.grossField;
        }
        set
        {
            this.grossField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal net
    {
        get
        {
            return this.netField;
        }
        set
        {
            this.netField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class offerProductsProductUnit
{

    private byte idField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

