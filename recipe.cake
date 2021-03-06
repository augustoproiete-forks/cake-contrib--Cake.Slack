#load nuget:?package=Cake.Recipe&version=1.0.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src",
                            title: "Cake.Slack",
                            repositoryOwner: "cake-contrib",
                            repositoryName: "Cake.Slack",
                            appVeyorAccountName: "cakecontrib",
                            shouldRunDupFinder: false,
                            shouldRunInspectCode: false,
                            shouldRunGitVersion: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                            dupFinderExcludePattern: new string[] {
                                BuildParameters.RootDirectoryPath + "/src/Cake.Slack/**/*.AssemblyInfo.cs",
                                BuildParameters.RootDirectoryPath + "/src/Cake.Slack/LitJson/**/*.cs" });

Build.RunDotNetCore();
