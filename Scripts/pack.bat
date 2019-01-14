.\Tools\nuget.exe pack UniForm.Core\UniForm.Core.csproj -Prop Configuration=Release -Verbosity detailed
.\Tools\nuget.exe pack UniForm.Engine\UniForm.Engine.csproj -Prop Configuration=Release -Verbosity detailed
.\Tools\nuget.exe pack UniForm.Wpf\UniForm.Wpf.csproj -Prop Configuration=Release -Verbosity detailed -Build

