while ($True)
{
    $DNSOutputs = @()
    $FindNetAdapter = Get-NetAdapter | Where-Object {($_.Name -eq "Ethernet" -or $_.Name -eq "Wi-Fi") -and $_.Status -eq "Up"} | Sort-Object Name
    $InterfaceIndex = $FindNetAdapter.InterfaceIndex
    
    function PingDNS ($DNS, [ref]$DNSOutputs)
    {
        $Ping = Test-Connection -Count 4 -ComputerName $DNS
        $Average = ($Ping | Measure-Object ResponseTime -Average).Average
        $DNSOutputs.Value += $Average
    }
    PingDNS "8.8.8.8" ([ref]$DNSOutputs)
    PingDNS "9.9.9.9" ([ref]$DNSOutputs)
    PingDNS "1.1.1.1" ([ref]$DNSOutputs)
    
    $LowestPing = ($DNSOutputs | Measure-Object -Minimum).Minimum
    
    switch ($LowestPing)
    {
        $DNSOutputs[0] { Set-DnsClientServerAddress -InterfaceIndex $InterfaceIndex -ServerAddresses "8.8.8.8" }
        $DNSOutputs[1] { Set-DnsClientServerAddress -InterfaceIndex $InterfaceIndex -ServerAddresses "9.9.9.9" }
        $DNSOutputs[2] { Set-DnsClientServerAddress -InterfaceIndex $InterfaceIndex -ServerAddresses "1.1.1.1" }
    }
    Start-Sleep -Seconds 30
}