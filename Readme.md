<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128659511/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T326286)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/AppBarExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AppBarExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/AppBarExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AppBarExample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Use the AppBar Control to Create a Menu That Is Shown on Top or Bottom of the Window


<p>This example shows how to create an app bar containing custom regular and toggle buttons, the predefined <em>Exit</em> button, and the button that displays a flyout when clicked.</p>
<p>In this example, the <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIAppBartopic.aspx">AppBar</a> control is populated with the <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIAppBarButtontopic.aspx">AppBarButton</a> and <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIAppBarToggleButtontopic.aspx">AppBarToggleButton</a> objects, which are divided into groups using the <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIAppBarSeparatortopic.aspx">AppBarSeparator</a> objects. To display the predefined <em>Exit</em> button, the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfWindowsUIAppBar_IsExitButtonEnabledtopic.aspx">IsExitButtonEnabled</a> property is set to <strong>True</strong>.</p>
<p>The button captions are specified using the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfWindowsUIAppBarButton_Labeltopic.aspx">AppBarButton.Label</a> property. The <strong>HorizontalAlignment</strong> property specifies the button alignment relative to the app bar.</p>
<p>The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfWindowsUICommandButton_Glyphtopic.aspx">CommandButton.Glyph</a> property is used to provide the buttons with icons from the DX Image Gallery. The glyph theming feature is enabled for all buttons and the glyph height is set using the Style declared in the app bar's <strong>Resources</strong>. You can also use the button's <strong>Content</strong> property to specify the button icons. See the <em>Pin</em> button — the icon for this button is specified using the Unicode symbol that corresponds to the glyph in the Segoe UI Symbol font. For more information about how to use Segoe UI Symbol icons, see <a href="https://msdn.microsoft.com/en-us/library/windows/apps/jj841126.aspx">Guidelines</a> on MSDN.</p>
<p>The <em>Rotate</em> button displays the flyout when clicked. The button's <strong>Flyout</strong> property allows you associate the <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIFlyouttopic.aspx">Flyout</a> or <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfWindowsUIMenuFlyouttopic.aspx">MenuFlyout</a> control with the button.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-appbar-control-to-create-a-menu-that-is-shown-on-top-or-bottom-of-the-window-t326286&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-appbar-control-to-create-a-menu-that-is-shown-on-top-or-bottom-of-the-window-t326286&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
