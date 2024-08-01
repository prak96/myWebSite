$TempFile = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multivm.json"
$TempParaFile = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multivm.parameter.json"
$rg = 'webpool-rg'
#$loc = 'eastasia'

#New-AzResourceGroup -Name $rg -Location $loc
New-AzResourceGroupDeployment `
-Name 'deployvm1' `
-ResourceGroupName $rg `
-TemplateFile $TempFile `
-TemplateParameterFile $TempParaFile -Verbose