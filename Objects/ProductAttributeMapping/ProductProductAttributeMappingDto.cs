

namespace nopCommerceWebApiClient.Objects.ProductAttributeMapping
{
    public class ProductProductAttributeMappingDto
    {
        public virtual int Id { get; init; }

        /// <summary>
        /// ## ProductAttributeId
        /// ### Gets or set the product attribute identifier
        /// </summary>
        //[Required]
        public virtual int ProductAttributeId { get; init; }

        /// <summary>
        /// ## ProductId
        /// ### Gets or set the product identifier
        /// </summary>
        //[Required]
        public virtual int ProductId { get; init; }

        /// <summary>
        /// ## TextPrompt
        /// ### Gets or set the text prompt
        /// *Default = null*
        /// </summary>
        public virtual string? TextPrompt { get; init; }

        /// <summary>
        /// ### Gets or set a value indicating whether the attribute is required
        /// #### When an attribute is required, the customer must choose an appropriate attribute value before they can continue.
        /// *Default = false*
        /// </summary>
        public virtual bool IsRequired { get; init; }

        /// <summary>
        /// ### Gets or set the attribute control type identifier
        /// #### Choose how to display your attribute values.
        /// ** Defines the types of form controls available for use in the application. **
        /// * DropdownList (1): A dropdown list allowing single selection among multiple options.
        /// * RadioList (2): A list of radio buttons allowing single selection among multiple options.
        /// * Checkboxes (3): A group of checkboxes allowing multiple selections.
        /// * TextBox (4): A single-line text input field.
        /// * MultilineTextbox (10): A multi-line text input field for longer inputs.
        /// * Datepicker (20): A control for selecting a date.
        /// * FileUpload (30): A control for uploading files.
        /// * ColorSquares (40): A selection of color squares allowing users to pick a color.
        /// * ImageSquares (45): A selection of image squares allowing users to pick an image.
        /// * ReadonlyCheckboxes (50): A group of checkboxes that are read-only, typically used for displaying information.
        /// </summary>
        //[Required]
        public virtual int AttributeControlTypeId { get; init; }

        /// <summary>
        /// ### Gets or set the display order
        /// #### The attribute display order. 1 represents the first item in the list.
        /// *Default = 0*
        /// </summary>
        public virtual int DisplayOrder { get; init; }

        /// <summary>
        /// ## ValidationMinLength
        /// ### Gets or set the minimum length of the attribute value
        /// *Default = null*
        /// </summary>
        public virtual int? ValidationMinLength { get; init; }

        /// <summary>
        /// ## ValidationMaxLength
        /// ### Gets or sets the maximum length of the attribute value
        /// *Default = null*
        /// </summary>
        public virtual int? ValidationMaxLength { get; init; }

        /// <summary>
        /// ## ValidationFileAllowedExtensions
        /// ### Gets or set the allowed file extensions
        /// *Default = null*
        /// </summary>
        public virtual string? ValidationFileAllowedExtensions { get; init; }

        /// <summary>
        /// ## ValidationFileMaximumSize 
        /// ### Gets or sets the maximum size of the file
        /// *Default = null*
        /// </summary>
        public virtual int? ValidationFileMaximumSize { get; init; }

        /// <summary>
        /// ## DefaultValue 
        /// ### Gets or set the default value
        /// *Default = null*
        /// </summary>
        public virtual string? DefaultValue { get; init; }

        /// <summary>
        /// ## ConditionAttributeXml
        /// ### Gets or sets the condition attribute XML
        /// *Deafault = null*
        /// </summary>
        public virtual string? ConditionAttributeXml { get; init; }
    }
}
