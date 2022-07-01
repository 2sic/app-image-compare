<image src="app-icon.png" align="right" width="200px">

# Image Compare 2 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A 2sxc / DNN App to highlight the differences between two images.

| Aspect              | Status | Comments or Version |
| ------------------- | :----: | ------------------- |
| 2sxc                | ✅    | ImageCompare v2.0 requires 2sxc v13.10
| Dnn                 | ✅    | For v7, v8 and v9
| Oqtane 2            | ✅    | Requires v2.02
| No jQuery           | ✅    | Since v2.00
| Live Demo           | ➖    | 
| Install Checklist   | ✅    | See [Installation](https://azing.org/2sxc/r/VipBSgUQ) on [azing.org](https://azing.org/2sxc)
| Source & License    | ✅    | included, ISC/MIT
| App Catalog         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/compare-images-v2-using-beerslider-hybrid-for-dnn-and-oqtane)
| Screenshots         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/compare-images-v2-using-beerslider-hybrid-for-dnn-and-oqtane)
| Best Practices      | ✅    | Uses v13.10 conventions
| Bootstrap 4         | ✅    | v4 optimized
| Bootstrap 5         | ✔️    | Tested but not optimized

## Customize the App

The Image Compare App has neither app settings nor app resources, so there's little to configure.

But since it's open source, you can easily modify it to become anything you want.

The App uses inline-styles and style tags, which you can directly adjust in the templates.

## History

* v2.0 2021-09
    * Updated to best practices of 2sxc 12.05
    * Hybrid - now compatible with Oqtane
    * No more jQuery-use
    * Changed JS Library to use Beer

* v2.01 2022-04
    * Moved all access of Services to ToSic.Sxc.Services
    * Changed from Image Tags to IImageService
    * Activated image configuration
    * Replaced data-enableoptimization wit pageSvc.AssetAttributes()

* v2.02 2022-06 
    * Replaced all base classes with their 2sxc 14 equivalents
    * Removed all GetService<> and replaced them with the new ServiceKit14
    * Updated webpack