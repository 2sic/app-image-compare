// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "CompareImages.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class CompareImages
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: Image Compare/
// User:        2sic Web-Developer
// When:        2024-04-05 10:44:04Z
using System.Collections.Generic;
using ToSic.Sxc.Adam;
using ToSic.Sxc.Data;

namespace AppCode.Data
{
  // This is a generated class for CompareImages 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// CompareImages data. <br/>
  /// Generated 2024-04-05 10:44:04Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.DescriptionText`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class CompareImages: AutoGenerated.ZagCompareImages
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.CompareImages in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagCompareImages: Custom.Data.CustomItem
  {
    /// <summary>
    /// DescriptionText as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("DescriptionText", scrubHtml: true) etc.
    /// </summary>
    public string DescriptionText => _item.String("DescriptionText", fallback: "");

    /// <summary>
    /// ImageSettings as single item of ITypedItem.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. 
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public ITypedItem ImageSettings => _imageSettings ??= _item.Child("ImageSettings");
    private ITypedItem _imageSettings;

    /// <summary>
    /// LabelLeft as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("LabelLeft", scrubHtml: true) etc.
    /// </summary>
    public string LabelLeft => _item.String("LabelLeft", fallback: "");

    /// <summary>
    /// LabelRight as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("LabelRight", scrubHtml: true) etc.
    /// </summary>
    public string LabelRight => _item.String("LabelRight", fallback: "");

    /// <summary>
    /// LeftImage as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("LeftImage")
    /// </summary>
    public string LeftImage => _item.Url("LeftImage");

    /// <summary>
    /// Get the file object for LeftImage - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile LeftImageFile => _item.File("LeftImage");

    /// <summary>
    /// Get the folder object for LeftImage.
    /// </summary>
    public IFolder LeftImageFolder => _item.Folder("LeftImage");

    /// <summary>
    /// RightImage as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("RightImage")
    /// </summary>
    public string RightImage => _item.Url("RightImage");

    /// <summary>
    /// Get the file object for RightImage - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile RightImageFile => _item.File("RightImage");

    /// <summary>
    /// Get the folder object for RightImage.
    /// </summary>
    public IFolder RightImageFolder => _item.Folder("RightImage");

    /// <summary>
    /// ShowLabels as bool. <br/>
    /// To get nullable use .Get("ShowLabels") as bool?;
    /// </summary>
    public bool ShowLabels => _item.Bool("ShowLabels");

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");
  }
}