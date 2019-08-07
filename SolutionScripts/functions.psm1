function EfMigrate {
	[CmdletBinding(PositionalBinding = $false)]
    param(
        [Parameter(Position = 0, Mandatory = $true)]
        [string] $Name,
		[Alias("c")]
		[Parameter(Mandatory = $false)]
		[string] $Context = "DatabaseContext")

	$migrations = "Migrations"

	If($Context -ne "DatabaseContext")
	{
		$migrations = "$($Context)Migrations"
	}

	dotnet ef migrations add $Name -c $Context -s NetCore -p NetCore.Data -o $migrations
}

function EfUnmigrate {
	[CmdletBinding(PositionalBinding = $false)]
    param([Alias("c")]
		[Parameter(Mandatory = $false)]
		[string] $Context = "DatabaseContext")

	$migrations = "Migrations"

	If($Context -ne "DatabaseContext")
	{
		$migrations = "$($Context)Migrations"
	}
	
	dotnet ef migrations remove -c $Context -s NetCore -p NetCore.Data
}

function EfUpdate {
	[CmdletBinding(PositionalBinding = $false)]
    param(
        [Parameter(Position = 0, Mandatory = $false)]
        [string] $Name = "",
		[Alias("c")]
		[Parameter(Mandatory = $false)]
		[string] $Context = "DatabaseContext",
		[Alias("e")]
		[Parameter(Mandatory = $false)]
		[string] $Environment = "Development")

	$oldenv = $env:ENVIRONMENT
	$env:ENVIRONMENT = $Environment

	$migrations = "Migrations"

	If($Context -ne "DatabaseContext")
	{
		$migrations = "$($Context)Migrations"
	}

	dotnet ef database update $Name -c $Context -s NetCore -p NetCore.Data

	$env:ENVIRONMENT = $oldenv
}