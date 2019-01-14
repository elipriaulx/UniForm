robocopy ".\UniForm.Core\bin\Release\netstandard2.0" ".\UniForm.Core\bin\Any CPU\Release\netstandard2.0" *.* /MIR
robocopy ".\UniForm.Engine\bin\Release\netstandard2.0" ".\UniForm.Engine\bin\Any CPU\Release\netstandard2.0" *.* /MIR

./Scripts/pack.bat