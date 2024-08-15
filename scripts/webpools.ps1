$TempFile = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multiwebapp.json"
$TempParaFile = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multiwebapp.parameter.json"
$rg = 'autosite-rg'
#$loc = 'eastasia'

#New-AzResourceGroup -Name $rg -Location $loc
New-AzResourceGroupDeployment `
-Name 'deployapps' `
-ResourceGroupName $rg `
-TemplateFile $TempFile `
-TemplateParameterFile $TempParaFile -Verbose
