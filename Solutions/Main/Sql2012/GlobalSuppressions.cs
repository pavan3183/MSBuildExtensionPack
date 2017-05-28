﻿//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs">(c) 2017 Mike Fourie and Contributors (http://www.MSBuildExtensionPack.com) under MIT License. See https://opensource.org/licenses/MIT </copyright>
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Sql2012")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.BaseTask.#Execute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ManagementScope", Scope = "member", Target = "MSBuild.ExtensionPack.BaseTask.#GetManagementScope(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ManagementScope", Scope = "member", Target = "MSBuild.ExtensionPack.BaseTask.#GetManagementScope(System.String,System.Management.ConnectionOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "MachineName", Scope = "member", Target = "MSBuild.ExtensionPack.BaseTask.#TargetingLocalMachine(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Dropdown", Scope = "type", Target = "MSBuild.ExtensionPack.DropdownValueAttribute")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DatabaseItem", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#CheckExists()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TaskAction", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#InternalExecute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "NewName", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Rename()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DatabaseItem", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Restore()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "LogFilePath", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Restore()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ReplaceDatabase", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Restore()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "OutputFilePath", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Script()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "StoredProcedure", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Script()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DataFilePath", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#VerifyBackup()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DatabaseItem", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#VerifyDatabase()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "MSBuild.ExtensionPack.Sql2012.Server")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TaskAction", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Server.#InternalExecute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ProcessType", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#Process()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "OutputFilePath", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#Script(System.Action`4<Microsoft.AnalysisServices.Scripter,Microsoft.AnalysisServices.MajorObject[],System.Xml.XmlWriter,System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "InputFile", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#ExecuteScript()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "HelpFile", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#ExecuteScript()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DataSourceView", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#Script(System.Action`4<Microsoft.AnalysisServices.Scripter,Microsoft.AnalysisServices.MajorObject[],System.Xml.XmlWriter,System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TaskAction", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.AnalysisServices.#InternalExecute()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "regexpattern", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#regexpattern")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "OutputFilePath", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#ScriptData()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DatabaseItem", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#Attach()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "MSBuild.ExtensionPack.Sql2012.Database.#InternalExecute()")]