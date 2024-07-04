$template = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multiwebapp.json"
$Templatepara = "D:\Devops Practice\DevOpsPipelining\MyCalculatorApp\scripts\multiwebapp.parameter.json"

$rgName = 'automate-rg'

New-AzResourceGroupDeployment `
-Name webappDeploy `
-ResourceGroupName $rgName `
-TemplateFile $template `
-TemplateParameterFile $Templatepara -Verbose