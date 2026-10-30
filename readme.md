<image src="app-icon.png" align="right" width="200px">

# Image Compare 2 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A 2sxc / DNN App to highlight the differences between two images.

| Aspect              | Status | Comments or Version
| ------------------- | :----: | -------------------
| 2sxc                | ✅    | requires 2sxc v17.07.00
| Dnn                 | ✅    | For v9.6.1+
| Oqtane              | ✅    | Requires v05.00
| No jQuery           | ✅    | Since v2.00
| Live Demo           | ➖    | 
| Install Checklist   | ✅    | See [Installation](https://azing.org/2sxc/r/VipBSgUQ) on [azing.org](https://azing.org/2sxc)
| Source & License    | ✅    | included, ISC/MIT
| App Catalog         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/compare-images-v2-using-beerslider-hybrid-for-dnn-and-oqtane)
| Screenshots         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/compare-images-v2-using-beerslider-hybrid-for-dnn-and-oqtane)
| Best Practices      | ✅    | Uses v13.10 conventions
| Bootstrap 4         | ❌    | Last supported in v02.21.01
| Bootstrap 5         | ✔️    | Tested but not optimized

## Customize the App

The Image Compare App has neither app settings nor app resources, so there's little to configure.

But since it's open source, you can easily modify it to become anything you want.

The App uses inline-styles and style tags, which you can directly adjust in the templates.

## History

* v02.21.02 2026-10
  * Removed Bootstrap 4 support; the app is now Bootstrap 5 only
  * For Bootstrap 4, use v02.21.01

* v02.0 2021-09
  * Updated to best practices of 2sxc 12.05
  * Hybrid - now compatible with Oqtane
  * No more jQuery-use
  * Changed JS Library to use Beer
* v02.01 2022-04
  * Moved all access of Services to ToSic.Sxc.Services
  * Changed from Image Tags to IImageService
  * Activated image configuration
  * Replaced data-enableoptimization wit pageSvc.AssetAttributes()
* v02.02 2022-06 
  * Replaced all base classes with their 2sxc 14 equivalents
  * Removed all GetService<> and replaced them with the new ServiceKit14
  * Updated webpack
* v02.03 2023-05
  * Enhanced Kit.Image with `imgAltFallback`
  * Replaced turnOn Tag with `Kit.Page.TurnOn`
  * Removed _ from Filenames
* v02.04.00 2023-07
  * 2sxc 16.02 coding conventions
  * everything typed
* v02.05.00 2023-11
  * Img and Label Left to the Left Side, previously wrong
* v02.17.00 2024-04
  * Strong Typed
  * Auto Generated Class
  * Typed MyItem
* v02.17.00 2024-04
  * Update app.sln and app.csproj
* v02.21.00 2026-03
  * Added intellisense Extensions for Visual Studio Code
* v02.21.01 2026-06
  * Switched from webpack to Vite for faster builds