# **Gizmo.Client.UI Override System Theme**

Edit and compile easily in visual studio code with the extension:
Live Sass Compiler
https://marketplace.visualstudio.com/items?itemName=glenn2223.live-sass

Click on "Watch Sass" button and the extension will generate a "main.css" file.

For simple changes should be enough to modify only the "_variables.scss" file.

## **Test modified style**

To test the modified style with Gizmo.Client.UI.Host.Web or Gizmo.Client.UI.Host.WPF project:
- Put the generated "main.css" file into the "static" folder under the client's path.
- Update in the client's configuration file the ClientInterface.StyleSheet property to "StyleSheet": "main.css"

For Gizmo.Client.UI.Host.Web project the configuration file is the "appsettings.json".

For Gizmo.Client.UI.Host.WPF project the configuration file is the "options.json".

## **Apply modified style**

To apply the modified style:

- Run "ConfigurationTool"
- Open "Skin editor"
- Select the skin you want to override 
- Select the host group you want to use the modified style
- Select the "main.css" under the "Style sheet (*.css)" section

