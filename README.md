# WeekTray

Provides a little tray icon for Windows which shows the current calendar week.


## Color

A hex color code (e.g. #85adad) for the text color might be passed as argument. Default color is white.


## Usage

Create a shortcut to WeekTray.exe in %APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup

If you want to change the text color, open the properties of this shortcut and change value of 'Target' to 

```powershell
"[FOLDER_OF_WEEK_TRAY]\WeekTray.exe" #85adad
```

## Screenshots

### Shortcut location
![weektray_shortcut_in_startup](http://sebdotnet.bplaced.net/weektray/weektray_shortcut_in_startup.png)

### Default

#### Preview
![weektray_preview](http://sebdotnet.bplaced.net/weektray/weektray_preview.png)

### Custom color

#### Shortcut properties
![weektray_shortcut_properties](http://sebdotnet.bplaced.net/weektray/weektray_shortcut_properties.png)

#### Preview
![weektray_preview_custom_color](http://sebdotnet.bplaced.net/weektray/weektray_preview_custom_color.png)

