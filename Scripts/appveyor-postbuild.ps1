robocopy ".\UniForm.Core\bin\Release\netstandard2.0" ".\UniForm.Core\bin\Any CPU\Release\netstandard2.0" *.* /MIR
robocopy ".\UniForm.Engine\bin\Release\netstandard2.0" ".\UniForm.Engine\bin\Any CPU\Release\netstandard2.0" *.* /MIR

# robocopy ".\UniForm.Core\bin\Release\netstandard2.0" "C:.\UniForm.Core\bin\Any CPU\Release\netstandard2.0" *.* /MIR

Tree
dir ".\UniForm.Wpf\bin\Release\"

./Scripts/pack.bat