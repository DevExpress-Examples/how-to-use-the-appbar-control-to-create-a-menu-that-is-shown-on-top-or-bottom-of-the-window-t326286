<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128659511/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T326286)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF AppBar - Display a Top or Bottom Window Menu Inspired by Windows 10

This example adds an [`AppBar`](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBar) to a WPF application and allows users to place primary commands at the top or bottom of the window. The bar contains standard and toggle buttons, groups related actions, includes a built-in **Exit** button and a button with a flyout (context) menu.

![ Display a Top or Bottom Window Menu Inspired by Windows 10 - WPF AppBar, DevExpress](./Images/app-bar.jpg)

## Implementation Details

If you set the [`AppBar.HideMode`](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBar.HideMode) property to `Sticky`, the `AppBar` remains visible until a user hides it manually through the **Exit** button. To display the predefined **Exit** button, enable the [IsExitButtonEnabled](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBar.IsExitButtonEnabled). The following XAML markup configures bar layout, visibility, and command structure:

```xaml
<dxwui:AppBar ... 
              IsOpen="True" 
              HideMode="Sticky" 
              IsExitButtonEnabled="True">
    <!-- Define "Top" and "Bottom" buttons -->
    <dxwui:AppBarButton Content="T" Label="Top" Click="OnMoveAppBarTop"/>
    <dxwui:AppBarButton Content="B" Label="Bottom" Click="OnMoveAppBarBottom"/>

    !-- Define "Zoom in" and "Zoom out" buttons -->
    <dxwui:AppBarButton Label="Zoom in" Glyph="{dx:DXImageGrayscale Image=ZoomIn_32x32.png}" />
    <dxwui:AppBarButton Label="Zoom out" Glyph="{dx:DXImageGrayscale Image=ZoomOut_32x32.png}" />
    <dxwui:AppBarSeparator />

    <!-- Define "Actual Size" and "Rotate" buttons -->
    <dxwui:AppBarButton Label="Actual Size" Glyph="{dx:DXImageGrayscale Image=Zoom_32x32.png}" />
    <dxwui:AppBarButton Label="Rotate" HorizontalAlignment="Right" Glyph="{dx:DXImage Image=DrillDown_32x32.png}" >
        <!-- Define the Flyout control that appears when a user clicks the "Rotate" button-->
        <dxwui:AppBarButton.Flyout>
            <dxwui:MenuFlyout ShowIndicator="True">
                <dxwui:MenuFlyoutItem Content="90° clockwise" />
                <dxwui:MenuFlyoutItem Content="90° counter clockwise" />
                <dxwui:MenuFlyoutSeparator />
                <dxwui:MenuFlyoutItem Content="Reset" />
            </dxwui:MenuFlyout>
        </dxwui:AppBarButton.Flyout>
    </dxwui:AppBarButton>

    <dxwui:AppBarSeparator HorizontalAlignment="Right" />
    <dxwui:AppBarToggleButton Label="Pin" HorizontalAlignment="Right">&#xE141;</dxwui:AppBarToggleButton>
</dxwui:AppBar>
```

**Top** and **Bottom** buttons move the `AppBar` to the corresponding edge of the window. Each button is bound to the corresponding handler:

```csharp
private void OnMoveAppBarTop(object sender, RoutedEventArgs e) {
    appBar.Alignment = AppBarAlignment.Top;
}

private void OnMoveAppBarBottom(object sender, RoutedEventArgs e) {
    appBar.Alignment = AppBarAlignment.Bottom;
}
```

## Files to Review

* [MainWindow.xaml](./CS/AppBarExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AppBarExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/AppBarExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AppBarExample/MainWindow.xaml.vb))

## Documentation

* [AppBar](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBar)
* [AppBarButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBarButton)
* [AppBarToggleButton](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBarToggleButton)
* [AppBarSeparator](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBarSeparator)
* [IsExitButtonEnabled](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBar.IsExitButtonEnabled)
* [AppBarButton.Label](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.AppBarButton.Label)
* [CommandButton.Glyph](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.CommandButton.Glyph)
* [MenuFlyout](https://docs.devexpress.com/WPF/DevExpress.Xpf.WindowsUI.MenuFlyout)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-appbar-control-to-create-a-menu-that-is-shown-on-top-or-bottom-of-the-window-t326286&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-the-appbar-control-to-create-a-menu-that-is-shown-on-top-or-bottom-of-the-window-t326286&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
