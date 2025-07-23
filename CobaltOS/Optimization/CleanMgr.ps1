# Delete Recycle Bin
Clear-RecycleBin -Force

# Delete Downloaded Program Files
Remove-Item "$env:SystemRoot\Downloaded Program Files\*" -Recurse -Force -ErrorAction SilentlyContinue

# Delete Temporary Internet Files
Remove-Item "$env:LOCALAPPDATA\Microsoft\Windows\INetCache\*" -Recurse -Force -ErrorAction SilentlyContinue

# Delete Delivery Optimization Files
Remove-Item "C:\Windows\SoftwareDistribution\DeliveryOptimization\*" -Recurse -Force -ErrorAction SilentlyContinue