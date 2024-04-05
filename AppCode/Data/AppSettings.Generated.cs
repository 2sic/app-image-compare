// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppSettings.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppSettings
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: Image Compare/
// User:        2sic Web-Developer
// When:        2024-04-05 10:44:04Z
namespace AppCode.Data
{
  // This is a generated class for AppSettings (scope: System.App)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppSettings data. <br/>
  /// Generated 2024-04-05 10:44:04Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Title`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.App.
  /// </remarks>
  public partial class AppSettings: AutoGenerated.ZagAppSettings
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.App.AppSettings in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagAppSettings: Custom.Data.CustomItem
  {
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