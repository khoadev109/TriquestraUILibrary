# Introduction 
Library to host all the designs for the UI elements defined on this [Figma document](https://www.figma.com/file/QBeNd925P0e1ngf5PwMkGZ/Triquestra?node-id=208%3A11&t=xewP0IJcnoK94zPN-0), on the `Style-Guide` section.

This solution's pipeline creates a nuget package called `Infinity.Blazor.UIControls`.

# Getting Started
## Software dependencies 
The nuget package uses _Telerik for Blazor_ as the base for the components. Make sure the `Nuget.config` has valid credentials to download versions of the Telerik nuget packages. This is more important for the pipelines as it uses that file to restore the packages needed for the solution.


# Build and Test
- Define the UI Controls in the `Infinity.Blazor.UIControls` project.
  - Add a Razor file for each new control
  - Add a partial C# class for the razor file added on the previous step
  - All css-styles have to be added to the `infinity-blazor-uicontrols.css` stylesheet file, this is the file that will get added to the nuget package along with the controls
- After finished implementing the ui control, go to the appropriate page in the `Infinity.Blazor.UIControls.Web` project and add it there (it it's a button add it to the `Buttons.razor` page, a text box on the `InputFields.razor`, etc)
  - This will allow you to test the control without having to deal with nuget packages creation and update just to test controls.

# Usage
If the target Blazor project is a Razor Library:
- On the Blazor application where the Blazor Library is used, add the following to the **head** section of the `index.html` file (usually on the `wwwroot` folder)

```
<link href="_content/Infinity.Blazor.UIControls/infinity-blazor-uicontrols.css" rel="stylesheet" />

<link href='https://fonts.googleapis.com/css?family=Roboto:100,200,300,400,500,600,700,800' rel='stylesheet' />
<link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Rounded:opsz,wght,FILL,GRAD@48,400,0,0" />
<link href="https://fonts.googleapis.com/icon?family=Material+Icons|Material+Icons+Outlined|Material+Symbols+Outlined" rel="stylesheet">
```


Also add to the same `index.html` file the `<link ... />` for the javascript and stylesheets needed for Telerik to work, usually:
- https://blazor.cdn.telerik.com/blazor/`<version>`/telerik-blazor.min.js
- _content/Telerik.UI.for.Blazor/js/telerik-blazor.js
  
and any theme the Blazor application is using that integrates with Telerik for Blazor (kendo theme)