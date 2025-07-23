param(
    [string] $GamingMode
)
$Cpu = Get-CimInstance -ClassName Win32_Processor
$GamingModeBool = $GamingMode -eq "true" -or $GamingMode -eq "True"

if ($GamingModeBool)
{
    if ($Cpu.Name -like "*AMD*")
    {
        powercfg /setactive 9935e61f-1661-40c5-ae2f-8495027d5d5d # AMD Ryzen's High Performance
    }
    else 
    {
        powercfg /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c # High performace (intel dosent have)
    }
}
else
{
    if ($Cpu.Name -like "*AMD*")
    {
        powercfg /setactive 9897998c-92de-4669-853f-b7cd3ecb2790 # AMD Ryzen's Balanced
    }
    else 
    {
        powercfg /setactive 381b4222-f694-41f0-9685-ff5bb260df2e # Balanced for intel
    }
}