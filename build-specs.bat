rmdir "living-documentation" /s /q
"C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe" "Algoritmos.CS.Garantias.sln"
concordion-runner\nunit-console.exe "Algoritmos.CS.Garantias.Specs\bin\Debug\Algoritmos.CS.Garantias.Specs.dll"
"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" "%~dp0\living-documentation\Algoritmos\CS\Garantias\Specs\ValoracionesPorISIN\ValoracionesPorISIN.html"
pause