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


