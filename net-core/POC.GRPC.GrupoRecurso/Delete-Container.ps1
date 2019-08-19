param(
    [Parameter(Mandatory = $true)]
    [string]
    $appName,

    [Parameter(Mandatory = $true)]
    [string]
    $resourceGroup
)

Remove-AzureRmContainerGroup -ResourceGroupName $resourceGroup -Name $appName